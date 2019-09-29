using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class StatusManager : MonoBehaviour
{
    public static int plantCountMax = 50;
    public bool eraseSave = false;

    public bool firstSave = true;
    public int plantCount = 0;
    public TextMeshProUGUI PC;
    public TextMeshProUGUI path;

    public bool[] plantCollection;      //Plant Enabled/Disabled
    public int[] plantHealth;           //100 to 0. 100=Perfect Health. 0=Dead
    public int[] plantWateredStatus;    //200 to 0. 200=Overwatered, 100=Normal, 0=Dry
    public int[] plantGrowthSpeed;      //10x, 5x, 3x, 2x, 1x SpeedUp


    //Per Plant save info:Days from start, watered days, Speed(set at start), health 100% to 0%,

    void Start()
    {
        path.text ="Path: " + Application.persistentDataPath;

        plantCollection = new bool[plantCountMax];
        plantHealth = new int[plantCountMax];
        plantWateredStatus = new int[plantCountMax];
        plantGrowthSpeed = new int[plantCountMax];

    }

    // Update is called once per frame
    void Update()
    {
        PC.text = plantCount.ToString();
    }

    public void SaveBTN()
    {
        SaveSystem.SaveStatus(this);
    }
}
