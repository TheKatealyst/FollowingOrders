using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    public static int playerStat1;
    // public TMP_Text textGameObject;

    // void Start () { UpdateScore (); }

    void Update()
    {
        //NOTE: This quit functionality should not be needed:
        // if (Input.GetKey("escape")){
        //         Application.Quit();
        // }

        // Stat tester:
        //if (Input.GetKey("p")){
        //       Debug.Log("Player Stat = " + playerStat1);
        //}
    }

    // void UpdateScore () {
    //        textGameObject.text = "Score: " + score; }

    public void StartGame()
    {
        SceneManager.LoadScene("Scene1");
    }

    public void OpenCredits()
    {
        SceneManager.LoadScene("SceneCredits");
    }

    public void MainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
                Application.Quit();
#endif
    }
}
