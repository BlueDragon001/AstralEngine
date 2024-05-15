#pragma once

#include "Event.h"


namespace AstralEngine {
	class ASTRAL_API MouseMovedEvent : public Event {
	public:
		MouseMovedEvent(float x, float y) : m_MouseX(x), m_MouseY(y) {}
		inline float GetX() const { return m_MouseX; }
		inline float GetY() const { return m_MouseY; }

		std::string ToString() const override {
			std::stringstream ss;
			ss << "MouseMovedEvent: " << m_MouseX << " , " << m_MouseY;
			return ss.str();
		}

		EVENT_CLASS_TYPE(MouseMoved)
		EVENT_CLASS_CATEGORY(EventCategoryMouse | EventCategoryInput)

	private:
		float m_MouseX, m_MouseY;
	};

	class ASTRAL_API MouseScrollEvent : public Event {
	public: 
		MouseScrollEvent(float xOffset, float yOffset): m_xOffset(xOffset), m_yOffset(yOffset) {}
		inline float GetXOffset() const{ return m_xOffset; }
		inline float GetYOffset() const { return m_yOffset; }
		EVENT_CLASS_TYPE(MouseScrolled)
		EVENT_CLASS_CATEGORY(EventCategoryMouse | EventCategoryInput)

	private:
		float m_xOffset, m_yOffset;
	};


	class ASTRAL_API MouseButtonEvent : public Event {
	public:
		inline int MouseButton() const {return m_Button;}

		EVENT_CLASS_CATEGORY(EventCategoryMouse|EventCategoryInput)
	protected:
		MouseButtonEvent(int button) : m_Button(button){}
		int m_Button;
	};

	class ASTRAL_API MouseButtonPressedEvent : public MouseButtonEvent {
	public:
		MouseButtonPressedEvent(int button):MouseButtonEvent(button){}
		std::string ToString() const override{
			std::stringstream ss;
			ss << "MouseButtonPressedEvent: " << m_Button;
			return ss.str();
		}

		EVENT_CLASS_TYPE(MouseButtonPressed)

	};

	class ASTRAL_API MouseButtonReleasedEvent:public MouseButtonEvent {
	public:
		MouseButtonReleasedEvent(int button): MouseButtonEvent(button){}
		std::string ToString() const override {
			std::stringstream ss;
			ss << "MouseButtonReleaseEvent: " << m_Button;
		}

		EVENT_CLASS_TYPE(MouseButtonReleased)

	

	};


}
