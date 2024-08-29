from .ClientFiles_Python import EnumTypes as EE
from .ClientFiles_Python import Client_API as CamAPI
from .ClientFiles_Python import Serializer_Struct as SS
from .ClientFiles_Python.EnumTypes import *
from .ClientFiles_Python.Serializer_Struct import *
from .ClientFiles_Python import __dict__

__all__ = ['CamAPI','EE','SS']

for item in EE.__dict__.items():
    if "FLR_" in item[0] and isinstance(item[1],type):
        __all__.append(item[0])
        __dict__[item[0]] = item[1]
        
for item in SS.__dict__.items():
    if "FLR_" in item[0] and isinstance(item[1],type):
        __all__.append(item[0])
        __dict__[item[0]] = item[1]
