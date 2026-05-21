using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene3Journey : MonoBehaviour
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
            Char1speech.text = "The mighty engine roars to life once more as the train prepares to leave the station..";
        }
        else if (primeInt == 2)
        {
            nextButton.SetActive(true);
            allowSpace = true;
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "The locomotive pulls up a little slower than before, clearly weighted down by the cargo it now carries.";
        }
        else if (primeInt == 3)
        {
            CharBox.SetActive(true);
            nextButton.SetActive(true);
            allowSpace = true;
            DialogueDisplay.SetActive(true);
            Char1name.text = "Commanding officer";
            Char1speech.text = "The radio tunes in:\r\n\"//..kwzwwt// Off we go again! All goes well so far, great work.\"\r\n";
            if (GameManagerScript.CheckDiagnostics == 0)
            {
                CharBox.SetActive(true);
                nextButton.SetActive(true);
                allowSpace = true;
                DialogueDisplay.SetActive(true);
                Char1name.text = "Commanding officer";
                Char1speech.text = "\"I am disappointed you didn't run maintenance checks before departing, the train could have been sabotaged; leading to not only the escape of the prisoners but quite possibly your death as well! We'd rather not lose you so be careful next time!\" //..kzzzt//";
            }
        }
        else if (primeInt == 4)
        {
            CharBox.SetActive(false);
            nextButton.SetActive(true);
            allowSpace = true;
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "The radio falls silent..";
        }

        else if (primeInt == 5)
        {
            CharBox.SetActive(false);
            nextButton.SetActive(true);
            allowSpace = true;
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "The train chugs along the railroad. ";
        }
        else if (primeInt == 6)
        {
            CharBox.SetActive(false);
            nextButton.SetActive(true);
            allowSpace = true;
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "The sky is bright as the sun shines over the green pastures of the countryside.";
        }

        else if (primeInt == 7)
        {
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "It then rides through a pinewood forest. \r\nAs you exit your next destination comes into view: A-city.\r\n";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene2Button.SetActive(true);
        }

        //Please do NOT delete this final bracket that ends the Next() function:
    }

    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
    public void Choice1aFunct()
    {
    }
    public void Choice1bFunct()
    {
    }

    public void SceneChange1()
    {

    }
    public void SceneChange2()
    {
        SceneManager.LoadScene("Scene2b");
    }
}