using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public string SceneToLoad;


    public void LoadScene()
    {
        SceneManager.LoadScene(SceneToLoad);
    }
}
