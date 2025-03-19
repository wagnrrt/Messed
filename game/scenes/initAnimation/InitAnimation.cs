using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using capybara.entities;

namespace capybara.scene;

// classe responsável pela gestão da animação inicial.
internal class InitAnimation : Scene
{
	private ContentManager contentManager;
	private Cat cat;

	public InitAnimation(ContentManager contentManager)
	{
		this.contentManager = contentManager;
	}

	public override void Load()
	{
		cat = new(contentManager);
	}

	public override void Update(GameTime gameTime)
	{
		cat.Update(gameTime);
	}

	public override void Draw(SpriteBatch spriteBatch)
	{
		cat.Draw(spriteBatch);
	}
}
