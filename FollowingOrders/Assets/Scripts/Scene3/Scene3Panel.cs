using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene3Panel : MonoBehaviour
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
    public GameObject LockDownButton;
    public GameObject AlertButton;
    [SerializeField] Animator transitionAnim;
    //public AudioSource audioSource1;
    private bool allowSpace = true;

    // Set initial visibility. Added images or buttons need to also be SetActive(false);
    void Start()
    {
        AlertButton.SetActive(false);
        LockDownButton.SetActive(false);
        WBButton.SetActive(false);
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
            ChoiceMaintenance.SetActive(true);
            ChoiceCargo.SetActive(true);
            ChoiceRoute.SetActive(true);
            CharBox.SetActive(false);
            nextButton.SetActive(false);
            allowSpace = false;
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "You gaze at your mighty control panel:";
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
            WBButton.SetActive(true);
            CharBox.SetActive(false);
            nextButton.SetActive(false);
            allowSpace = false;
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "The map shows you selectable locations from your current position: \r\nA-Central Station.\r\n\r\n''Set location to:''\r\n";
        }

        else if (primeInt == 20)
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
        else if (primeInt == 21)
        {
            Return2ControlButton.SetActive(true);
            CharBox.SetActive(true);
            nextButton.SetActive(false);
            allowSpace = false;
            DialogueDisplay.SetActive(true);
            Char1name.text = "Commanding Officer";
            Char1speech.text = "\"Good job, that ought to keep them under control. Don't worry, should the beasts attempt to take our lives the guards will help keep you safe. Just be sure to keep checking the Cargo if you get a warning.";
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
            Char1speech.text = "A light moves left to right across the screen.";
        }
        else if (primeInt == 31)
        {
            Return2ControlButton.SetActive(false);
            CharBox.SetActive(false);
            nextButton.SetActive(true);
            allowSpace = true;
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "A moment later a text appears at the top: \"Possible sabotage detected\"";
        }
        else if (primeInt == 32)
        {
            AlertButton.SetActive(true);
            CharBox.SetActive(false);
            nextButton.SetActive(false);
            allowSpace = false;
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "A red blip is blinking under the locomotive of the train, there could be a bomb under you..";
        }
        else if (primeInt == 33)
        {
            AlertButton.SetActive(false);
            CharBox.SetActive(false);
            nextButton.SetActive(true);
            allowSpace = true;
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "The alarm blares loudly, the wagons are automatically locked.";
        }
        else if (primeInt == 34)
        {
            AlertButton.SetActive(false);
            CharBox.SetActive(false);
            nextButton.SetActive(true);
            allowSpace = true;
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "The guards rush out of the train.\r\nMoments later the radio tunes in.\r\n";
        }
        else if (primeInt == 35)
        {
            Return2ControlButton.SetActive(true);
            CharBox.SetActive(true);
            nextButton.SetActive(false);
            allowSpace = false;
            DialogueDisplay.SetActive(true);
            Char1name.text = "Commanding Officer";
            Char1speech.text = "//kwzzzt..// \"Friend, you acted like a true professional. We found a strange object connected to the undercarriage of the train and took care of it. You are quite possibly a hero! Well done.\"";
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
            Char1speech.text = "\"Ready to make the final trip? It's been an honour for me to have guided you, I am very proud of you, you make a great train driver.\"";
        }

        //Please do NOT delete this final bracket that ends the Next() function:
    }

    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
    public void Choice1aFunct()
    {
        //map
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
        //cargo
        LockDownButton.SetActive(true);
        Return2ControlButton.SetActive(true);
        ChoiceCargo.SetActive(false);
        ChoiceMaintenance.SetActive(false);
        ChoiceRoute.SetActive(false);
        primeInt = 19;
        CharBox.SetActive(false);
        nextButton.SetActive(false);
        allowSpace = false;
        DialogueDisplay.SetActive(true);
        Char1name.text = "";
        Char1speech.text = "The green coloured monitor displays the information on the cargo:\r\n\r\n''Capacity:'' 823/1.000.\r\n''Weight:'' 57.610kg/100.000kg.\r\n''Activity:'' High/stable.\r\n";
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
    public void ReturnFunct()
    {
        LockDownButton.SetActive(false);
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
        if (CheckedOutFunctions >= 2)
        {
            Next();
        }
    }
    public void LockDownFunct()
    {
        Next();
    }
    public void AlertFunct()
    {
        Next();
    }
    public void CentralStation()
    {
        WBButton.SetActive(false);
        Return2ControlButton.SetActive(true);
        CharBox.SetActive(true);
        nextButton.SetActive(false);
        allowSpace = false;
        DialogueDisplay.SetActive(true);
        Char1name.text = "Commanding Officer";
        Char1speech.text = "\"On to our final destination, the creatures will be safely locked up afterwards.\"";
        primeInt = 13;
    }
    public void SceneChange1()
    {
        StartCoroutine(LoadScene());
    }
    IEnumerator LoadScene()
    {
        transitionAnim.SetTrigger("End");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Scene4Journey");
        transitionAnim.SetTrigger("Start");
    }
}