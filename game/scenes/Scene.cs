using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace capybara;

public interface Scene
{
	public void Load();
	public void Update(GameTime gametime);
	public void Draw(SpriteBatch spriteBatch);
}
