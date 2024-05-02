#pragma once
#include <memory>
#include "Core.h"
#include "spdlog/spdlog.h"
#include "spdlog/sinks/stdout_color_sinks.h"


namespace AstralEngine {
	class ASTRAL_API Log
	{

	public:
		static void Init();
		inline static std::shared_ptr<spdlog::logger>& GetCoreLogger() { return s_CoreLogger; }
		inline static std::shared_ptr<spdlog::logger>& GetClientLogger() { return s_ClientLogger; }
	private:
		static std::shared_ptr<spdlog::logger> s_CoreLogger;
		static std::shared_ptr<spdlog::logger> s_ClientLogger;

	};
}

//Core Logs Macros
#define AE_CORE_TRACE(...)		::AstralEngine::Log::GetCoreLogger()->trace(__VA_ARGS__)
#define AE_CORE_INFO(...)		::AstralEngine::Log::GetCoreLogger()->info(__VA_ARGS__)
#define AE_CORE_WARN(...)		::AstralEngine::Log::GetCoreLogger()->warn(__VA_ARGS__)
#define AE_CORE_FATAL(...)		::AstralEngine::Log::GetCoreLogger()->fatal(__VA_ARGS__)

//Client Logs Macros
#define AE_TRACE(...)		::AstralEngine::Log::GetClientLogger()->trace(__VA_ARGS__)
#define AE_INFO(...)		::AstralEngine::Log::GetClientLogger()->info(__VA_ARGS__)
#define AE_WARN(...)		::AstralEngine::Log::GetClientLogger()->warn(__VA_ARGS__)
#define AE_FATAL(...)		::AstralEngine::Log::GetClientLogger()->fatal(__VA_ARGS__)
