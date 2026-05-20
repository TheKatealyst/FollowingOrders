using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene2_1loadingCargo : MonoBehaviour
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
            Char1speech.text = "The radio buzzes once more with static as your train comes to a halt.";
        }
        else if (primeInt == 2)
        {
            Choice1a.SetActive(true);
            CharBox.SetActive(true);
            nextButton.SetActive(false);
            allowSpace = false;
            DialogueDisplay.SetActive(true);
            Char1name.text = "Commanding Officer";
            Char1speech.text = "//kzztw..// \"Ah you have arrived, good job! Please open up the wagons and we can start loading the cargo. Over.\"";
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
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "The statistics on the screen fill up:\r\n\r\n''Capacity:'' 789/1.000.\r\n''Weight:''55.230kg/100.000kg.\r\n''Activity:'' High/stable.\r\n";
            nextButton.SetActive(true);
            allowSpace = true;
        }
        else if (primeInt == 21)
        {
            Choice1b.SetActive(true);
            NextScene1Button.SetActive(true);
            DialogueDisplay.SetActive(true);
            Char1name.text = "Commanding Officer";
            Char1speech.text = "//Kzzt..// \"Ah good to see you monitoring the cargo. Now you will be able to put the wagons on lockdown once activity goes from high/stable to high/violent, in fact: I highly encourage you to do so once it does. You can practise if you want to right now but it's not required.\"";
            nextButton.SetActive(false);
            allowSpace = false;
        }
        else if (primeInt == 22)
        {
            CharBox.SetActive(false);
            Choice1b.SetActive(false);
            NextScene1Button.SetActive(false);
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "The alarm blares. The wagons lock.\r\n\r\nYou hear vague screeching coming from the wagons.\r\nThe monitor reads out: \r\n''Activity:'' Low/stable.\r\n";
            nextButton.SetActive(true);
            allowSpace = true;
        }
        else if (primeInt == 23)
        {
            CharBox.SetActive(true);
            NextScene1Button.SetActive(true);
            DialogueDisplay.SetActive(true);
            Char1name.text = "Commanding Officer";
            Char1speech.text = "\"A good choice! That will have calmed the beasts down for the remainder of the day. Don't hesitate to do it again if the need arises!\"";
            nextButton.SetActive(false);
            allowSpace = false;
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
        Char1speech.text = "The green coloured monitor displays the doors opening.";
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