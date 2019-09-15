using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIControl : MonoBehaviour
{
    public GameObject TitleScreen;

    public float fadeSpd=2;
    public float fadeCap = 1.2f;
    public GameObject ContinueBG;
    public TextMeshProUGUI continueLabel;
    Image continueImage;
    Color FadeBG, FadeText;

    void Start()
    {
        continueImage = ContinueBG.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (TitleScreen.activeSelf)
        {
            float t = Time.time;
            //float s = (Mathf.Sin(t * fadeSpd) + 1) / 2;
            float s = Mathf.Abs(Mathf.Sin(t * fadeSpd))*fadeCap;

            if (s >= 1) s = 1;


            FadeBG = Color.Lerp(new Color32(0, 0, 0, 0), new Color32(0, 0, 0, 50), s);
            FadeText = Color.Lerp(new Color32(255, 255, 255, 0), new Color32(255, 255, 255, 255), s);
            continueImage.color = FadeBG;
            continueLabel.color = FadeText;

        }

        

        

    }

    

}
