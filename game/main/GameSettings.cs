using Microsoft.Xna.Framework;

namespace capybara;

public static class GameSettings
{
	public static int ScreenWidth { get; private set; }
	public static int ScreenHeight { get; private set; }

	public static void Initialize(GraphicsDeviceManager graphics)
	{
		ScreenWidth = 800;
		ScreenHeight = 480;

		graphics.PreferredBackBufferWidth = ScreenWidth;
		graphics.PreferredBackBufferHeight = ScreenHeight;

		graphics.ApplyChanges();
	}

	public static Vector2 GetScreenSize()
	{
		return new Vector2(ScreenWidth, ScreenHeight);
	}
}
