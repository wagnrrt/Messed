using System.Collections.Generic;

namespace capybara;

public class SceneManager
{
	private readonly Stack<Scene> sceneStack;

	public SceneManager()
	{
		sceneStack = new();
	}

	public void AddScene(Scene scene)
	{
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
