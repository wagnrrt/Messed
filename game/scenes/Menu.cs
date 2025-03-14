using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace capybara;

public class Menu : Scene
{
	private ContentManager contentManager;

	public Menu(ContentManager contentManager)
	{
		this.contentManager = contentManager;
	}

	public void Load(){}
	public void Update(GameTime gametime){}
	public void Draw(SpriteBatch spritebatch){}
}
