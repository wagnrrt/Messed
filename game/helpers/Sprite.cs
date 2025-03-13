using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace capybara;

public class Sprite
{
  public Texture2D tex;
	public Vector2 pos;
	public int scale; 

	public Sprite(Texture2D tex, Vector2 pos, int scale)
	{
		this.tex = tex;
		this.pos = pos;
		this.scale = scale;
	}

	public Rectangle Rect
	{
		get
		{
			return new Rectangle((int)pos.X, (int)pos.Y, scale, scale);
		}
	}
}
