namespace messed;

public static class GameSettings
{
	public static int ScreenWidth { get; private set; }
	public static int ScreenHeight { get; private set; }

	public static void Initialize(GraphicsDeviceManager graphics)
	{
		ScreenWidth = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width;
		ScreenHeight = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height;

		graphics.PreferredBackBufferWidth = ScreenWidth;
		graphics.PreferredBackBufferHeight = ScreenHeight;

		graphics.IsFullScreen = true;
		graphics.ApplyChanges();
	}

	public static Vector2 GetScreenSize()
	{
		return new Vector2(ScreenWidth, ScreenHeight);
	}
}
