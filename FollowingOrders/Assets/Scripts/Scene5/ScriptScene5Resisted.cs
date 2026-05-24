using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class ScriptScene5Resisted : MonoBehaviour
{
    // These are the script variables.
    // For more character images / buttons, copy & renumber the variables:
    public int primeInt = 1;        // This integer drives game progress!
    public TMP_Text Char1name;
    public TMP_Text Char1speech;
    public GameObject ScrollViewChar1;
    public GameObject DialogueDisplay;
    //public GameObject ArtChar1a;
    //public GameObject ArtChar1b;
    //public GameObject ArtChar1c;
    //public GameObject ArtChar2;
    public GameObject ArtBGBlack;
    public GameObject ArtBGTrain;
    public GameObject ChoiceLady;
    public GameObject ChoiceMan;
    public GameObject ChoiceSilence;
    public GameObject ChoiceTalkToThem;
    public GameObject NextSceneButton;
    public GameObject nextButton;
    public GameObject CharBox;
    //public AudioSource audioSource1;
    private bool allowSpace = true;

    // Set initial visibility. Added images or buttons need to also be SetActive(false);
    void Start()
    {
        CharBox.SetActive(false);
        DialogueDisplay.SetActive(false);
        ArtBGBlack.SetActive(true);
        ArtBGTrain.SetActive(false);
        ChoiceLady.SetActive(false);
        ChoiceMan.SetActive(false);
        ChoiceSilence.SetActive(false);
        ChoiceTalkToThem.SetActive(false);
        NextSceneButton.SetActive(false);
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
            Char1speech.text = "It's dark and damp.\r\n.";
        }
        else if (primeInt == 2)
        {
            CharBox.SetActive(false);
            nextButton.SetActive(true);
            allowSpace = true;
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "You hear the rattling of rails underneath you.";
        }
        else if (primeInt == 3)
        {
            CharBox.SetActive(false);
            nextButton.SetActive(true);
            allowSpace = true;
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "You are on a train in a prison carriage.";
        }
        else if (primeInt == 4)
        {
            CharBox.SetActive(false);
            nextButton.SetActive(true);
            allowSpace = true;
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "As you look around you see several people malnourished and clothed in rags around you.\r\n\r\nYou are wearing one too.";
        }
        else if (primeInt == 5)
        {
            ChoiceSilence.SetActive(true);
            ChoiceTalkToThem.SetActive(true);
            CharBox.SetActive(false);
            nextButton.SetActive(false);
            allowSpace = false;
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "There are several people with you in the wagon. You count about 25.\r\n\r\nThere's a mom with a baby hidden under her robes, it seems too tired to cry. She wears a hijab under her cloth.\r\n\r\nAn old man licks the drops of condensation from the wall, his belly rumbles.";
        }
        else if (primeInt == 6)
        {
            ChoiceLady.SetActive(true);
            ChoiceMan.SetActive(true);
            ChoiceSilence.SetActive(false);
            ChoiceTalkToThem.SetActive(false);
            CharBox.SetActive(false);
            nextButton.SetActive(false);
            allowSpace = false;
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "Who do you want to talk to?";
        }

        else if (primeInt == 10)
        {
            CharBox.SetActive(false);
            nextButton.SetActive(true);
            allowSpace = true;
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "She's scared. She was born in this country, same as you.\r\nThe men in black said she and her muslim family needed to go back to her country.\r\n";
        }
        else if (primeInt == 11)
        {
            CharBox.SetActive(false);
            nextButton.SetActive(true);
            allowSpace = true;
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "Her religion was vilified, they were called: \"savages who don't adhere to our values\".";
        }
        else if (primeInt == 12)
        {
            CharBox.SetActive(false);
            nextButton.SetActive(true);
            allowSpace = true;
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "Her partner tried to help them escape. He was shot before her eyes, the officer who did it said he was reaching for a gun.";
        }
        else if (primeInt == 13)
        {
            CharBox.SetActive(false);
            nextButton.SetActive(true);
            allowSpace = true;
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "Her husband was unarmed.";
        }
        else if (primeInt == 14)
        {
            ChoiceMan.SetActive(true);
            ChoiceSilence.SetActive(true);
            CharBox.SetActive(false);
            nextButton.SetActive(false);
            allowSpace = false;
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "The baby falls asleep.";
        }
        else if (primeInt == 20)
        {
            CharBox.SetActive(false);
            nextButton.SetActive(true);
            allowSpace = true;
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "He tells you how he and his husband were rounded up by men in black, and says their only crime was loving each other.";
        }
        else if (primeInt == 21)
        {
            CharBox.SetActive(false);
            nextButton.SetActive(true);
            allowSpace = true;
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "Tears run down his face, he drinks them up as soon as they reach his mouth..";
        }
        else if (primeInt == 22)
        {
            CharBox.SetActive(false);
            nextButton.SetActive(true);
            allowSpace = true;
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "He says he doesn't know where his partner is.";
        }

        else if (primeInt == 23)
        {
            ChoiceLady.SetActive(true);
            ChoiceSilence.SetActive(true);
            CharBox.SetActive(false);
            nextButton.SetActive(false);
            allowSpace = false;
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "They were put on different trains..";
        }
        else if (primeInt == 30)
        {
            CharBox.SetActive(false);
            nextButton.SetActive(true);
            allowSpace = true;
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "Through the cracks in the wagon you see the places of the country you grew up in pass you by.\r\n";
        }
        else if (primeInt == 31)
        {
            CharBox.SetActive(false);
            nextButton.SetActive(true);
            allowSpace = true;
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "The train begins to slow.";
        }
        else if (primeInt == 32)
        {
            CharBox.SetActive(false);
            nextButton.SetActive(true);
            allowSpace = true;
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "The wagon doors slowly open up.";
        }
        else if (primeInt == 33)
        {
            CharBox.SetActive(false);
            nextButton.SetActive(true);
            allowSpace = true;
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "The daylight falls on their faces.";
        }
        else if (primeInt == 34)
        {
            CharBox.SetActive(false);
            nextButton.SetActive(true);
            allowSpace = true;
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "As the train comes to a stop you all jump out of the train.";
        }
        else if (primeInt == 35)
        {
            CharBox.SetActive(false);
            nextButton.SetActive(true);
            allowSpace = true;
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "You hear chanting of joy, alongside screams of hope and disbelief.\r\n\r\nYou run away from the tracks.\r\n";
        }
        else if (primeInt == 36)
        {
            NextSceneButton.SetActive(true);
            CharBox.SetActive(false);
            nextButton.SetActive(false);
            allowSpace = false;
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "\r\nTowards freedom.\r\n";
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
    public void ChoiceLadyFunct()
    {
        primeInt = 9;
        ChoiceLady.SetActive(false);
        ChoiceMan.SetActive(false);
        CharBox.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
        DialogueDisplay.SetActive(true);
        Char1name.text = "";
        Char1speech.text = "You approach the mother.";
    }
    public void ChoiceManFunct()
    {
        primeInt = 19;
        ChoiceLady.SetActive(false);
        ChoiceMan.SetActive(false);
        CharBox.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
        DialogueDisplay.SetActive(true);
        Char1name.text = "";
        Char1speech.text = "You approach the old man.";
    }
    public void ChoiceSitInSilenceFunct()
    {
        primeInt = 29;
        ChoiceLady.SetActive(false);
        ChoiceMan.SetActive(false);
        ChoiceTalkToThem.SetActive(false);
        ChoiceSilence.SetActive(false);
        CharBox.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
        DialogueDisplay.SetActive(true);
        Char1name.text = "";
        Char1speech.text = "Time passes in the dark.";
    }
    public void ChoiceTalkToThemFunct()
    {
        Next();
    }

    public void SceneChangeFunct()
    {

    }
}