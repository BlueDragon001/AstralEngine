#pragma once
#include "aepch.h"
#include "Astral/Core.h"
#include "Astral/Events/Event.h"

namespace AstralEngine {
	struct WindowsProps
	{
		std::string Title;
		unsigned int Width;
		unsigned int Height;

		WindowsProps(const std::string& title ="Astral Engine",
						unsigned int width = 1280,
						unsigned int height = 720):Title(title), Width(width), Height(height)
		{
			//Constructor
		}


	};

	class ASTRAL_API Window {

	public:
		using EventCallbackFn = std::function<void(Event&)>;
		virtual ~Window(){}
		virtual void OnUpdate() = 0;
		virtual unsigned int GetWidth() const = 0;
		virtual unsigned int GetHeight() const = 0;

		virtual void  SetEventCallback(const EventCallbackFn& callback) = 0;
		virtual void SetVsync(bool Enable) = 0;
		virtual void IstVsync(bool Enable) const = 0;
		
		//static Window* Create(const WidthProps props = WindowProps())

	};
}