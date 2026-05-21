using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene1TrainDialogue : MonoBehaviour
{
    // These are the script variables.
    // For more character images / buttons, copy & renumber the variables:
    public int primeInt = 1;        // This integer drives game progress!
    public TMP_Text Char1name;
    public TMP_Text Char1speech;
    public TMP_Text Char2speech;
    public GameObject ScrollViewChar1;
    public GameObject ScrollViewChar2;
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
            nextButton.SetActive(false);
            allowSpace = false;
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2speech.text = "You find yourself in the driver's cab of a large train." +
                "The radio begins emitting static buzz.";
            Choice1a.SetActive(true); // function Choice1aFunct()
        }
        else if (primeInt == 2)
        {
            Choice1a.SetActive(false);
            CharBox.SetActive(true);
            nextButton.SetActive(true);
            allowSpace = true;
            DialogueDisplay.SetActive(true);
            Char2speech.text = "";
            Char1name.text = "Commanding Officer";
            Char1speech.text = "//Krztzzz..// \"Hi there friend! It's good to see you at your post. We have high hopes for you!\"";
        }
        else if (primeInt == 3)
        {
            nextButton.SetActive(false);
            allowSpace = false;
            DialogueDisplay.SetActive(true);
            Char2speech.text = "";
            Char1name.text = "Commanding Officer";
            Char1speech.text = "\"Now your job is quite simple: Set the train in motion, ensure you arrive at the designated locations, manage your cargo, and deliver it at the requested drop-off points.\"";
            Choice1b.SetActive(true);
        }
        else if (primeInt == 4)
        {
            ScrollViewChar2.SetActive(false);
            Choice1b.SetActive(false);
            nextButton.SetActive(true);
            allowSpace = true;
            DialogueDisplay.SetActive(true);
            Char2speech.text = "";
            Char1name.text = "Commanding Officer";
            Char1speech.text = "Your commanding officer continues:\r\n\r\n\"Now, your important duties will be as follows:\"\r\n''\r\n- Perform pre-departure train inspections before leaving each station.\r\n- Select the designated travel location.\r\n- Let our people load in the cargo.\r\n- Manage the cargo.\r\n- Inform Headquarters of any irregularities.\r\n''\r\n";
        }

        else if (primeInt == 5)
        {
            ScrollViewChar2.SetActive(true);
            DialogueDisplay.SetActive(true);
            Char2speech.text = "";
            Char1name.text = "Commanding Officer";
            Char1speech.text = "\"These tasks may appear in a different order and I understand it can be quite overwhelming so let's run through them together shall we friend?\" //..KKzzt//";
            // Turn off the "Next" button, turn on "Scene" button/s
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