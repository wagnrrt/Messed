using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace capybara.entities;

internal class Cat : Sprite
{

	public Cat(ContentManager contentManager, float scale)
		: base(
			contentManager.Load<Texture2D>("assets/cats/cat"),
			new Vector2((GameSettings.GetScreenSize().X - 12 * scale) / 1.6f, (GameSettings.GetScreenSize().Y - 9 * scale) / 2),
			new(11, 1, new Vector2(12, 9), 8),
			scale
		) { }

	public override void Update(GameTime gameTime)
	{
		AnimationManager.Update();
	}
}
