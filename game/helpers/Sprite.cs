using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace capybara;

public class Sprite
{
  private Texture2D tex;
	private Vector2 pos;
	private byte scale; 

	public Sprite(Texture2D tex, Vector2 pos, byte scale)
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
