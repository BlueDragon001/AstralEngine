using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstralEngine
{
	public abstract class Component
	{
		public Entity Entity { get; internal set; }
	}

	public class TransformComponent : Component
	{
		public Vector3 Translation
		{
			get
			{
				InternalCalls.TransformComponent_GetTranslation(Entity.ID, out Vector3 translation);
				return translation;
			}
			set
			{
				InternalCalls.TransformComponent_SetTranslation(Entity.ID, ref value);
			}
		}
	}

	public class Rigidbody2DComponent : Component
	{

		public void ApplyLinearImpulse(Vector2 impulse, Vector2 worldPosition, bool wake)
		{
			InternalCalls.Rigidbody2DComponent_ApplyLinearImpulse(Entity.ID, ref impulse, ref worldPosition, wake);
		}

		public void ApplyLinearImpulse(Vector2 impulse, bool wake)
		{
			InternalCalls.Rigidbody2DComponent_ApplyLinearImpulseToCenter(Entity.ID, ref impulse, wake);
		}

	}

	public class TextComponent : Component
	{

		public string Text
		{
			get => InternalCalls.TextComponent_GetText(Entity.ID);
			set => InternalCalls.TextComponent_SetText(Entity.ID, value);
		}

		public Vector4 Color
		{
			get
			{
				InternalCalls.TextComponent_GetColor(Entity.ID, out Vector4 color);
				return color;
			}

			set
			{
				InternalCalls.TextComponent_SetColor(Entity.ID, ref value);
			}
		}

		public float Kerning
		{
			get => InternalCalls.TextComponent_GetKerning(Entity.ID);
			set => InternalCalls.TextComponent_SetKerning(Entity.ID, value);
		}

		public float LineSpacing
		{
			get => InternalCalls.TextComponent_GetLineSpacing(Entity.ID);
			set => InternalCalls.TextComponent_SetLineSpacing(Entity.ID, value);
		}

	}

	/*	public class TagComponent : Component
		{
			public string Tag
			{
				get => InternalCalls.TagComponent_GetTag(Entity.ID);
				set => InternalCalls.TagComponent_SetTag(Entity.ID, value);
			}
		} */

	public class SpriteRendererComponent : Component
	{
		public Vector4 Color
		{
			get
			{
				InternalCalls.SpriteRendererComponent_GetColor(Entity.ID, out Vector4 color);
				return color;
			}

			set
			{
				InternalCalls.SpriteRendererComponent_SetColor(Entity.ID, ref value);
			}
		}

		public float TilingFactor
		{
			get => InternalCalls.SpriteRendererComponent_GetTilingFactor(Entity.ID);
			set => InternalCalls.SpriteRendererComponent_SetTilingFactor(Entity.ID, value);
		}
	}

	public class CircleRendererComponent : Component
	{
		public Vector4 Color
		{
			get
			{
				InternalCalls.CircleRendererComponent_GetColor(Entity.ID, out Vector4 color);
				return color;
			}

			set
			{
				InternalCalls.CircleRendererComponent_SetColor(Entity.ID, ref value);
			}
		}

		public float Thickness
		{
			get => InternalCalls.CircleRendererComponent_GetThickness(Entity.ID);
			set => InternalCalls.CircleRendererComponent_SetThickness(Entity.ID, value);
		}

		public float Fade
		{
			get => InternalCalls.CircleRendererComponent_GetFade(Entity.ID);
			set => InternalCalls.CircleRendererComponent_SetFade(Entity.ID, value);
		}
	}

	public class CameraComponent : Component
	{
		public bool Primary
		{
			get => InternalCalls.CameraComponent_GetPrimary(Entity.ID);
			set => InternalCalls.CameraComponent_SetPrimary(Entity.ID, value);
		}

		public bool AspectRatio
		{
			get => InternalCalls.CameraComponent_GetFixedAspectRatio(Entity.ID);
			set => InternalCalls.CameraComponent_SetFixedAspectRatio(Entity.ID, value);
		}
	}

	public class ScriptComponent : Component
	{
		public string ClassName
		{
			get => InternalCalls.ScriptComponent_GetClassName(Entity.ID);
			set => InternalCalls.ScriptComponent_SetClassName(Entity.ID, value);
		}
	}

	public class BoxCollider2DComponent : Component
	{
		public Vector2 Offset
		{
			get
			{
				InternalCalls.BoxCollider2DComponent_GetOffset(Entity.ID, out Vector2 offset);
				return offset;
			}

			set
			{
				InternalCalls.BoxCollider2DComponent_SetOffset(Entity.ID, ref value);

			}
		}

		public Vector2 Size
		{
			get
			{
				InternalCalls.BoxCollider2DComponent_GetSize(Entity.ID, out Vector2 Size);
				return Size;
			}

			set
			{
				InternalCalls.BoxCollider2DComponent_SetSize(Entity.ID, ref value);

			}
		}

		public float Density
		{
			get => InternalCalls.BoxCollider2DComponent_GetDensity(Entity.ID);
			set => InternalCalls.BoxCollider2DComponent_SetDensity(Entity.ID, value);
		}

		public float Friction
		{
			get => InternalCalls.BoxCollider2DComponent_GetFriction(Entity.ID);
			set => InternalCalls.BoxCollider2DComponent_SetFriction(Entity.ID, value);
		}

		public float Restitution
		{
			get => InternalCalls.BoxCollider2DComponent_GetRestitution(Entity.ID);
			set => InternalCalls.BoxCollider2DComponent_SetRestitution(Entity.ID, value);
		}

		public float RestitutionThreshold
		{
			get => InternalCalls.BoxCollider2DComponent_GetRestitutionThreshold(Entity.ID);
			set => InternalCalls.BoxCollider2DComponent_SetRestitutionThreshold(Entity.ID, value);
		}
	}

	public class CircleCollider2DComponent : Component
	{
		public Vector2 Offset
		{
			get
			{
				InternalCalls.CircleCollider2DComponent_GetOffset(Entity.ID, out Vector2 offset);
				return offset;
			}

			set
			{
				InternalCalls.CircleCollider2DComponent_SetOffset(Entity.ID, ref value);

			}
		}


		public float Radius
		{
			get => InternalCalls.CircleCollider2DComponent_GetRadius(Entity.ID);
			set => InternalCalls.CircleCollider2DComponent_SetRadius(Entity.ID, value);
		}
		public float Density
		{
			get => InternalCalls.CircleCollider2DComponent_GetDensity(Entity.ID);
			set => InternalCalls.CircleCollider2DComponent_SetDensity(Entity.ID, value);
		}

		public float Friction
		{
			get => InternalCalls.CircleCollider2DComponent_GetFriction(Entity.ID);
			set => InternalCalls.CircleCollider2DComponent_SetFriction(Entity.ID, value);
		}

		public float Restitution
		{
			get => InternalCalls.CircleCollider2DComponent_GetRestitution(Entity.ID);
			set => InternalCalls.CircleCollider2DComponent_SetRestitution(Entity.ID, value);
		}

		public float RestitutionThreshold
		{
			get => InternalCalls.CircleCollider2DComponent_GetRestitutionThreshold(Entity.ID);
			set => InternalCalls.CircleCollider2DComponent_SetRestitutionThreshold(Entity.ID, value);
		}
	}

	public class NativeScriptComponent : Component
	{

	}
}
