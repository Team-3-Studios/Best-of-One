using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
// How to load scene https://docs.unity3d.com/6000.0/Documentation/ScriptReference/SceneManagement.SceneManager.LoadScene.html
    public void loadGame1() {
        SceneManager.LoadScene("Game 1");
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        Debug.Log("Loading Game 1");
    }
    public void loadGame2() {
        SceneManager.LoadScene("Game 2");
        Debug.Log("Loading Game 2");
    }
    public void loadGame3() {
        SceneManager.LoadScene("Game 3");
        Debug.Log("Loading Game 3");
    }
    public void loadGame4() {
        SceneManager.LoadScene("Game 4");
        Debug.Log("Loading Game 4");
    }
    public void returnMainMenu() {
        SceneManager.LoadScene("MainMenu");
        Debug.Log("MainMenu");
    }
}
