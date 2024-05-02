#include "AstralEngine.h"


class Sandbox : public AstralEngine::Application {
public:
	Sandbox() {

	}
	~Sandbox() {

	}
};


AstralEngine::Application* AstralEngine::CreateApplication() {
	return new Sandbox();
}