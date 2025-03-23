using Microsoft.Xna.Framework.Input;

namespace messed.button
{
	internal class Button
	{
		private readonly Texture2D tex;
		private readonly SpriteFont font;
		private readonly Rectangle rect;
		private readonly Action onClick;
		private Vector2 pos;
		private Color shade = Color.White;
		private int scale = 1;
		private string text = "button";
		private MouseState lastMouseState;

		public Button(SpriteFont f, Vector2 p, int s = 1, Action clickAction = null, Texture2D t = null)
		{
			tex = t;
			pos = p;
			scale = s;
			font = f;
			onClick = clickAction;
			rect =
				tex != null
					? new Rectangle((int)p.X, (int)p.Y, t.Width * scale, t.Height * scale)
					: new Rectangle(
						(int)p.X,
						(int)p.Y,
						(int)(font.MeasureString(text).X * scale),
						(int)(font.MeasureString(text).Y * scale)
					);
		}

		public void Update()
		{
			MouseState ms = Mouse.GetState();
			Rectangle cursor = new(ms.Position.X, ms.Position.Y, 1, 1);

			if (cursor.Intersects(rect))
			{
				shade = Color.DarkGray;
				if (
					ms.LeftButton == ButtonState.Pressed
					&& lastMouseState.LeftButton == ButtonState.Released
				)
				{
					onClick?.Invoke();
				}
			}
			else
			{
				shade = Color.White;
			}

			lastMouseState = ms;
		}

		public void Draw(SpriteBatch spriteBatch, string t = "")
		{
			text = t;
			if (tex != null)
			{
				spriteBatch.Draw(tex, pos, null, shade, 0, new Vector2(), scale, SpriteEffects.None, 1);
			}
			else
			{
				spriteBatch.DrawString(
					font,
					text,
					pos,
					shade,
					0,
					new Vector2(),
					scale,
					SpriteEffects.None,
					1
				);
			}
		}
	}
}
