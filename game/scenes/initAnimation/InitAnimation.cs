using capybara.entities;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace capybara.scene;

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
		cat = new(contentManager, 10);
	}

	public override void Update(GameTime gameTime)
	{
		animationUpdate();
		cat.Update(gameTime);
	}

	public override void Draw(SpriteBatch spriteBatch)
	{
		cat.Draw(spriteBatch, Color.White * alpha);
	}

	private void animationUpdate()
	{
		alpha -= 0.002f;
		if(alpha <= 0) { alpha = 0; sceneManager.RemoveScene(); sceneManager.AddScene(new MainMenu(contentManager)); }
	}
}
