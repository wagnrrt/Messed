using Microsoft.Xna.Framework.Content;

namespace messed.scene;

internal class Play : Scene
{
	private ContentManager contentManager;

	public Play(ContentManager contentManager)
	{
		this.contentManager = contentManager;
	}

	public override void Load() { }

	public override void Update(GameTime gametime) { }

	public override void Draw(SpriteBatch spriteBatch) { }
}
