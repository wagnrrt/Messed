using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace capybara;

// classe que representa um sprite e gerencia suas propriedades visuais no jogo.
public class Sprite
{
	public Texture2D Tex;
	public Vector2 Pos;

	public Sprite(Texture2D tex, Vector2 pos)
	{
		Tex = tex;
		Pos = pos;
	}

	public Rectangle Rect(int size)
	{
		return new Rectangle((int)Pos.X, (int)Pos.Y, size, size);
	}
}
