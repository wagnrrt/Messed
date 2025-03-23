using Microsoft.Xna.Framework.Content;

namespace messed;

internal static class FontManager
{
	private static SpriteFont smoller;
	private static SpriteFont monogram;
	private static SpriteFont monogramItalic;

	public static void LoadFonts(ContentManager contentManager)
	{
		smoller = contentManager.Load<SpriteFont>("assets/fonts/smollerFont");
		monogram = contentManager.Load<SpriteFont>("assets/fonts/monogramFont");
		monogramItalic = contentManager.Load<SpriteFont>("assets/fonts/monogramItalicFont");
	}

	public static SpriteFont GetSmollerFont() => smoller;

	public static SpriteFont GetMonogramFont() => monogram;

	public static SpriteFont GetMonogramItalicFont() => monogramItalic;

	public static void DrawText(
		SpriteBatch spriteBatch,
		SpriteFont font,
		string text,
		Vector2 position,
		float scale = 1f,
		Color? color = null,
		Vector2 origin = new Vector2()
	)
	{
		spriteBatch.DrawString(
			font,
			text,
			position,
			color ?? Color.White,
			0f,
			origin,
			scale,
			SpriteEffects.None,
			0f
		);
	}
}
