using Microsoft.Xna.Framework;

namespace messed;

// classe que gerencia as animações de um sprite no jogo.
internal class AnimationManager
{
	int numFrames;
	int numColumns;
	Vector2 size;

	int counter;
	int activeFrame;
	int interval;

	int rowPos;
	int colPos;

	public AnimationManager(int numFrames, int numColumns, Vector2 size, int interval)
	{
		this.numFrames = numFrames;
		this.numColumns = numColumns;
		this.size = size;

		this.interval = interval;
		counter = 0;
		activeFrame = 0;

		rowPos = 0;
		colPos = 0;
	}

	// atualiza a animação de acordo com o intervalo.
	public void Update()
	{
		counter++;
		if (counter > interval)
		{
			counter = 0;
			NextFrame();
		}
	}

	// avança para o proximo quadro do sprite.
	public void NextFrame()
	{
		activeFrame++;
		colPos++;

		if (activeFrame >= numFrames)
		{
			ResetAnimation();
		}

		if (numColumns > 1 && colPos >= numColumns)
		{
			colPos = 0;
		}
	}

	// função resposável por resetar a animação.
	public void ResetAnimation()
	{
		activeFrame = 0;
		colPos = 0;
		rowPos = 0;
	}

	// obtém o retângulo que define a posição e o tamanho do quadro atual na sprite sheet.
	public Rectangle GetFrame()
	{
		return new Rectangle(colPos * (int)size.X, rowPos * (int)size.Y, (int)size.X, (int)size.Y);
	}
}
