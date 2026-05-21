using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene2Panel : MonoBehaviour
{
    // These are the script variables.
    // For more character images / buttons, copy & renumber the variables:
    public int primeInt = 0;        // This integer drives game progress!
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
    public GameObject WBButton;
    public GameObject AStationButton;
    public GameObject LockDownButton;
    //public AudioSource audioSource1;
    private bool allowSpace = true;

    // Set initial visibility. Added images or buttons need to also be SetActive(false);
    void Start()
    {
        LockDownButton.SetActive(false);
        WBButton.SetActive(false);
        AStationButton.SetActive(false);
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
            Char1speech.text = "\"Now that the cargo is loaded, finish up your tasks and depart for A-station, the next stop on your route. Good luck and stay safe!\"\r\n";
        }
        else if (primeInt == 2)
        {
            ChoiceMaintenance.SetActive(true);
            ChoiceCargo.SetActive(true);
            ChoiceRoute.SetActive(true);
            CharBox.SetActive(false);
            nextButton.SetActive(false);
            allowSpace = false;
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "Available equipment:";
        }
        else if (primeInt == 10)
        {
            ChoiceMaintenance.SetActive(false);
            ChoiceCargo.SetActive(false);
            ChoiceRoute.SetActive(false);
            CharBox.SetActive(false);
            nextButton.SetActive(true);
            allowSpace = true;
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "A map of the train network is presented on the screen.";
        }
        else if (primeInt == 11)
        {
            CharBox.SetActive(false);
            nextButton.SetActive(true);
            allowSpace = true;
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "The map shows you a variety of selectable locations from your current position: M-Station.\r\n";
        }

        else if (primeInt == 12)
        {
            WBButton.SetActive(true);
            AStationButton.SetActive(true);
            CharBox.SetActive(true);
            nextButton.SetActive(false);
            allowSpace = false;
            DialogueDisplay.SetActive(true);
            Char1name.text = "Commanding Officer";
            Char1speech.text = "\"Let's Select A-Central station as at that will be your upcoming destination.\"\r\nSet location to:\r\n";
        }
        else if (primeInt == 20)
        {
            LockDownButton.SetActive(true);
            Return2ControlButton.SetActive(true);
            ChoiceMaintenance.SetActive(false);
            ChoiceCargo.SetActive(false);
            ChoiceRoute.SetActive(false);
            CharBox.SetActive(false);
            nextButton.SetActive(false);
            allowSpace = false;
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "The green coloured monitor displays the information on the cargo:\r\n\r\n''Capacity:'' 823/1.000.\r\n''Weight:'' 57.610kg/100.000kg.\r\n''Activity:'' Low/stable.\r\n";
        }
        else if (primeInt == 21)
        {
            Return2ControlButton.SetActive(false);
            LockDownButton.SetActive(false);
            CharBox.SetActive(false);
            nextButton.SetActive(true);
            allowSpace = true;
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "The lights flash red. High painful screeching emerges from the holds.";
        }
        else if (primeInt == 22)
        {
            Return2ControlButton.SetActive(true);
            CharBox.SetActive(true);
            nextButton.SetActive(false);
            allowSpace = false;
            DialogueDisplay.SetActive(true);
            Char1name.text = "Commanding Officer";
            Char1speech.text = "\"Ah, eager to keep the beasts under control eh? I applaud you, though don't waste too much electricity. Best to lock down the carriages when the scoundrels turn violent! Over.\"]\r\n";
        }
        else if (primeInt == 30)
        {
            ChoiceMaintenance.SetActive(false);
            ChoiceCargo.SetActive(false);
            ChoiceRoute.SetActive(false);
            CharBox.SetActive(false);
            nextButton.SetActive(true);
            allowSpace = true;
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "A light moves left to right across the screen.\r\n\r\nA moment later a text appears at the top: \"No irregularities detected\"\r\n";
        }
        else if (primeInt == 31)
        {
            Return2ControlButton.SetActive(true);
            CharBox.SetActive(false);
            nextButton.SetActive(false);
            allowSpace = false;
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "All seems to be in order.";
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
            Char1speech.text = "Well done driver! Off we go again!";
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
        Char1speech.text = "You look at the cargo management panel once more.";
    }
    public void Choice1cFunct()
    {
        GameManagerScript.CheckDiagnostics += 1;
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
    public void ChoiceWBFunct()
    {
        primeInt = 14;
        CharBox.SetActive(true);
        nextButton.SetActive(false);
        allowSpace = false;
        DialogueDisplay.SetActive(true);
        Char1name.text = "Commanding Officer";
        Char1speech.text = "\"Good to see that you are eager! But that will be the next stop after A-Central station.\"";
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
    public void LockDownFunct()
    {
        Next();
    }
    public void CentralStation()
    {
        WBButton.SetActive(false);
        AStationButton.SetActive(false);
        Return2ControlButton.SetActive(true);
        CharBox.SetActive(true);
        nextButton.SetActive(false);
        allowSpace = false;
        DialogueDisplay.SetActive(true);
        Char1name.text = "Commanding Officer";
        Char1speech.text = "\"Well done. Get ready to depart!.\" //kZzzt..//.";
        primeInt = 13;
    }
    public void SceneChange1()
    {
        SceneManager.LoadScene("Scene2b");
    }
}