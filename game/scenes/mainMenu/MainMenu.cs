using messed.button;
using Microsoft.Xna.Framework.Content;

namespace messed.scene;

// classe que gerencia a exibição e interação com o menu inicial.
internal class MainMenu : Scene
{
	private ContentManager contentManager;
	private Button button;
	private string play = "jogar";
	private SceneManager sceneManager;

	public MainMenu(ContentManager contentManager, SceneManager sceneManager)
	{
		this.contentManager = contentManager;
		this.sceneManager = sceneManager;
	}

	public override void Load()
	{
		FontManager.LoadFonts(contentManager);
		menuLoad();
	}

	public override void Update(GameTime gametime)
	{
		button.Update();
	}

	public override void Draw(SpriteBatch spriteBatch)
	{
		button.Draw(spriteBatch, play);
	}

	private void menuLoad()
	{
		Vector2 size = FontManager.GetMonogramFont().MeasureString(play);
		Vector2 pos = new(
			(GameSettings.GetScreenSize().X - size.X * 6) / 2,
			(GameSettings.GetScreenSize().Y - size.Y * 6) / 2
		);
		button = new(FontManager.GetMonogramFont(), pos, 6, () => nextScene());
	}

	private void nextScene()
	{
		sceneManager.RemoveScene();
		sceneManager.AddScene(new Play(contentManager));
	}
}
