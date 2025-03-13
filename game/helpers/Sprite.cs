using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace capybara;

public class Sprite
{
	public Texture2D Tex;
	public Vector2 Pos;
	public int Scale;

	public Sprite(Texture2D tex, Vector2 pos, int scale)
	{
		Tex = tex;
		Pos = pos;
		Scale = scale;
	}

	public Rectangle Rect => new Rectangle((int)Pos.X, (int)Pos.Y, Scale, Scale);
}
