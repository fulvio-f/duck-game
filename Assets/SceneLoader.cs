using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(0);
	    SceneManager.LoadScene(1,LoadSceneMode.Additive);
    }
}
