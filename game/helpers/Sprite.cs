using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace capybara;

// classe que representa um sprite e gerencia suas propriedades visuais no jogo.
internal class Sprite
{
	public Texture2D Tex;
	public Vector2 Pos;
	public AnimationManager AnimationManager;
	public float SCALE;

	public Sprite(
		Texture2D tex,
		Vector2 pos,
		AnimationManager animationManager = null,
		float scale = 1
	)
	{
		Tex = tex;
		Pos = pos;
		AnimationManager = animationManager;
		SCALE = scale;
	}

	public virtual void Update(GameTime gameTime) 
	{
		AnimationManager.Update();
	}

	public virtual void Draw(SpriteBatch spriteBatch)
	{
		spriteBatch.Draw(
			Tex,
			Pos,
			AnimationManager?.GetFrame(),
			Color.White,
			0f,
			new Vector2(),
			SCALE,
			SpriteEffects.None,
			0f
		);
	}
}
