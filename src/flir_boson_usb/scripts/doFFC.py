#!/usr/bin/env python3

import os
from boson import *

def main():
	try:
		myCam = CamAPI.pyClient(manualport="/dev/ttyACM0")
		myCam.bosonRunFFC()
		print(f"Success!")
	except Exception as e:
		print(f"Failed: {e}")

if __name__ == "__main__":
    main()
