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
    public int CheckedOutFunctions = 0; //This interger checks the players tutorial porgress.
    public TMP_Text Char1name;
    public TMP_Text Char1speech;
    public GameObject DialogueDisplay;
    public GameObject ArtBG1;
    public GameObject ChoiceRoute;
    public GameObject ChoiceMaintenance;
    public GameObject ChoiceCargo;
    public GameObject NextScene1Button;
    public GameObject nextButton;
    public GameObject CharBox;
    public GameObject Return2ControlButton;
    public GameObject MstationButton;
    public GameObject RhabourButton;
    public GameObject TAtempLocButton;
    //public AudioSource audioSource1;
    private bool allowSpace = true;

    // Set initial visibility. Added images or buttons need to also be SetActive(false);
    void Start()
    {
        MstationButton.SetActive(false);
        RhabourButton.SetActive(false);
        TAtempLocButton .SetActive(false);
        Return2ControlButton.SetActive(false);
        DialogueDisplay.SetActive(false);
        ArtBG1.SetActive(true);
        ChoiceMaintenance.SetActive(false);
        ChoiceCargo.SetActive(false);
        ChoiceRoute.SetActive(false);
        NextScene1Button.SetActive(false);
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
            Char1name.text = "Commanding Officer";
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
        else if (primeInt == 10)
        {
            ChoiceMaintenance.SetActive(false);
            ChoiceCargo.SetActive(false);
            ChoiceRoute.SetActive(false);
            CharBox.SetActive(true);
            nextButton.SetActive(true);
            allowSpace = true;
            DialogueDisplay.SetActive(true);
            Char1name.text = "Commanding Officer";
            Char1speech.text = "A map of the train network is presented on the screen.\r\n\"From here you can select the stations to which the train will drive. Of course only locations that we assign to you will be accepted.\"\r\n";
        }
        else if (primeInt == 11)
        {
            CharBox.SetActive(false);
            nextButton.SetActive(true);
            allowSpace = true;
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "The map shows you a variety of selectable locations from your current position: U-Maintenance yard.";
        }

        else if (primeInt == 12)
        {
            MstationButton.SetActive(true);
            RhabourButton.SetActive(true);
            TAtempLocButton.SetActive(true);
            CharBox.SetActive(true);
            nextButton.SetActive(false);
            allowSpace = false;
            DialogueDisplay.SetActive(true);
            Char1name.text = "Commanding Officer";
            Char1speech.text = "\"Let's Select the Central station as at that will be your upcoming destination.\"\r\nSet location to:\r\n";
        }
        else if (primeInt == 20)
        {
            ChoiceMaintenance.SetActive(false);
            ChoiceCargo.SetActive(false);
            ChoiceRoute.SetActive(false);
            CharBox.SetActive(true);
            nextButton.SetActive(true);
            allowSpace = true;
            DialogueDisplay.SetActive(true);
            Char1name.text = "Commanding Officer";
            Char1speech.text = "\"From here you can manage the cargo. Make sure none of it goes missing during your trip as you will be reprimanded for this; so be sure to always check the capacity before leaving or when making stops.\"";
        }
        else if (primeInt == 21)
        {
            CharBox.SetActive(true);
            nextButton.SetActive(true);
            allowSpace = true;
            DialogueDisplay.SetActive(true);
            Char1name.text = "Commanding Officer";
            Char1speech.text = "\"Some of the cargo can be dangerous as you have been tasked with transporting violent monsters safely to their destination. If something goes wrong you can toggle the lockdown switches to lock down any carriage.\"";
        }
        else if (primeInt == 22)
        {
            Return2ControlButton.SetActive(true);
            CharBox.SetActive(true);
            nextButton.SetActive(false);
            allowSpace = false;
            DialogueDisplay.SetActive(true);
            Char1name.text = "Commanding Officer";
            Char1speech.text = "\"Now this does take a fair bit of electricity so be sure to only toggle 'relevant' carriages for a 'short' duration, got it? And do not worry HQ will inform you if something goes wrong.\"";
        }
        else if (primeInt == 30)
        {
            ChoiceMaintenance.SetActive(false);
            ChoiceCargo.SetActive(false);
            ChoiceRoute.SetActive(false);
            CharBox.SetActive(true);
            nextButton.SetActive(true);
            allowSpace = true;
            DialogueDisplay.SetActive(true);
            Char1name.text = "Commanding Officer";
            Char1speech.text = "\"Please, let me instruct you as to how we perform a maintenance check here: Just press the scanner button and the train will run a simple diagnostics check\"";
        }
        else if (primeInt == 31)
        {
            CharBox.SetActive(false);
            nextButton.SetActive(true);
            allowSpace = true;
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "A light moves left to right across the screen.";
        }
        else if (primeInt == 32)
        {
            CharBox.SetActive(false);
            nextButton.SetActive(true);
            allowSpace = true;
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "A moment later a text appears at the top: \"No irregularities detected\"";
        }
        else if (primeInt == 33)
        {
            Return2ControlButton.SetActive(true);
            CharBox.SetActive(true);
            nextButton.SetActive(false);
            allowSpace = false;
            DialogueDisplay.SetActive(true);
            Char1name.text = "Commanding Officer";
            Char1speech.text = "\"Very good performance, for now you don't need to do anything\" //kZzzt..// the radio fades back out.";
        }
        else if (primeInt == 41)
        {
            ChoiceCargo.SetActive(false);
            ChoiceRoute.SetActive(false);
            ChoiceMaintenance.SetActive(false);
            NextScene1Button.SetActive(true);
            CharBox.SetActive(true);
            nextButton.SetActive(false);
            allowSpace = false;
            DialogueDisplay.SetActive(true);
            Char1name.text = "Commanding Officer";
            Char1speech.text = "\"Ah, Looks like you are ready to take off for central station, we'll contact you once you have arrived. Godspeed my friend!\"\r\n";
        }

        //Please do NOT delete this final bracket that ends the Next() function:
    }

    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
    public void Choice1aFunct()
    {
        CheckedOutFunctions += 1;
        ChoiceCargo.SetActive(false);
        ChoiceMaintenance.SetActive(false);
        ChoiceRoute.SetActive(false);
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
        CheckedOutFunctions += 1;
        ChoiceCargo.SetActive(false);
        ChoiceMaintenance.SetActive(false);
        ChoiceRoute.SetActive(false);
        primeInt = 19;
        CharBox.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
        DialogueDisplay.SetActive(true);
        Char1name.text = "";
        Char1speech.text = "A digital side profile displays the carriages of the train;\r\nIncluding meters for weight, capacity, and activity.\r\n\r\nThere are a total of 25 carriages.\r\n";
    }
    public void Choice1cFunct()
    {
        CheckedOutFunctions += 1;
        ChoiceCargo.SetActive(false);
        ChoiceMaintenance.SetActive(false);
        ChoiceRoute.SetActive(false);
        primeInt = 29;
        CharBox.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
        DialogueDisplay.SetActive(true);
        Char1name.text = "";
        Char1speech.text = "A side profile of the entirety of the train is laid out before you on the display.\r\n";
    }
    public void ChoiceHarbourFunct()
    {
        primeInt = 14;
        CharBox.SetActive(true);
        nextButton.SetActive(false);
        allowSpace = false;
        DialogueDisplay.SetActive(true);
        Char1name.text = "Commanding Officer";
        Char1speech.text = "\"That is not a designated route kameraad!\"";
    }
    public void ChoiceTempFunct()
    {
        primeInt = 15;
        CharBox.SetActive(true);
        nextButton.SetActive(false);
        allowSpace = false;
        DialogueDisplay.SetActive(true);
        Char1name.text = "Commanding Officer";
        Char1speech.text = "\"You do not yet have permission to travel to this location.\"";
    }
    public void ReturnFunct()
    {
        Return2ControlButton.SetActive(false);
        ChoiceCargo.SetActive(true);
        ChoiceMaintenance.SetActive(true);
        ChoiceRoute.SetActive(true);
        primeInt = 40;
        CharBox.SetActive(true);
        nextButton.SetActive(false);
        allowSpace = false;
        DialogueDisplay.SetActive(true);
        Char1name.text = "Commanding Officer";
        Char1speech.text = "//..KwzzTz// \"Alright, Be sure to examine your other equipment.\"";
        if (CheckedOutFunctions >= 3)
        {
            Next();
        }
    }
    public void CentralStation()
    {
        MstationButton.SetActive(false);
        RhabourButton.SetActive(false);
        TAtempLocButton.SetActive(false);
        Return2ControlButton.SetActive(true);
        CharBox.SetActive(true);
        nextButton.SetActive(false);
        allowSpace = false;
        DialogueDisplay.SetActive(true);
        Char1name.text = "Commanding Officer";
        Char1speech.text = "\"Well done. Go back to your overview.\" //kZzzt..//.";
        primeInt = 13;
    }
    public void SceneChange1()
    {
        SceneManager.LoadScene("Scene2-JourneyToM");
    }
}