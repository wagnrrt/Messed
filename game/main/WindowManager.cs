using System;
using Microsoft.Xna.Framework;

namespace capybara;

internal class WindowManager
{
	private GraphicsDeviceManager Graphics;
	private Vector2 screenSize;

	public WindowManager(GraphicsDeviceManager graphics)
	{
		this.Graphics = graphics;
		this.screenSize = new Vector2(
			graphics.PreferredBackBufferWidth,
			graphics.PreferredBackBufferHeight
		);
	}

	public void toggleFullScreen()
	{
		Graphics.IsFullScreen = !Graphics.IsFullScreen;
		Graphics.ApplyChanges();

		OnResolutionChanged();
	}

	private void OnResolutionChanged()
	{
		Vector2 newScreenSize = new Vector2(
			Graphics.PreferredBackBufferWidth,
			Graphics.PreferredBackBufferHeight
		);
		if (newScreenSize != screenSize)
		{
			screenSize = newScreenSize; // Atualiza o tamanho da tela

			// Aqui você pode adicionar qualquer código que precise reagir à mudança de resolução
			Console.WriteLine($"Resolução alterada para: {screenSize.X}x{screenSize.Y}");
		}
	}
}
