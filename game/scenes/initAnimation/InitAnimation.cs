using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace capybara;

// classe responsável pela gestão da animação inicial.
public class InitAnimation : Scene
{
	private ContentManager contentManager;
	private InitalCat initalCat;

	public InitAnimation(ContentManager contentManager)
	{
		this.contentManager = contentManager;
		initalCat = new(contentManager);
	}

	public void Load()
	{
		initalCat.Load();
	}

	public void Update(GameTime gametime)
	{
		initalCat.Update(gametime);
	}

	public void Draw(SpriteBatch spriteBatch)
	{
		initalCat.Draw(spriteBatch);
	}

	// classe responsável por animar o gato inicial.
	private class InitalCat
	{
		private ContentManager contentManager;
		private Sprite spriteCat;
		private AnimationManager catAnimation;
		private Main main;

		public InitalCat(ContentManager contentManager)
		{
			this.contentManager = contentManager;
		}

		public void Load()
		{
			main = new();

			Texture2D catTex = contentManager.Load<Texture2D>("assets/cats/cat");

			spriteCat = new(catTex, new Vector2(main.GetScreenSize().X / 2, main.GetScreenSize().Y / 2));
			catAnimation = new(11, 1, new Vector2(12, 9), 8);
		}

		public void Update(GameTime gameTime)
		{
			catAnimation.Update();
		}

		public void Draw(SpriteBatch spriteBatch)
		{
			spriteBatch.Draw(spriteCat.Tex, spriteCat.Pos, catAnimation.GetFrame(), Color.White, 0f, new Vector2(), 4f, SpriteEffects.None, 0f);
		}
	}
}
