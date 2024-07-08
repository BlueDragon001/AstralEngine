using System;
using System.Runtime.CompilerServices;

namespace AstralEngine
{
	public static class InternalCalls
	{
		/*[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static bool Entity_HasComponent(ulong entityID, Type componentType);

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static void TransformComponent_GetTranslation(ulong entityID, out Vector4 translation);

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static void TransformComponent_SetTranslation(ulong entityID, ref Vector3 translation);

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static void Rigidbody2DComponent_ApplyLinearImpulse(ulong entityID, ref Vector2 impulse, ref Vector2 point, bool wake);

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static void Rigidbody2DComponent_ApplyLinearImpulseToCenter(ulong entityID, ref Vector2 impulse, bool wake);
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static bool Input_IsKeyDown(KeyCode keycode); */
		#region Entity
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static bool Entity_HasComponent(ulong entityID, Type componentType);
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static ulong Entity_FindEntityByName(string name);
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static object GetScriptInstance(ulong entityID);
		#endregion

		#region TagComponent
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static string TagComponent_GetTag(ulong entityID);
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static void TagComponent_SetTag(ulong entityID, string tag);
		#endregion

		#region TransformComponent
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static void TransformComponent_GetTranslation(ulong entityID, out Vector3 translation);
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static void TransformComponent_SetTranslation(ulong entityID, ref Vector3 translation);
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static void TransformComponent_GetRotation(ulong entityID, out Vector3 rotation);
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static void TransformComponent_SetRotation(ulong entityID, ref Vector3 rotation);
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static void TransformComponent_GetScale(ulong entityID, out Vector3 scale);
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static void TransformComponent_SetScale(ulong entityID, ref Vector3 scale);


		#endregion

		#region SpriteRendererComponent
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static void SpriteRendererComponent_GetColor(ulong entityID, out Vector4 color);
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static void SpriteRendererComponent_SetColor(ulong entityID, ref Vector4 color);
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static float SpriteRendererComponent_GetTilingFactor(ulong entityID);
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static void SpriteRendererComponent_SetTilingFactor(ulong entityID, float tilingFactor);
		#endregion

		#region CircleRendererComponent
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static void CircleRendererComponent_GetColor(ulong entityID, out Vector4 color);
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static void CircleRendererComponent_SetColor(ulong entityID, ref Vector4 color);
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static float CircleRendererComponent_GetThickness(ulong entityID);
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static void CircleRendererComponent_SetThickness(ulong entityID, float thickness);
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static float CircleRendererComponent_GetFade(ulong entityID);
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static void CircleRendererComponent_SetFade(ulong entityID, float fade);
		#endregion

		#region CameraComponent
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static bool CameraComponent_GetPrimary(ulong entityID);
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static void CameraComponent_SetPrimary(ulong entityID, bool primary);
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static bool CameraComponent_GetFixedAspectRatio(ulong entityID);
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static void CameraComponent_SetFixedAspectRatio(ulong entityID, bool fixedAspectRatio);
		#endregion

		#region ScriptComponent
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static string ScriptComponent_GetClassName(ulong entityID);
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static void ScriptComponent_SetClassName(ulong entityID, string className);
		#endregion

		#region Rigidbody2DComponent
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static void Rigidbody2DComponent_ApplyLinearImpulse(ulong entityID, ref Vector2 impulse, ref Vector2 point, bool wake);
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static void Rigidbody2DComponent_GetLinearVelocity(ulong entityID, out Vector2 linearVelocity);
		/*[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static Rigidbody2DComponent.BodyType Rigidbody2DComponent_GetType(ulong entityID);
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static void Rigidbody2DComponent_SetType(ulong entityID, Rigidbody2DComponent.BodyType type);
		[MethodImplAttribute(MethodImplOptions.InternalCall)] */
		internal extern static void Rigidbody2DComponent_ApplyLinearImpulseToCenter(ulong entityID, ref Vector2 impulse, bool wake);
		#endregion

		#region TextComponent
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static string TextComponent_GetText(ulong entityID);
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static void TextComponent_SetText(ulong entityID, string text);
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static void TextComponent_GetColor(ulong entityID, out Vector4 color);
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static void TextComponent_SetColor(ulong entityID, ref Vector4 color);
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static float TextComponent_GetKerning(ulong entityID);
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static void TextComponent_SetKerning(ulong entityID, float kerning);
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static float TextComponent_GetLineSpacing(ulong entityID);
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static void TextComponent_SetLineSpacing(ulong entityID, float lineSpacing);
		#endregion

		#region Rigidbody2DComponent
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static bool Input_IsKeyDown(KeyCode keycode);
		#endregion

		#region BoxCollider2DComponent
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static void BoxCollider2DComponent_GetOffset(ulong entityID, out Vector2 offset);
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static void BoxCollider2DComponent_SetOffset(ulong entityID, ref Vector2 offset);
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static void BoxCollider2DComponent_GetSize(ulong entityID, out Vector2 offset);
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static void BoxCollider2DComponent_SetSize(ulong entityID, ref Vector2 offset);
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static float BoxCollider2DComponent_GetDensity(ulong entityID);
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static void BoxCollider2DComponent_SetDensity(ulong entityID, float density);
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static float BoxCollider2DComponent_GetFriction(ulong entityID);
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static void BoxCollider2DComponent_SetFriction(ulong entityID, float friction);
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static float BoxCollider2DComponent_GetRestitution(ulong entityID);
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static void BoxCollider2DComponent_SetRestitution(ulong entityID, float restitution);
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static float BoxCollider2DComponent_GetRestitutionThreshold(ulong entityID);
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static void BoxCollider2DComponent_SetRestitutionThreshold(ulong entityID, float restitutionThreshold);

		#endregion

		#region CircleCollider2DComponent
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static void CircleCollider2DComponent_GetOffset(ulong entityID, out Vector2 offset);
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static void CircleCollider2DComponent_SetOffset(ulong entityID, ref Vector2 offset);
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static float CircleCollider2DComponent_GetRadius(ulong entityID);
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static void CircleCollider2DComponent_SetRadius(ulong entityID, float radius);
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static float CircleCollider2DComponent_GetDensity(ulong entityID);
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static void CircleCollider2DComponent_SetDensity(ulong entityID, float density);
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static float CircleCollider2DComponent_GetFriction(ulong entityID);
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static void CircleCollider2DComponent_SetFriction(ulong entityID, float friction);
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static float CircleCollider2DComponent_GetRestitution(ulong entityID);
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static void CircleCollider2DComponent_SetRestitution(ulong entityID, float restitution);
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static float CircleCollider2DComponent_GetRestitutionThreshold(ulong entityID);
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static void CircleCollider2DComponent_SetRestitutionThreshold(ulong entityID, float restitutionThreshold);
		#endregion
	}
}
