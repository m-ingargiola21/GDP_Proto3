using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField]
    GameObject SplashScreenPanel;
    [SerializeField]
    GameObject InstructionsPanel;
    [SerializeField]
    GameObject CreditsPanel;
    [SerializeField]
    GameObject LevelSelectPanel;
    [SerializeField]
    GameObject MainMenuPanel;
    // Use this for initialization
    void Start ()
    {
        MainMenuPanel.SetActive(false);
        LevelSelectPanel.SetActive(false);
        CreditsPanel.SetActive(false);
        InstructionsPanel.SetActive(false);
    }
	
	public void MainMenu()
    {
        SplashScreenPanel.SetActive(false);
        LevelSelectPanel.SetActive(false);
        CreditsPanel.SetActive(false);
        InstructionsPanel.SetActive(false);
        MainMenuPanel.SetActive(true);
    }
    public void Instructions()
    {
        MainMenuPanel.SetActive(false);
        InstructionsPanel.SetActive(true);
    }
    public void LevelSelect()
    {  
        MainMenuPanel.SetActive(false);
        LevelSelectPanel.SetActive(true);
    }
    public void Credits()
    {        
        MainMenuPanel.SetActive(false);
        CreditsPanel.SetActive(true);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void LoadLevelOne()
    {
        SceneManager.LoadScene(1);
    }
    public void LoadLevelTwo()
    {
        SceneManager.LoadScene(2);
    }
}
