using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadSceneGeneric : MonoBehaviour {

    public string nextScene = "";
	// Use this for initialization
	
    public void loadScene()
    {
        SceneManager.LoadScene(this.nextScene);
    }
}
