using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene4Journey : MonoBehaviour
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
    public GameObject ArtBGDriving;
    public GameObject ArtBGInsideWagon;
    public GameObject ArtBGPanel;
    public GameObject ArtBGGun;
    public GameObject Choice1a;
    public GameObject ChoiceCamera;
    public GameObject ChoiceLockDown;
    public GameObject ChoiceSetFreeAttempt;
    public GameObject ChoiceOpen;
    public GameObject ChoiceCallPickUp;
    public GameObject NextSceneMercyButton;
    public GameObject NextSceneObedienceButton;
    public GameObject nextButton;
    public GameObject CharBox;
    //public AudioSource audioSource1;
    private bool allowSpace = true;

    // Set initial visibility. Added images or buttons need to also be SetActive(false);
    void Start()
    {
        DialogueDisplay.SetActive(false);
        ArtBGGun.SetActive(false);
        ArtBGDriving.SetActive(true);
        ArtBGInsideWagon.SetActive(false);
        ArtBGPanel.SetActive(false);    
        Choice1a.SetActive(false);
        ChoiceCamera.SetActive(false);
        ChoiceLockDown.SetActive(false);
        ChoiceSetFreeAttempt.SetActive(false);
        ChoiceOpen.SetActive(false);
        ChoiceCallPickUp.SetActive(false);
        NextSceneMercyButton.SetActive(false);
        NextSceneObedienceButton.SetActive(false);
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
            Char1speech.text = "The train comes into motion once again.";
        }
        else if (primeInt == 2)
        {
            Choice1a.SetActive(true);
            CharBox.SetActive(false);
            nextButton.SetActive(false);
            allowSpace = false;
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "An hour passes by as suddenly a red light pops up next to the cargo management panel.";
        }

        else if (primeInt == 3)
        {
            ArtBGDriving.SetActive(false);
            ArtBGPanel.SetActive(true);
            Choice1a.SetActive(false);
            ChoiceCamera.SetActive(true);
            ChoiceLockDown.SetActive(true);
            CharBox.SetActive(false);
            nextButton.SetActive(false);
            allowSpace = false;
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "The green coloured monitor has now turned red and displays the following information:\r\n\r\n''Capacity:'' 823/1.000.\r\n''Weight:'' 57.610kg/10.00kg.\r\n''Activity:'' High/VIOLENT - Recommended course of action: LOCK DOWN.\r\n\r\nNow that the activity has amped up the security cameras have been unlocked.\r\n";
        }
        else if (primeInt == 5)
        {

        }

        else if (primeInt == 20)
        {
            ChoiceCallPickUp.SetActive(true);
            CharBox.SetActive(false);
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "The electric shocks must have been higher voltage than before on account of the high activity.\r\n\r\nThe radio buzzes.\r\n";
            nextButton.SetActive(false);
            allowSpace = false;
            NextSceneObedienceButton.SetActive(true);
        }
        else if (primeInt == 21)
        {
            CharBox.SetActive(true);
            DialogueDisplay.SetActive(true);
            Char1name.text = "Commanding Officer";
            Char1speech.text = "\"I noticed the signals from the vermin acting up. You did the right thing by silencing them.\"";
            nextButton.SetActive(true);
            allowSpace = true;
        }
        else if (primeInt == 22)
        {
            CharBox.SetActive(true);
            DialogueDisplay.SetActive(true);
            Char1name.text = "Commanding Officer";
            Char1speech.text = "\"People like you are what keeps our country safe. A strong individual who knows what needs to be done. A true patriotic warrior.\"";
            nextButton.SetActive(true);
            allowSpace = true;
        }
        else if (primeInt == 23)
        {
            CharBox.SetActive(true);
            DialogueDisplay.SetActive(true);
            Char1name.text = "Commanding Officer";
            Char1speech.text = "\"I am proud to have someone serve who knows how to follow orders.\"";
            nextButton.SetActive(true);
            allowSpace = true;
        }
        else if (primeInt == 24)
        {
            CharBox.SetActive(false);
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "The train continues towards the containment camp. Any chance for the imprisoned people to escape has been stopped.";
            nextButton.SetActive(false);
            allowSpace = false;
            NextSceneObedienceButton.SetActive(true);
        }
        else if (primeInt == 30)
        {
            CharBox.SetActive(false);
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "You see lanky figures clawing at the walls. Their faces look starved.\r\n";
            nextButton.SetActive(true);
            allowSpace = true;
        }
        else if (primeInt == 31)
        {
            CharBox.SetActive(false);
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "They wear ragged robes. Some sit in the corners, others violently smash against the doors. ";
            nextButton.SetActive(true);
            allowSpace = true;
        }
        else if (primeInt == 32)
        {
            ChoiceCallPickUp.SetActive(true);
            CharBox.SetActive(false);
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "//beep.. beep..// HQ calls in.";
            nextButton.SetActive(false);
            allowSpace = false;
        }
        else if (primeInt == 33)
        {
            ChoiceLockDown.SetActive(true);
            ChoiceSetFreeAttempt.SetActive(true);
            ChoiceCallPickUp.SetActive(false);
            CharBox.SetActive(true);
            DialogueDisplay.SetActive(true);
            Char1name.text = "Commanding Officer";
            Char1speech.text = "\"Looks like the monsters are revolting, why haven't you put the wagon into lock-down yet? We have a duty to keep the people safe from these things!\"\r\n\r\nAs you look through the camera the beings in the carriage smash against the walls and seem to scream, though you cannot hear it as the system does not support audio.\r\n";
            nextButton.SetActive(false);
            allowSpace = false;
        }
        else if (primeInt == 34)
        {
            ArtBGInsideWagon.SetActive(false);
            ArtBGDriving.SetActive(true);
            //Resistance
            ChoiceLockDown.SetActive(false);
            ChoiceSetFreeAttempt.SetActive(false);
            CharBox.SetActive(false);
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "You begin slowing down the train.";
            nextButton.SetActive(true);
            allowSpace = true;
        }
        else if (primeInt == 35)
        {
            //Resistance Final Choice
            ChoiceLockDown.SetActive(true);
            ChoiceOpen.SetActive(true);
            CharBox.SetActive(true);
            DialogueDisplay.SetActive(true);
            Char1name.text = "Commanding Officer";
            Char1speech.text = "The radio operator screams.\r\n\r\n\"WHAT ARE YOU DOING! They must not escape, they are a danger to us and our country! Put the wagon into lock-down and resume your course. There are consequences if you don't.\"\r\n";
            nextButton.SetActive(false);
            allowSpace = false;
        }
        else if (primeInt == 40)
        {
            ChoiceOpen.SetActive(false);
            //Consequences of resisting.
            CharBox.SetActive(false);
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "The wagon doors slowly open up. The people inside the wagon are shocked and gaze at the outside with bewilderment.";
            nextButton.SetActive(true);
            allowSpace = true;
        }
        else if (primeInt == 41)
        {
            //Consequences of resisting.
            CharBox.SetActive(false);
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "The light falls on their faces, human starving faces..";
            nextButton.SetActive(true);
            allowSpace = true;
        }
        else if (primeInt == 42)
        {
            //Consequences of resisting.
            CharBox.SetActive(false);
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "As the train comes to a stop they all jump out of the train, you notice one of them is holding a child which she must have concealed beneath her robes.";
            nextButton.SetActive(true);
            allowSpace = true;
        }
        else if (primeInt == 43)
        {
            //Consequences of resisting.
            CharBox.SetActive(false);
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "You hear chanting of joy outside, alongside screams of joy. You can hear a \"Thank you\" being said by trembling tearful voices.";
            nextButton.SetActive(true);
            allowSpace = true;
        }
        else if (primeInt == 44)
        {
            //Consequences of resisting.
            CharBox.SetActive(false);
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "Minutes pass..";
            nextButton.SetActive(true);
            allowSpace = true;
        }
        else if (primeInt == 45)
        {
            //Consequences of resisting.
            CharBox.SetActive(false);
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "Then\r\n\r\nYour door gets knocked down..\r\n";
            nextButton.SetActive(true);
            allowSpace = true;
        }
        else if (primeInt == 46)
        {
            ArtBGDriving.SetActive(false);
            ArtBGGun.SetActive(true);
            //Consequences of resisting.
            CharBox.SetActive(false);
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "Armed men dressed in black storm into your train and grab you before you're able to resist.\r\n\r\nThey drag you outside.\r\n";
            nextButton.SetActive(true);
            allowSpace = true;
        }
        else if (primeInt == 47)
        {
            //Consequences of resisting.
            CharBox.SetActive(false);
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "You hear a familiar voice.";
            nextButton.SetActive(true);
            allowSpace = true;
        }
        else if (primeInt == 48)
        {
            //Consequences of resisting.
            CharBox.SetActive(true);
            DialogueDisplay.SetActive(true);
            Char1name.text = "Commanding Officer";
            Char1speech.text = "\"Such a shame, you had a promising career in front of you.\"";
            nextButton.SetActive(true);
            allowSpace = true;
        }
        else if (primeInt == 49)
        {
            //Consequences of resisting.
            CharBox.SetActive(false);
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "A gun is put to your head.";
            nextButton.SetActive(true);
            allowSpace = true;
        }
        else if (primeInt == 50)
        {
            NextSceneMercyButton.SetActive(true);
            //Consequences of resisting.
            CharBox.SetActive(false);
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "And it all fades to black.";
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
    public void ChoiceLockDownFunct()
    {
        primeInt = 19;
        ChoiceCamera.SetActive(false);
        ChoiceLockDown.SetActive(false);
        Choice1a.SetActive(false);
        CharBox.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
        DialogueDisplay.SetActive(true);
        Char1name.text = "";
        Char1speech.text = "The lights flash red. Painful screams emerge from the carriages alongside cries for mercy \"Help us please!\" they seem to say but it's faint and difficult to understand.";
    }
    public void ChoiceCameraFunct()
    {
        ArtBGPanel.SetActive(false);
        ArtBGInsideWagon.SetActive(true);
        primeInt = 29;
        ChoiceCamera.SetActive(false);
        ChoiceLockDown.SetActive(false);
        Choice1a.SetActive(false);
        CharBox.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
        DialogueDisplay.SetActive(true);
        Char1name.text = "";
        Char1speech.text = "The static of the camera screen clears up and through a black and white lens you are able to see inside the cargo wagons.";
    }
    public void ChoiceOpenFunct()
    {
        primeInt = 39;
        ChoiceLockDown.SetActive(false);
        Choice1a.SetActive(false);
        CharBox.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
        DialogueDisplay.SetActive(true);
        Char1name.text = "";
        Char1speech.text = "The train begins to slow. You lock the guards quarters.";
    }

    public void CargoFunct()
    {
        Next();
    }
    public void RadioPickUpFunct()
    {
        Next();
    }

    public void SceneChange1()
    {
        //Change to resistance ending.
        SceneManager.LoadScene("Scene1A");
    }
    public void SceneChange2()
    {
        //Change to obedience ending.
        SceneManager.LoadScene("Scene2b");
    }
}