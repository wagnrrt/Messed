using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace capybara;

// classe que representa um sprite e gerencia suas propriedades visuais e animações no jogo.
public class Sprite
{
	public Texture2D Tex;
	public Rectangle Rect;

	public Sprite(Texture2D tex, Rectangle rect)
	{
		Tex = tex;
		Rect = rect;
	}

	public void Draw(SpriteBatch spriteBatch, AnimationManager animationManager = null, Color? color = null)
	{
		if(animationManager != null) 
			spriteBatch.Draw(Tex, Rect, animationManager.GetFrame(), color ?? Color.White);
		else
			spriteBatch.Draw(Tex, Rect, color ?? Color.White);
	}
}
