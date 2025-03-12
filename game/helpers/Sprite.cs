using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace capybara;

public class Sprite
{
	public Texture2D tex;
	public Vector2 pos;

	public Sprite(Texture2D tex, Vector2 pos)
	{
		this.tex = tex;
		this.pos = pos;
	}
}
