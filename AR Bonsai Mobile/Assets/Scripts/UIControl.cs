using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

/*This Script is  responsible for handling all UI events. This includes:
 *      -Menu Transitions
 *      -UI Animations
 *      -Easy Menu Navigation 
 *      -Viewing saved data
 *      -Options and Settings
 *      
 *
 */

public class UIControl : MonoBehaviour
{
    //UI Panels
    public GameObject TitleScreenPanel, MainMenuPanel, NewMenuPanel, AboutMenuPanel, ViewMenuPanel, SettingPanel;

    //UI BG Images
    public GameObject TitleBGImage, MenuBGImage;

    //Flashing Text Vars
    public float fadeSpd=2;
    public float fadeCap = 1.2f;
    public GameObject ContinueBG;
    public TextMeshProUGUI continueLabel;
    Image continueImage;
    Color FadeBG, FadeText;

    //Misc
    Animator TitleAnimator; //Control Title Screen Animations
    bool MenuImageON; //Toggle Menu BG Image




    void Start()
    {
        continueImage = ContinueBG.GetComponent<Image>();
        TitleAnimator = TitleBGImage.GetComponent<Animator>();
        MenuImageON = true;
    }

    void Update()
    {
        if (TitleScreenPanel.activeSelf)
        {
            //Flashing Text on Title Screen
            float fadeTime = Time.time;
            float FadeAmt = Mathf.Abs(Mathf.Sin(fadeTime * fadeSpd)) * fadeCap;
            if (FadeAmt >= 1) FadeAmt = 1;
            FadeBG = Color.Lerp(new Color32(0, 0, 0, 0), new Color32(0, 0, 0, 50), FadeAmt);
            FadeText = Color.Lerp(new Color32(255, 255, 255, 0), new Color32(255, 255, 255, 255), FadeAmt);
            continueImage.color = FadeBG;
            continueLabel.color = FadeText;

        }
        else
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                if (TitleAnimator.GetCurrentAnimatorStateInfo(0).IsName("TitleIdle1") && MainMenuPanel.activeSelf)
                {
                    TitleAnimator.SetBool("BACK", true);
                    TitleAnimator.SetBool("FWD", false);
                }
                /*else if (TitleAnimator.GetCurrentAnimatorStateInfo(0).IsName("MainMenuExit"))
                {
                    if (NewMenuPanel.activeSelf) //Replace MainMenu with CurrentMenuPanelOBJ
                    {
                        MainMenuPanel.SetActive(true);
                        NewMenuPanel.SetActive(true);
                        TitleAnimator.SetBool("BLOCK", false);
                    }
                    else if (AboutMenuPanel.activeSelf) //Replace MainMenu with CurrentMenuPanelOBJ
                    {
                        MainMenuPanel.SetActive(true);
                        AboutMenuPanel.SetActive(true);
                        TitleAnimator.SetBool("BLOCK", false);
                    }
                }*/
                

            }
            if (TitleAnimator.GetCurrentAnimatorStateInfo(0).IsName("TitleIdle1"))
            {
                MainMenuPanel.SetActive(true);
            }
            else
            {
                MainMenuPanel.SetActive(false);
            }
            
        }
        
        //Menu Image Visiblility Control
        if((MainMenuPanel.activeSelf || NewMenuPanel.activeSelf || ViewMenuPanel.activeSelf || SettingPanel.activeSelf || AboutMenuPanel.activeSelf) && (MenuImageON))
        {
            MenuBGImage.SetActive(true);
        }
        else
        {
            MenuBGImage.SetActive(false);
        }

    }


    //Toggle TitleScreen Visibilty using Animator Parameters and Events located in ToggleAnimEvent.cs
    public void TitleContinue()
    {
        TitleAnimator.SetBool("FWD", true);
        TitleAnimator.SetBool("BACK", false);
    }

    //Disable TitleScreenAnimations
    public void BlockTitleAnim()
    {
        TitleAnimator.SetBool("BLOCK", true);
    }
    //Enable TitleScreenAnimations
    public void UnblockTitleAnim()
    {
        TitleAnimator.SetBool("BLOCK", false);
    }
}
