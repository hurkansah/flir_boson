    Building Boson Example
    ======================

    This file contains information for building the Boson example
    under MS-Windows and Linux.


    Copy Definition Files:
    ------------------------
    Before running 'make', user will need to copy the appropriate DLL and .def file from 
    ../FSLP_Files into the make directory in order to successfully build the example.
    
    Modifying Example.c:
    ------------------------
    Line 14 of Example.c will need to be updated to match whatever serial port number your OS
    assigns the Boson camera.
    
    There is a helper functions "FSLP_lookup_port_id" to convert human readable port names to the correct index.
    See the FSLP module's serialPortAdapter.c and serialPortAdapter.h files for details on serial port indexing and the lookup.

    Makefile Options:
    ------------
    Default 'make all' will build 32-bit and 64-bit executables for the host OS

    User can also choose to build executables of specific bitness and file type with the following commands:
        'make Example_64.exe'; builds a Windows 64-bit executable
        'make Example_32.exe'; builds a Windows 64-bit executable
        'make Example_64.a'; builds a Linux 64-bit executable
        'make Example_32.a'; builds a Linux 32-bit executable