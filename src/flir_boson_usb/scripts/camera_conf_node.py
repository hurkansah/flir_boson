#!/usr/bin/env python3
import rclpy
from rclpy.node import Node

# Boson Python SDK interface
from boson import CamAPI

from rcl_interfaces.msg import (
    ParameterDescriptor,
    FloatingPointRange,
    IntegerRange,
    SetParametersResult,
)


class CameraConfNode(Node):
    """
    ROS2 node that exposes FLIR Boson AGC parameters as dynamic parameters.
    Every parameter update is directly forwarded to the Boson over serial.
    """

    def __init__(self):
        super().__init__('camera_conf')

        # --- Helper functions for declaring parameter ranges ---
        def fp_range(min_v, max_v):
            """Floating-point parameter range helper."""
            return [FloatingPointRange(
                from_value=float(min_v),
                to_value=float(max_v),
                step=0.0
            )]

        def int_range(min_v, max_v, step=1):
            """Integer parameter range helper."""
            return [IntegerRange(
                from_value=int(min_v),
                to_value=int(max_v),
                step=int(step)
            )]

        # --- Declare AGC parameters (mirroring ROS1 Camera.cfg structure) ---
        self.declare_parameter(
            'OutlierCut',
            1.0,
            ParameterDescriptor(
                name='OutlierCut',
                description='AGC Tail Rejection (OutlierCut)',
                floating_point_range=fp_range(0.0, 49.0),
            ),
        )

        self.declare_parameter(
            'MaxGain',
            1.3,
            ParameterDescriptor(
                name='MaxGain',
                description='Maximum AGC gain',
                floating_point_range=fp_range(0.25, 8.0),
            ),
        )

        self.declare_parameter(
            'DF',
            13.0,
            ParameterDescriptor(
                name='DF',
                description='AGC Damping Function (DF)',
                floating_point_range=fp_range(0.0, 100.0),
            ),
        )

        self.declare_parameter(
            'Gamma',
            1.3,
            ParameterDescriptor(
                name='Gamma',
                description='AGC ACE Gamma value',
                floating_point_range=fp_range(0.5, 4.0),
            ),
        )

        self.declare_parameter(
            'PercentPerBin',
            3.0,
            ParameterDescriptor(
                name='PercentPerBin',
                description='AGC Histogram Plateau Value',
                floating_point_range=fp_range(0.0, 100.0),
            ),
        )

        self.declare_parameter(
            'LinearPercent',
            13.0,
            ParameterDescriptor(
                name='LinearPercent',
                description='AGC linear mode percentage',
                floating_point_range=fp_range(0.0, 100.0),
            ),
        )

        self.declare_parameter(
            'DetailHeadroom',
            15,
            ParameterDescriptor(
                name='DetailHeadroom',
                description='AGC Detail Headroom (integer)',
                integer_range=int_range(0, 127, 1),
            ),
        )

        self.declare_parameter(
            'd2br',
            1.3,
            ParameterDescriptor(
                name='d2br',
                description='AGC DDE parameter (d2br)',
                floating_point_range=fp_range(0.0, 8.0),
            ),
        )

        self.declare_parameter(
            'SigmaR',
            1250.0,
            ParameterDescriptor(
                name='SigmaR',
                description='AGC smoothing parameter (SigmaR)',
                floating_point_range=fp_range(1.0, 10000.0),
            ),
        )

        self.declare_parameter(
            'OutlierCutBalance',
            1.0,
            ParameterDescriptor(
                name='OutlierCutBalance',
                description='Balance factor for OutlierCut',
                floating_point_range=fp_range(0.0, 2.0),
            ),
        )

        # Serial port for Boson (same as ROS1 driver)
        self.port_ = "/dev/ttyACM0"

        # Register parameter-change callback
        self.add_on_set_parameters_callback(self.on_params_changed)

        # Apply all declared AGC parameters once at startup
        self.apply_all_params()

    # ----------------------------------------------------------------------
    def apply_all_params(self):
        """
        Apply all AGC parameters once during node startup.
        This ensures the camera is initialized with the declared defaults.
        """
        try:
            cam = CamAPI.pyClient(manualport=self.port_)

            # Retrieve all parameters at once
            params = self.get_parameters([
                'PercentPerBin',
                'LinearPercent',
                'OutlierCut',
                'MaxGain',
                'DF',
                'Gamma',
                'DetailHeadroom',
                'd2br',
                'SigmaR',
                'OutlierCutBalance',
            ])
            vals = {p.name: p.value for p in params}

            # Forward values to camera
            cam.agcSetPercentPerBin(vals['PercentPerBin'])
            cam.agcSetLinearPercent(vals['LinearPercent'])
            cam.agcSetOutlierCut(vals['OutlierCut'])
            cam.agcSetMaxGain(vals['MaxGain'])
            cam.agcSetdf(vals['DF'])
            cam.agcSetGamma(vals['Gamma'])
            cam.agcSetDetailHeadroom(vals['DetailHeadroom'])
            cam.agcSetd2br(vals['d2br'])
            cam.agcSetSigmaR(vals['SigmaR'])
            cam.agcSetOutlierCutBalance(vals['OutlierCutBalance'])

            self.get_logger().info(f"Initial AGC params applied: {vals}")

        except Exception as e:
            self.get_logger().error(f"Failed to apply initial AGC parameters: {e}")

    # ----------------------------------------------------------------------
    def on_params_changed(self, params):
        """
        Callback executed whenever any declared parameter changes.
        Each parameter change is forwarded to the Boson immediately.
        """
        result = SetParametersResult()

        try:
            cam = CamAPI.pyClient(manualport=self.port_)

            # Apply only the changed parameters
            for p in params:
                name = p.name
                val = p.value

                if name == 'PercentPerBin':
                    cam.agcSetPercentPerBin(val)
                elif name == 'LinearPercent':
                    cam.agcSetLinearPercent(val)
                elif name == 'OutlierCut':
                    cam.agcSetOutlierCut(val)
                elif name == 'MaxGain':
                    cam.agcSetMaxGain(val)
                elif name == 'DF':
                    cam.agcSetdf(val)
                elif name == 'Gamma':
                    cam.agcSetGamma(val)
                elif name == 'DetailHeadroom':
                    cam.agcSetDetailHeadroom(val)
                elif name == 'd2br':
                    cam.agcSetd2br(val)
                elif name == 'SigmaR':
                    cam.agcSetSigmaR(val)
                elif name == 'OutlierCutBalance':
                    cam.agcSetOutlierCutBalance(val)

            self.get_logger().info(
                f"Updated AGC params: {[ (p.name, p.value) for p in params ]}"
            )

            result.successful = True
            result.reason = "updated"
            return result

        except Exception as e:
            self.get_logger().error(f"Failed to update AGC parameters: {e}")
            result.successful = False
            result.reason = str(e)
            return result

    # ----------------------------------------------------------------------
def main(args=None):
    rclpy.init(args=args)
    node = CameraConfNode()
    rclpy.spin(node)
    node.destroy_node()
    rclpy.shutdown()


if __name__ == "__main__":
    main()

