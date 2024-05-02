#pragma once

#ifdef AE_PLATFORM_WINDOWS
	#ifdef AE_BUILD_DLL
		#define ASTRAL_API _declspec(dllexport)
	#else 
		#define ASTRAL_API _declspec(dllimport)
	#endif
#else
	#error Astral Engine only Supports Windows!
#endif // AE_PLATFORM_WINDOWS

