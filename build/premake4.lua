solution "xlnt"
    configurations { "Debug", "Release" }
    platforms { "x64" }
    location ("./" .. _ACTION)
    configuration "Debug"
        flags { "Symbols" }

project "xlnt"
    kind "StaticLib"
    language "C++"
    targetdir "../lib/"
    includedirs { 
       "../include/xlnt",
       "../third-party/pugixml/src",
       "../third-party/miniz"
    }
    files {
       "../source/**.cpp",
       "../source/**.hpp",
       "../include/xlnt/**.hpp",
       "../third-party/pugixml/src/pugixml.cpp",
       "../third-party/miniz/miniz.c"
    }
    flags { "Unicode" }
    configuration "Debug"
        flags { "FatalWarnings" }
    configuration "windows"
        defines { 
	   "WIN32",
	   "_CRT_SECURE_NO_WARNINGS"
	}
