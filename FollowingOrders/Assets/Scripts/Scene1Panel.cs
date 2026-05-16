using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene1Panel : MonoBehaviour
{
    // These are the script variables.
    // For more character images / buttons, copy & renumber the variables:
    public int primeInt = 1;        // This integer drives game progress!
    public TMP_Text Char1name;
    public TMP_Text Char1speech;
    public GameObject DialogueDisplay;
    public GameObject ArtBG1;
    public GameObject ChoiceRoute;
    public GameObject ChoiceMaintenance;
    public GameObject ChoiceCargo;
    public GameObject NextScene1Button;
    public GameObject NextScene2Button;
    public GameObject nextButton;
    public GameObject CharBox;
    //public AudioSource audioSource1;
    private bool allowSpace = true;

    // Set initial visibility. Added images or buttons need to also be SetActive(false);
    void Start()
    {
        DialogueDisplay.SetActive(false);
        ArtBG1.SetActive(true);
        ChoiceMaintenance.SetActive(false);
        ChoiceCargo.SetActive(false);
        ChoiceRoute.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
        nextButton.SetActive(true);
    }

    // Use the spacebar as a faster "Next" button:
    void Update()
    {
        if (allowSpace == true)
        {
            if (Input.GetKeyDown("space"))
            {
                Next();
            }

            // secret debug code: go back 1 Story Unit, if NEXT is visible
            if (Input.GetKeyDown("p"))
            {
                primeInt -= 2;
                Next();
            }
        }
    }

    //Story Units! The main story function.
    //Players hit [NEXT] to progress to the next primeInt:
    public void Next()
    {
        primeInt += 1;
        if (primeInt == 1)
        {
            CharBox.SetActive(true);
            nextButton.SetActive(true);
            allowSpace = true;
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "//KwZzwt..// \"Welcome to your control deck, this will be your own seat of power!\"\"Here are the functions you are able to perform from here:\"\r\n";
        }
        else if (primeInt == 2)
        {
            ChoiceMaintenance.SetActive(true);
            ChoiceCargo.SetActive(true);
            ChoiceRoute.SetActive(true);
            CharBox.SetActive(true);
            nextButton.SetActive(false);
            allowSpace = false;
            DialogueDisplay.SetActive(true);
            Char1name.text = "Commanding Officer";
            Char1speech.text = "The left most CRT screen picturing the train\r\nThe right most CRT screen\r\nThe central terminal\r\n\r\n\"Please friend, select any one of these options and see what they do!\"";
        }
        else if (primeInt == 3)
        {

        }
        else if (primeInt == 4)
        {

        }

        else if (primeInt == 5)
        {

        }

        //Please do NOT delete this final bracket that ends the Next() function:
    }

    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
    public void Choice1aFunct()
    {
        primeInt = 9;
        CharBox.SetActive(true);
        nextButton.SetActive(true);
        allowSpace = true;
        DialogueDisplay.SetActive(true);
        Char1name.text = "Commanding Officer";
        Char1speech.text = "A map of the train network is presented on the screen.\r\n\"From here you can select the stations to which the train will drive. Of course only locations that we assign to you will be accepted.\"\r\n";
    }
    public void Choice1bFunct()
    {
        primeInt = 19;
        CharBox.SetActive(true);
        nextButton.SetActive(true);
        allowSpace = true;
        DialogueDisplay.SetActive(true);
        Char1name.text = "";
        Char1speech.text = "A digital side profile displays the carriages of the train;\r\nIncluding meters for weight, capacity, and activity.\r\n\r\nThere are a total of 25 carriages.\r\n";
    }
    public void Choice1cFunct()
    {
        primeInt = 29;
        CharBox.SetActive(true);
        nextButton.SetActive(true);
        allowSpace = true;
        DialogueDisplay.SetActive(true);
        Char1name.text = "";
        Char1speech.text = "A side profile of the entirety of the train is laid out before you on the display.\r\n";
    }
    public void SceneChange1()
    {

    }
    public void SceneChange2()
    {
        SceneManager.LoadScene("Scene2b");
    }
}