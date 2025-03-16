using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace capybara;

// classe responsável pela gestão da animação inicial.
internal class InitAnimation : Scene
{
	private ContentManager contentManager;
	private Sprite sprite;

	public InitAnimation(ContentManager contentManager)
	{
		this.contentManager = contentManager;

	}

	public override void Load()
	{
		Texture2D catTex = contentManager.Load<Texture2D>("assets/cats/cat");
		sprite = new(catTex, new Vector2(), new(11, 1, new Vector2(12, 9), 8), 10);
	}

	public override void Update(GameTime gameTime)
	{
		sprite.AnimationManager.Update();
	}

	public override void Draw(SpriteBatch spriteBatch)
	{
		sprite.Draw(spriteBatch);
	}
}
