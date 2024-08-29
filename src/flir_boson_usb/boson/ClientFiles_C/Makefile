WARNINGS =
CC = gcc -g -fPIC
CCwin64 = tcc
CFLAGS=-I.

LDFLAGS_64 = -m64
LDFLAGS_32 = -m32

# Configure target extensions for executable, library files, and the remove command based on OS-type
OSNAME := $(OS)
ifeq ($(OSNAME),Windows_NT)
	TARGET = Example_32.exe Example_64.exe
	PATHSEP_RAW=\\
	RM=del /S
else
	#If Linux or Cygwin, obtain kernel configuration using getconf
	TARGET = Example_32.a Example_64.a
	PATHSEP_RAW=/
	RM=rm -f
endif

# Directory for object files
OBJDIR=obj

#Remove trailing space from PATHSEP_RAW
PATHSEP=$(strip $(PATHSEP_RAW))

# Directory for source files (currently not used)
#IDIR =./

# List of files needed to build executable
SRCS = Client_API Client_Dispatcher Client_Interface \
		Client_Packager Serializer_BuiltIn Serializer_Struct \
		UART_Connector
		
# Point to source files if in a different directory from Makefile
#SRCS = $(patsubst %,$(IDIR)/%,$(SRCS))

# GCC will generate prerequisites from source files automatically	
DEPENDS = $(patsubst %,%.d,$(SRCS))

OBJ64 = $(patsubst %,$(OBJDIR)/%_64.o,$(SRCS))
OBJ32 = $(patsubst %,$(OBJDIR)/%_32.o,$(SRCS))
OBJ64_LINUX = $(patsubst %,$(OBJDIR)/%_Linux64.o,$(SRCS))
OBJ32_LINUX = $(patsubst %,$(OBJDIR)/%_Linux32.o,$(SRCS))

# Executable Recipes
all: $(TARGET)

Example_64.exe: Example.c FSLP_64.def C_SDK_64.def
	$(CCwin64) $(WARNINGS) -Wl,-rpath=. $(LDFLAGS_64) -v $^ $(CFLAGS) -o $@

# 32-bit library is statically-linked so does not have module def file
Example_32.exe: Example.c FSLP_32.dll C_SDK_32.dll
	$(CC) $(WARNINGS) -Wl,-rpath=. $(LDFLAGS_32) -v $^ $(CFLAGS) -o $@

Example_64.a: Example.c FSLP_64.so C_SDK_64.so
	$(CC) $(WARNINGS) -Wl,-rpath=. $(LDFLAGS_64) -v $^ $(CFLAGS) -o $@
	
Example_32.a: Example.c FSLP_32.so C_SDK_32.so
	$(CC) $(WARNINGS) -Wl,-rpath=. $(LDFLAGS_32) -v $^ $(CFLAGS) -o $@

# SDK Recipes
# As per ReadMe.txt, user is responsible for copying the appropriate .dll and .def, or .so from ../FSLP_Files/
# into this directory to build the Camera SDK.
C_SDK_64.dll C_SDK_64.def: $(OBJ64)
	$(CCwin64) $(WARNINGS) -v -shared $(LDFLAGS_64) -o C_SDK_64.dll $^ FSLP_64.def

C_SDK_32.dll: $(OBJ32)
	$(CC) $(WARNINGS) -v -shared $(LDFLAGS_32) -o C_SDK_32.dll $^ FSLP_32.dll

C_SDK_64.so: $(OBJ64_LINUX)
	$(CC) $(WARNINGS) -shared $(LDFLAGS_64) -o $@ $^ FSLP_64.so

C_SDK_32.so: $(OBJ32_LINUX)
	$(CC) $(WARNINGS) -shared $(LDFLAGS_32) -o $@ $^ FSLP_32.so

# Create directory to store object files if it does not exist
$(OBJ64) $(OBJ32) $(OBJ64_LINUX) $(OBJ32_LINUX): | $(OBJDIR)

$(OBJDIR):
	mkdir $(OBJDIR)

# Read all header file dependencies and regenerate prerequisites if necessary
-include $(DEPENDS)

# Build target for every object file
$(OBJDIR)/%_64.o: %.c Makefile
	$(CCwin64) $(WARNINGS) $(LDFLAGS_64) -v -c -o $@ $< $(CFLAGS)

$(OBJDIR)/%_32.o: %.c Makefile
	$(CC) $(WARNINGS) $(LDFLAGS_32) -v -c -o $@ $< $(CFLAGS)

$(OBJDIR)/%_Linux64.o: %.c Makefile
	$(CC) $(WARNINGS) $(LDFLAGS_64) -v -c -o $@ $< $(CFLAGS)

$(OBJDIR)/%_Linux32.o: %.c Makefile
	$(CC) $(WARNINGS) $(LDFLAGS_32) -v -c -o $@ $< $(CFLAGS)

# Clean-up recipes
.PHONY: clean
clean:
	-${RM} $(OBJDIR)$(PATHSEP)*.o $(OBJDIR)$(PATHSEP)*.d

.PHONY: clean_sdk32
clean_sdk32:
	-${RM} C_SDK_32.*

.PHONY: clean_sdk64
clean_sdk64:
	-${RM} C_SDK_64.*
	
.PHONY: clean_all
clean_all: clean clean_sdk32 clean_sdk64
