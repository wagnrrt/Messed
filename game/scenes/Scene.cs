using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace capybara;

internal class Scene
{
	public virtual void Load() { }
	public virtual void Update(GameTime gametime) { }
	public virtual void Draw(SpriteBatch spriteBatch) { }
}
