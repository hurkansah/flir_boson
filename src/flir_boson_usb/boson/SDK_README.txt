This Software Development Kit (SDK) is used for Command and Control operations with a FLIR Boson (or similar) camera.
Commands (also refererred to as APIs) are provided for getting information from the camera (ex: serial number, image statistics, etc.) or for controlling camera operations (ex: change AGC settings, request table/gain switch, etc.)

The SDK is broken into several hierarchical structures:
  1. API layer -- User-callable functions
  2. FLIR Binary Protocol (FBP) layer
    a. Translator -- API name to binary command code
    b. Packager -- data packing and serialization
    c. Outputs a packet with ID, sequence number, status, and any additional data
  3. FLIR Serial Line Protocol (FSLP) layer
    a. Contains implementation of transmitting FBP and other data over a generic serial-port interface
    b. Wraps packet with control characters, channel specifier, and CRC
  4. COM layer -- Hardware and OS specific communication driver
    a. single-byte Rx, multi-byte Tx, timeouts, initialization, etc.
    b. an example implementation(s) may be provided in some versions of the SDK 

Structures 1, 2 and 3 (non OS and hardware specific) should largely remain unmodified.
Structure 4 is intended to be modified or replaced as necessary to adapt to the target system configuration. 

File/Folder list: 
  - ClientFiles_[C|C#|Python] -- folder contains API and FPB layer for a given language
  - FSLP_Files -- Contains FSLP layer and may include an example COM implementation
    * Makefile -- basic makefile for used when compiling (will need to be modified for target environment)
    * serialPortAdapter.h -- required interface between FSLP logic and COM layer (do not change!)
    * serialPortAdapter.c -- custom logic to adapt COM library to above interface (will need to be created for each serial library)
    * FSLP.c(h) -- main FSLP implementation, wrap and unwrap FSLP transmissions
    * flirChannels.c(h) -- definition of expected FSLP channel ids
    * flirCRC.c(h) -- reference implementation of CRC calculations used by the FSLP layer
    * timeoutLogic.c(h) -- utilities for calculating time differences on Linux and Windows
    * rs232.c(h) -- if present, third-party serial library (replace with appropriate library for the target environment)

Notes:
    Detailed documention for FSLP and FBP are contained in FLIR Document #102-9013-00.
    FSLP and COM layer are intended to be compiled into a dynamic library, and later linked into a specific API and FBP implementation.
    Python and C use one of the pre-compiled FSLP libraries from FSLP_Files.
    Python has an experimental (and known incomplete) re-implementation of FSLP logic using the default pySerial library (specify argument useDll=False for pyClient.Initialize())
    C# uses a similar, but more complete native COM port implementation, but can be modified to use the same library as Python and C.
    C# is neither intended nor tested for usability in .NET Core for Linux compatibility. 

Quick start with Python:
  1. Use python 3 (tested with 3.5.1)
  2. Navigate to the folder containing the SDK.
    a. The SDK folder should contain ClientFiles_Python, FSLP_Files, __init__.py, and usually a VERSION file.
    b. Assuming the SDK is called "BosonSDK" and is located at "/home/username/BosonSDK", here is a set of commands to run Flat Field Correction and read the camera's serial number:
$ python3
>>> import os
>>> os.chdir("/home/username")
>>> from BosonSDK import *
>>> myCam = CamAPI.pyClient(manualport="/dev/ttyUSB0") # or manualport="COM7" on Windows
>>> myCam.bosonRunFFC()
>>> result, serialnumber = myCam.bosonGetCameraSN()
>>> myCam.Close() # or myCam.closeComm() if you plan on reopening the connection later (i.e. does not free serial port instance)


Re-compiling FSLP libraries:
  1. Navigate to the SDK folder, then the FSLP_Files subfolder
  2. Execute the makefile with the correct target for your platform:
    a. "make" or "make all" will guess if you are on windows or linux, and attempt to build a 64-bit library.
    b. "make <target>" can be used to select non-default configurations (listed below)
$ make FSLP_64.so
$ make FSLP_32.so
$ make FSLP_64.dll 
$ make FSLP_32.dll 
  Notes: 
  - The SDK is delivered with libraries pre-compiled for most desktop architectures. Source code is provided to support embedded or non-standard environments.
  - Potential Makefile changes required:
    * If compiling on a different platform, the CC and CFLAGS variable along with the OSNAME logic may need to be updated.
    * If changing the serial port library only, the LINUX_SERIAL or WIN32_SERIAL variable will need to be updated.
  - Potential Source code changes required:
    * If changing the serial port library, serialPortAdapter.c will need to rewritten to import and wrap the new library.
  - The Windows environment:
    * mingw (32-bit) and mingw32-make are assumed to be installed and configured. (used for both 32 and 64 bit compilations)
      - Tested using both manual and GUI installation: http://www.mingw.org/wiki/Getting_Started (GNU Make 3.82.90, gcc (GCC) 4.8.1 )
    * Tiny C-Compiler 64-bit (tcc) is recommended as the 64-bit compiler
      - https://bellard.org/tcc/ (tcc version 0.9.26 (x86-64 Win64))
