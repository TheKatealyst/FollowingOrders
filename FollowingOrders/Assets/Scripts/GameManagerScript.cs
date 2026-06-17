using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class GameManagerScript : MonoBehaviour
{
    public static int playerStat1;
    public static int CheckDiagnostics = 0;
    [SerializeField] Animator transitionAnim;

    // public TMP_Text textGameObject;

    // void Start () { UpdateScore (); }

    void Update()
    {

    }

    // void UpdateScore () {
    //        textGameObject.text = "Score: " + score; }

    public void StartGame()
    {
        StartCoroutine(LoadScene1());
    }

    IEnumerator LoadScene1()
    {
        transitionAnim.SetTrigger("End");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("OpeningScene");
        transitionAnim.SetTrigger("Start");
    }
    public void OpenCredits()
    {
        StartCoroutine(LoadScene2());
    }
    IEnumerator LoadScene2()
    {
        transitionAnim.SetTrigger("End");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("SceneCredits");
        transitionAnim.SetTrigger("Start");
    }

    public void MainMenu()
    {
        Time.timeScale = 1f;
        StartCoroutine(LoadScene3());
    }
    IEnumerator LoadScene3()
    {
        transitionAnim.SetTrigger("End");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("MainMenu");
        transitionAnim.SetTrigger("Start");
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
