using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace messed.scene;

// classe que gerencia a exibição e interação com o menu inicial.
internal class MainMenu : Scene
{
	private ContentManager contentManager;

	public MainMenu(ContentManager contentManager)
	{
		this.contentManager = contentManager;
	}

	public override void Load() { }

	public override void Update(GameTime gametime) { }

	public override void Draw(SpriteBatch spriteBatch) { }
}
