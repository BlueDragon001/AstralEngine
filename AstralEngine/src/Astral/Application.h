#pragma once
#include "Core.h"
namespace AstralEngine {
	class ASTRAL_API Application {
	public:
		Application();
		virtual	~Application();
		void Run();
	};

	Application* CreateApplication();

}

