using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
	public void LoadNextScene()
	{
		int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
		int nextSceneIndex = currentSceneIndex + 1;

		if (nextSceneIndex < SceneManager.sceneCountInBuildSettings)
		{
			SceneManager.LoadScene(nextSceneIndex);
		}
		else
		{
			Debug.LogWarning("Последний уровень достигнут! Вы прошли игру");
		}
	}

	public void ReloadCurrentScene()
	{
		int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
	public void LoadSceneByName(string sceneName)
	{
		if (Application.CanStreamedLevelBeLoaded(sceneName))
		{
			SceneManager.LoadScene(sceneName);
		}
		else
		{
			Debug.LogError($"сцена с именем '{sceneName}' не найдена");
		}
	}	
}

