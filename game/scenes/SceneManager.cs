using System.Collections.Generic;

namespace messed;

internal class SceneManager
{
	private readonly Stack<Scene> sceneStack;

	public SceneManager()
	{
		sceneStack = new();
	}

	public void AddScene(Scene scene)
	{
		scene.Load();
		sceneStack.Push(scene);
	}

	public void RemoveScene()
	{
		sceneStack.Pop();
	}

	public Scene GetCurrentScene()
	{
		return sceneStack.Peek();
	}
}
