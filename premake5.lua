workspace "AstralEngine"
	architecture "x64"

	configurations
	{
		"Debug",
		"Release",
		"Dist"
	}
outputdir = "%{cfg.buildcfg}-x64"

IncludeDir = {}
IncludeDir["GLFW"] = "AstralEngine/vendor/GLFW/include"
include  "AstralEngine/vendor/GLFW"

project "AstralEngine"
	location "AstralEngine"
	kind "SharedLib"
	language "C++"
	targetdir("bin/" .. outputdir .. "/AstralEngine")
	objdir("bin-int/" .. outputdir .. "/AstralEngine")

	pchheader "aepch.h"
	pchsource "Astral/src/aepch.cpp"

	files
	{
		"AstralEngine/src/**.h",
		"AstralEngine/src/**.cpp"
	}

	includedirs
	{
		"$(SolutionDir)AstralEngine/vendor/spdlog/include",
		"$(SolutionDir)AstralEngine/src",
		"%{IncludeDir.GLFW}"
	}

	links
	{
		"GLFW",
		"opengl32.lib"
	}

	filter "system:windows"
		cppdialect "C++20"
		staticruntime "On"
		systemversion "latest"

		defines
		{
			"AE_PLATFORM_WINDOWS",
			"AE_BUILD_DLL"
		}

		postbuildcommands
		{
			("{COPYFILE} %{cfg.buildtarget.relpath} ../x64bin/" ..outputdir.. "/Sandbox")
		}
	filter "configurations:Debug"
		defines "AE_DEBUG"
		symbols "On"
	filter "configurations:Release"
		defines "AE_RELEASE"
		optimize "On"
	filter "configurations:Dist"
		defines "AE_DIST"
		optimize "On"

project "Sandbox"
	location "Sandbox"
	kind "ConsoleApp"
	language "C++"
	targetdir("bin/" .. outputdir .. "/Sandbox")
	objdir("bin-int/" .. outputdir .. "/Sandbox")

	files
	{
		"Sandbox/src/**.h",
		"Sandbox/src/**.cpp"
	}

	includedirs
	{
		"$(SolutionDir)AstralEngine/vendor/spdlog/include",
		"(SolutionDir)AstralEngine/src"
	}


	filter "system:windows"
		cppdialect "C++20"
		staticruntime "On"
		systemversion "latest"

		defines
		{
			"AE_PLATFORM_WINDOWS"
		}

	filter "configurations:Debug"
		defines "AE_DEBUG"
		symbols "On"
	filter "configurations:Release"
		defines "AE_RELEASE"
		optimize "On"
	filter "configurations:Dist"
		defines "AE_DIST"
		optimize "On"