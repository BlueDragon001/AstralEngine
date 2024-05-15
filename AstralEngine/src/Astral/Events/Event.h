#pragma once
#include "Astral/Core.h"


namespace AstralEngine {
	enum class EventType {
		None=0,
		WindowClose, WindowResize, WindowFocus, WindowMoved, 
		AppTick, AppUpdate, AppRender, 
		KeyPressed, KeyReleased,
		MouseButtonPressed, MouseButtonReleased, MouseMoved, MouseScrolled
	};

	enum EventCategory
	{
		None = 0,
		EventCategoryApplication	= BIT(0),
		EventCategoryInput			= BIT(0),
		EventCategoryKeyboard		= BIT(0),
		EventCategoryMouse			= BIT(0),
		EventCategoryMouseButton	= BIT(0)
	};

#define EVENT_CLASS_TYPE(type) static EventType GetStaticType() {return EventType::##type;}\
						 virtual EventType GetEventType() const override {return GetStaticType();}\
						 virtual const char* GetName() const override{return #type;}


#define EVENT_CLASS_CATEGORY(category) virtual int GetCategoryFlags() const override {return category;}

	class ASTRAL_API Event {
		friend class EventDispatcher;
	public:
		virtual EventType GetEventType() const = 0;
		virtual const char* GetName() const = 0;
		virtual int GetCategoryFlags() const = 0;
		virtual std::string ToString() const { return GetName(); }
		inline bool IsInCategory(EventCategory category) {
			return GetCategoryFlags() & category;
		}
	protected:
		bool m_Handled = false;
	};

	class EventDispatcher {
		template<typename T> using EventFn = std::function<bool(T&)>;
	public:
		EventDispatcher(Event& event):m_Event(event) {
			
		}
		template<typename T> bool Dispatch(EventFn<T> func) {
			if (m_Event.GetEventType() == T::GetStaticType()) {
				m_Event.m_Handled = func(*(T*)&m_Event);
				return true;
			}
			return false;
		}
	private:
		Event& m_Event;
	};


}