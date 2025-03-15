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
		sprite = new(contentManager.Load<Texture2D>("assets/cats/cat"), new Rectangle(0, 0, 128, 128));
		am = new(11, 1, new Vector2(16, 16), 8);
	}
	public void Update(GameTime gametime)
	{
		am.Update();
	}
	public void Draw(SpriteBatch spriteBatch)
	{
		sprite.Draw(spriteBatch, am);
	}
}
