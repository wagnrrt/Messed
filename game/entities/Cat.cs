using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace messed.entities;

internal class Cat : Sprite
{
	public Cat(ContentManager contentManager, float scale)
		: base(
			contentManager.Load<Texture2D>("assets/cat/cat"),
			new Vector2(
				(GameSettings.GetScreenSize().X - 12 * scale) / 1.78f,
				(GameSettings.GetScreenSize().Y - 9 * scale) / 2.05f
			),
			new(11, 1, new Vector2(12, 9), 8),
			scale
		) { }

	public override void Update(GameTime gameTime)
	{
		AnimationManager.Update();
	}
}
