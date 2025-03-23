using messed.entities;
using Microsoft.Xna.Framework.Content;

namespace messed.scene;

// classe responsável pela gestão da animação inicial.
internal class InitAnimation : Scene
{
	private ContentManager contentManager;
	private SceneManager sceneManager;
	private Cat cat;
	private float alpha = 1;

	public InitAnimation(ContentManager contentManager, SceneManager sceneManager)
	{
		this.contentManager = contentManager;
		this.sceneManager = sceneManager;
	}

	public override void Load()
	{
		cat = new(contentManager, 8);
		FontManager.LoadFonts(contentManager);
	}

	public override void Update(GameTime gameTime)
	{
		animationUpdate();
		cat.Update(gameTime);
	}

	public override void Draw(SpriteBatch spriteBatch)
	{
		animationDraw(spriteBatch);
	}

	private void animationUpdate()
	{
		alpha -= 0.002f;
		if (alpha <= 0)
		{
			alpha = 0;
			sceneManager.RemoveScene();
			sceneManager.AddScene(new MainMenu(contentManager, sceneManager));
		}
	}

	private void animationDraw(SpriteBatch spriteBatch)
	{
		string textCredit = "Desenvolvido por:";
		Vector2 originCredit = FontManager.GetMonogramItalicFont().MeasureString(textCredit) / 2;
		Vector2 posCredit = new Vector2(
			GameSettings.GetScreenSize().X / 2,
			GameSettings.GetScreenSize().Y / 2
		);

		FontManager.DrawText(
			spriteBatch,
			FontManager.GetMonogramItalicFont(),
			textCredit,
			posCredit,
			2,
			Color.White * alpha,
			originCredit
		);

		string textName = "Wagnxy";
		Vector2 originName = FontManager.GetMonogramItalicFont().MeasureString(textName) / 2;
		Vector2 posName = new Vector2(
			GameSettings.GetScreenSize().X / 2,
			GameSettings.GetScreenSize().Y / 1.92f
		);

		FontManager.DrawText(
			spriteBatch,
			FontManager.GetMonogramItalicFont(),
			textName,
			posName,
			2,
			Color.White * alpha,
			originName
		);

		cat.Draw(spriteBatch, Color.White * alpha);
	}
}
