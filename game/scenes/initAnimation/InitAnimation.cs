using messed.entities;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace messed.scene;

// classe responsável pela gestão da animação inicial.
internal class InitAnimation : Scene
{
	private ContentManager contentManager;
	private SceneManager sceneManager;
	private Cat cat;
	private float alpha = 1;

	public InitAnimation(ContentManager contentManager, SceneManager sceneManager)
	{
		this.contentManager = contentManager;
		this.sceneManager = sceneManager;
	}

	public override void Load()
	{
		cat = new(contentManager, 8);
		FontManager.LoadFonts(contentManager);
	}

	public override void Update(GameTime gameTime)
	{
		animationUpdate();
		cat.Update(gameTime);
	}

	public override void Draw(SpriteBatch spriteBatch)
	{
		FontManager.DrawText(spriteBatch, FontManager.GetMonogramItalicFont(), "Desenvolvido por:", new Vector2(GameSettings.GetScreenSize().X / 2, GameSettings.GetScreenSize().Y / 2), 2);
		cat.Draw(spriteBatch, Color.White * alpha);
	}

	private void animationUpdate()
	{
		alpha -= 0.002f;
		if (alpha <= 0)
		{
			alpha = 0;
			sceneManager.RemoveScene();
			sceneManager.AddScene(new MainMenu(contentManager));
		}
	}
}
