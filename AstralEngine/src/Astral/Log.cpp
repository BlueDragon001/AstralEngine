#include "Log.h"

namespace AstralEngine {
	std::shared_ptr<spdlog::logger> Log::s_CoreLogger;
	std::shared_ptr<spdlog::logger> Log::s_ClientLogger;

	void Log::Init() {
		spdlog::set_pattern("[%H:%M:%S %z] [%n] [%^---%L---%$] %v");
		s_CoreLogger = spdlog::stdout_color_mt("ASTRAL_CORE");
		s_CoreLogger->set_level(spdlog::level::trace);
		s_ClientLogger = spdlog::stderr_color_mt("APP");
		s_ClientLogger->set_level(spdlog::level::trace);
	}
}