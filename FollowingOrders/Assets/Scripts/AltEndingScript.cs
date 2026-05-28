using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class AltEndingScript : MonoBehaviour
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
    public GameObject DarkBG;
    public GameObject InsideBG;
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
        DarkBG.SetActive(false);
        InsideBG.SetActive(false);
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
            Char1speech.text = "Armed men dressed in black storm into your train and grab you before you're able to resist.";
        }
        else if (primeInt == 2)
        {
            CharBox.SetActive(false);
            nextButton.SetActive(true);
            allowSpace = true;
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "\r\nAs you are dragged across the station's floor you see hordes of desperate people being guided into the wagons.\r\n\r\nYour supervisor stands before you..\r\n";
        }
        else if (primeInt == 3)
        {
            CharBox.SetActive(true);
            nextButton.SetActive(true);
            allowSpace = true;
            DialogueDisplay.SetActive(true);
            Char1name.text = "Commanding Officer";
            Char1speech.text = "\"Such a shame, you had a promising career in front of you.\"";
        }
        else if (primeInt == 4)
        {
            CharBox.SetActive(true);
            nextButton.SetActive(true);
            allowSpace = true;
            DialogueDisplay.SetActive(true);
            Char1name.text = "Commanding Officer";
            Char1speech.text = "\r\n\"Throw them into the train with the others!\"\r\n";
        }
        else if (primeInt == 5)
        {
            Choice1a.SetActive(true);
            DarkBG.SetActive(true);
            ArtBG1.SetActive(false);
            CharBox.SetActive(false);
            nextButton.SetActive(false);
            allowSpace = false;
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "The wagon door shuts.";
        }
        else if (primeInt == 6)
        {
            Choice1a.SetActive(false);
            DarkBG.SetActive(false);
            InsideBG.SetActive(true);
            CharBox.SetActive(false);
            nextButton.SetActive(true);
            allowSpace = true;
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "The faces of the shadowy people become clear to you.\r\n\r\nThey are not monsters.\r\n\r\nThey never were.\r\n";
        }
        else if (primeInt == 7)
        {
            NextScene1Button.SetActive(true);
            CharBox.SetActive(false);
            nextButton.SetActive(true);
            allowSpace = true;
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "They are people. \r\nScared, malnourished, beaten.\r\n";
        }


        //Please do NOT delete this final bracket that ends the Next() function:
    }
    IEnumerator DoStuffWithDelay()
    {
        yield return new WaitForSeconds(60f);

        Next();
    }

    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
    public void Choice1aFunct()
    {
        Next();
    }
    public void SceneChange1()
    {
        SceneManager.LoadScene("SceneEnd");

    }
}