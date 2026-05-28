using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene3Soldiers : MonoBehaviour
{
    // These are the script variables.
    // For more character images / buttons, copy & renumber the variables:
    public int primeInt = 1;        // This integer drives game progress!
    public TMP_Text Char1name;
    public TMP_Text Char1speech;
    public GameObject ScrollViewChar1;
    //public TMP_Text Char3name;
    //public TMP_Text Char3speech;
    public GameObject DialogueDisplay;
    //public GameObject ArtChar1a;
    //public GameObject ArtChar1b;
    //public GameObject ArtChar1c;
    //public GameObject ArtChar2;
    public GameObject ArtBG1;
    public GameObject Choice1a;
    public GameObject Choice1b;
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
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
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
            CharBox.SetActive(false);
            nextButton.SetActive(true);
            allowSpace = true;
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "The rustic exterior of the station was calming and approaching slowly as the train came to a full stop.";
        }
        else if (primeInt == 2)
        {
            Choice1a.SetActive(true);
            CharBox.SetActive(true);
            nextButton.SetActive(false);
            allowSpace = false;
            DialogueDisplay.SetActive(true);
            Char1name.text = "Commanding Officer";
            Char1speech.text = "//..kkzzwwwrr// \"HQ calling in! Enjoyed the short trip? We're almost there. We're sending some guards to help defend the train. Open up the passenger carriages.\" ";
            StartCoroutine(DoStuffWithDelay());
        }
        else if (primeInt == 3)
        {
            Choice1a.SetActive(true);
            CharBox.SetActive(true);
            nextButton.SetActive(false);
            allowSpace = false;
            DialogueDisplay.SetActive(true);
            Char1name.text = "Commanding Officer";
            Char1speech.text = "\"What are you waiting for? Open up the carriages!\"";
            StartCoroutine(DoStuffWithDelay());
        }
        else if (primeInt == 4)
        {
            Choice1a.SetActive(true);
            CharBox.SetActive(true);
            nextButton.SetActive(false);
            allowSpace = false;
            DialogueDisplay.SetActive(true);
            Char1name.text = "Commanding Officer";
            Char1speech.text = "\"Disobedience will not be tolerated. Open them up, this is your final warning before you will be disciplined.\"";
            StartCoroutine(DoStuffWithDelay());
        }
        else if (primeInt == 5)
        {
            Choice1a.SetActive(false);
            NextScene2Button.SetActive(true);
            CharBox.SetActive(false);
            nextButton.SetActive(false);
            allowSpace = false;
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
        }

        else if (primeInt == 20)
        {
            CharBox.SetActive(true);
            DialogueDisplay.SetActive(true);
            Char1name.text = "Commanding Officer";
            Char1speech.text = "The officer buzzes in: \"Alright we're ready, don't forget to take care of your tasks.\"";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
        }

        //Please do NOT delete this final bracket that ends the Next() function:
    }
    //Coroutine
    IEnumerator DoStuffWithDelay()
    {
        yield return new WaitForSeconds(60f);

        Next();
    }

    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
    public void Choice1aFunct()
    {
        primeInt = 19;
        Choice1a.SetActive(false);
        CharBox.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
        DialogueDisplay.SetActive(true);
        Char1name.text = "";
        Char1speech.text = "The doors open and the sound of boots stomping onto the train can vaguely be heard from the train platform.";
    }
    public void Choice1bFunct()
    {
    }

    public void SceneChange1()
    {
        SceneManager.LoadScene("SceneAltEnding");

    }
    public void SceneChange2()
    {
        SceneManager.LoadScene("Scene3-Panel");
    }
}