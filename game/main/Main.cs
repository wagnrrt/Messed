using messed.scene;

namespace messed;

// classe principal do jogo, responsável inicial a aplicação.
internal class Main : Game
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

		GameSettings.Initialize(graphics);
	}

	protected override void Initialize()
	{
		base.Initialize();
	}

	// função fundamental resposável por carrega todos os recursos usados no jogo.
	protected override void LoadContent()
	{
		sceneManager.AddScene(new InitAnimation(Content, sceneManager));
		spriteBatch = new SpriteBatch(GraphicsDevice);
	}

	// função fundamental resposável por atualizar o estado do jogo a cada frame.
	protected override void Update(GameTime gameTime)
	{
		sceneManager.GetCurrentScene().Update(gameTime);

		base.Update(gameTime);
	}

	// função fundamental para a exibição do jogo.
	protected override void Draw(GameTime gameTime)
	{
		GraphicsDevice.Clear(Color.Black);

		spriteBatch.Begin(SpriteSortMode.Deferred, null, SamplerState.PointClamp);
		sceneManager.GetCurrentScene().Draw(spriteBatch);
		spriteBatch.End();

		base.Draw(gameTime);
	}
}
