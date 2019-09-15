using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Status
{
    public bool firstSave;
    public int plantCount;
    public bool[] plantCollection;


    public Status(StatusManager SM)
    {
        firstSave = SM.firstSave;
        plantCount = SM.plantCount;
        plantCollection = SM.plantCollection;
        
    }




}
