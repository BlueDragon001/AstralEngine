workspace "AstralEngine"
	architecture "x64"

	configurations
	{
		"Debug",
		"Release",
		"Dist"
	}
outputdir = "%{cfg.buildcfg}-%{cfg.system}-%{cfg.architecture}"

project "AstralEngine"
	location "AstralEngine"
	kind "SharedLib"
	language "C++"
	targetdir("bin/" .. outputdir .. "/%{prj.name}")
	objdir("bin-int/" .. outputdir .. "/%{prj.name}")

	files
	{
		"%{prj.name}/src/**.h",
		"%{prj.name}/src/**.cpp"
	}

	includedirs
	{
		"%{prj.name}/vendor/spdlog/include/spdlog"
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
			("{COPYFILE} %{cfg.buildtarget.relpath} ../bin/" ..outputdir.. "/Sandbox")
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
	targetdir("bin/" .. outputdir .. "/%{prj.name}")
	objdir("bin-int/" .. outputdir .. "/%{prj.name}")

	files
	{
		"%{prj.name}/src/**.h",
		"%{prj.name}/src/**.cpp"
	}

	includedirs
	{
		"%{prj.name}/vendor/spdlog/include/spdlog",
		"AstralEngine/src"
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