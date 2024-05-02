#pragma once

#ifdef AE_PLATFORM_WINDOWS

extern AstralEngine::Application* AstralEngine::CreateApplication();
int main(int argc, char** argv) {
	AstralEngine::Log::Init();
	AE_CORE_WARN("Core Logging Initalized");
	AE_INFO("Client Logging Initialize");
	auto app = AstralEngine::CreateApplication();
	app->Run();
	delete app;

}
#endif // AE_PLATFORM_WINDOWS

