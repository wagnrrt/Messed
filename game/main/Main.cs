using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace capybara;

// classe principal do jogo, responsável inicial a aplicação.
public class Main : Game
{
	private GraphicsDeviceManager graphics;
	private SpriteBatch spriteBatch;

	private SceneManager sceneManager;

	public Main()
	{
		graphics = new GraphicsDeviceManager(this);
		Content.RootDirectory = "Content";
		IsMouseVisible = true;

		sceneManager = new();
	}

	protected override void Initialize()
	{
		base.Initialize();
	}

	// função fundamental resposável por carrega todos os recursos usados no jogo.
	protected override void LoadContent()
	{
		spriteBatch = new SpriteBatch(GraphicsDevice);

		sceneManager.AddScene(new InitAnimation(Content));
	}

	// função fundamental resposável por atualizar o estado do jogo a cada frame.
	protected override void Update(GameTime gameTime)
	{
		if (
			GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed
			|| Keyboard.GetState().IsKeyDown(Keys.Escape)
		)
			Exit();

		sceneManager.GetCurrentScene().Update(gameTime);

		base.Update(gameTime);
	}

	// função fundamental para a exibição do jogo.
	protected override void Draw(GameTime gameTime)
	{
		GraphicsDevice.Clear(Color.Black);

		spriteBatch.Begin(samplerState: SamplerState.PointClamp);

		sceneManager.GetCurrentScene().Draw(spriteBatch);

		spriteBatch.End();

		base.Draw(gameTime);
	}
}
