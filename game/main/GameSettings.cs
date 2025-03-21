using System;
using Microsoft.Xna.Framework;

namespace messed;

public static class GameSettings
{
	public static int ScreenWidth { get; private set; }
	public static int ScreenHeight { get; private set; }
	private static readonly Vector2 BaseResolution = new Vector2(960, 540);

	public static void Initialize(GraphicsDeviceManager graphics)
	{
		ScreenWidth = 1920;
		ScreenHeight = 1080;

		graphics.PreferredBackBufferWidth = ScreenWidth;
		graphics.PreferredBackBufferHeight = ScreenHeight;

		graphics.IsFullScreen = true;
		graphics.ApplyChanges();
	}

	public static Vector2 GetScreenSize()
	{
		return new Vector2(ScreenWidth, ScreenHeight);
	}

	public static float GetScaleFactor()
{
    Vector2 screenSize = GameSettings.GetScreenSize();
    return Math.Min(screenSize.X / BaseResolution.X, screenSize.Y / BaseResolution.Y);
}
}
