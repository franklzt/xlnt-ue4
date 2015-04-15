solution "xlnt"
    configurations { "Debug", "Release" }
    platforms { "x64" }
    location ("./" .. _ACTION)
    configuration "Debug"
        flags { "Symbols" }
	optimize "Off"
    configuration "Release"
        optimize "Full"

project "xlnt"
    kind "StaticLib"
    language "C++"
    warnings "Extra"
    targetdir "../lib/"
    includedirs { 
       "../include",
       "../third-party/miniz",
       "../third-party/pugixml/src"
    }
    files {
       "../source/**.cpp",
       "../source/**.hpp",
       "../include/xlnt/**.hpp",
       "../third-party/miniz/miniz.c",
       "../third-party/pugixml/src/pugixml.cpp"
    }
    flags { "Unicode" }
    configuration "Debug"
        flags { "FatalWarnings" }
    configuration "windows"
        defines { 
	   "WIN32",
	   "_CRT_SECURE_NO_WARNINGS"
	}
