using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace capybara;

public class Main : Game
{
		private GraphicsDeviceManager _graphics;
		private SpriteBatch _spriteBatch;

		Sprite test;

		public Main()
		{
			_graphics = new GraphicsDeviceManager(this);
			Content.RootDirectory = "Content";
			IsMouseVisible = true;
		}

		protected override void Initialize()
		{
			base.Initialize();
		}

		protected override void LoadContent()
		{
			_spriteBatch = new SpriteBatch(GraphicsDevice);
			
			Texture2D tex = Content.Load<Texture2D>("assets/capybara/capybara");
			test = new Sprite(tex, Vector2.Zero, 64);
		}

		protected override void Update(GameTime gameTime)
		{
			if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
				Exit();

			base.Update(gameTime);
		}

		protected override void Draw(GameTime gameTime)
		{
			GraphicsDevice.Clear(Color.Black);
			_spriteBatch.Begin(samplerState: SamplerState.PointClamp);

			_spriteBatch.Draw(test.tex, test.Rect, Color.White);

			_spriteBatch.End();

			base.Draw(gameTime);
		}
}
