using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace capybara;

public class MainMenu : Scene
{
	private ContentManager contentManager;
	private Sprite sprite;
	private AnimationManager am;

	public MainMenu(ContentManager contentManager)
	{
		this.contentManager = contentManager;
	}

	public void Load()
	{
		Texture2D cat = contentManager.Load<Texture2D>("assets/cats/cat");
		sprite = new(cat, new Rectangle(100,100, 64, 64));
		am = new(1, 1, new Vector2(16, 16));
	}
	public void Update(GameTime gametime)
	{
		am.Update();
	}
	public void Draw(SpriteBatch spriteBatch)
	{
			spriteBatch.Draw(sprite.Tex, new Rectangle(100, 100, 64, 64), am.GetFrame(), Color.White);
	}
}
