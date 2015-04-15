xlnt-ue4
====

## Introduction
xlnt-ue4 is a C++11 library for reading, writing, and modifying xlsx files for Unreal Engine 4, based on https://github.com/tfussell/xlnt.

##Installation
###Install from release:
1. Download release from https://github.com/AlanIWBFT/xlnt-ue4/releases
2. Copy /xlnt into UE4InstallationFolder/Engine/Source/ThirdParty/
3. Installation now completed.

###Install from source:
1. Download premake5 from http://sourceforge.net/projects/premake/files/ and put premake5.exe into /build.
2. Run
      premake5 vs2013
   and you will get /build/vs2013/xlnt.sln
3. Clone pugixml(https://github.com/zeux/pugixml) into /third-party/pugixml
4. Open /build/vs2013/xlnt.sln and set the configuration to Release, then build (x64 by default). You will get xlnt_release_x64.lib in /lib.
5. mkdir UE4InstallationFolder/Engine/Source/ThirdParty/xlnt, and copy all the contents of xlnt-ue4 into that folder.
6. Installation now completed.

## Usage
1. Edit your ProjectName.Build.cs, and add the following line:
```c#
PublicDependencyModuleNames.Add("xlnt");
```

2.
```c++
#include "ThirdParty/xlnt/include/xlnt/xlnt.hpp"
```
or
```c++
#include "xlnt/xlnt.hpp" //(there may be some IntelliSense errors, but it doesn't matter)
```

3.
```c++
xlnt::workbook wb;
xlnt::worksheet ws = wb.get_active_sheet();
ws.get_cell("A1").set_value("Hello World!");
ws.get_cell("A2").set_value("你好，世界！"); //wstring support
wb.save("test.xlsx");

wb.load("test.xlsx");
ws = wb.get_active_sheet();

GEngine->AddOnScreenDebugMessage(-1, 15.0f, FColor::Red, ws.get_cell("A1").get_value().to_wstring().c_str());
GEngine->AddOnScreenDebugMessage(-1, 15.0f, FColor::Red, ws.get_cell("A2").get_value().to_wstring().c_str());
```

## License
xlnt is currently released to the public for free under the terms of the MIT License:

Copyright (c) 2014 Thomas Fussell

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
