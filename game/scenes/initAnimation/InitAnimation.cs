using capybara.entities;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace capybara.scene;

// classe responsável pela gestão da animação inicial.
internal class InitAnimation : Scene
{
	private ContentManager contentManager;
	private Cat cat;
	private float alpha = 1;

	public InitAnimation(ContentManager contentManager)
	{
		this.contentManager = contentManager;
	}

	public override void Load()
	{
		cat = new(contentManager, 10);
	}

	public override void Update(GameTime gameTime)
	{
		alpha -= 0.003f;
		cat.Update(gameTime);
	}

	public override void Draw(SpriteBatch spriteBatch)
	{
		cat.Draw(spriteBatch, Color.White * alpha);
	}
}
