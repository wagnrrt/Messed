using Microsoft.Xna.Framework.Content;

namespace messed.entities;

internal class Cat : Sprite
{
	public Cat(ContentManager contentManager, float scale)
		: base(
			contentManager.Load<Texture2D>("assets/cat/cat"),
			new Vector2(
				(GameSettings.GetScreenSize().X - 12 * scale) / 1.72f,
				(GameSettings.GetScreenSize().Y - 9 * scale) / 2
			),
			new(11, 1, new Vector2(12, 9), 8),
			scale
		) { }

	public override void Update(GameTime gameTime)
	{
		AnimationManager.Update();
	}
}
