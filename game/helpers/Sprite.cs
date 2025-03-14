using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace capybara;

public class Sprite
{
	public Texture2D Tex;
	public Rectangle Rect;

	public Sprite(Texture2D tex, Rectangle rect)
	{
		Tex = tex;
		Rect = rect;
	}

	public void Draw(SpriteBatch spriteBatch)
	{
		spriteBatch.Draw(Tex, Rect, Color.White);
	}
}
