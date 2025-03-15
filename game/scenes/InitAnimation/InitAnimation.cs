using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

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
		private Sprite cat;
		private AnimationManager catAnimation;

		public InitalCat(ContentManager contentManager) { this.contentManager = contentManager; }

		public void Load()
		{
			cat = new(contentManager.Load<Texture2D>("assets/cats/cat"), new Rectangle(0, 0, 128, 128));
			catAnimation = new(11, 1, new Vector2(16, 16), 8); 
		}
		
		public void Update(GameTime gameTime) { catAnimation.Update(); }

		public void Draw(SpriteBatch spriteBatch) { cat.Draw(spriteBatch, catAnimation); }
	}
}
