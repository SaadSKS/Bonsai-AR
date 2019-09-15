using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempRotateTitle : MonoBehaviour
{
    public GameObject T1, T2, T3, T4;
    int N;

    void Start()
    {
        N = 1;
        T1.SetActive(true);
        T2.SetActive(false);
        T3.SetActive(false);
        T4.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (N > 4)
        {
            N = 1;
        }

        if (N == 1)
        {
            T1.SetActive(true);
            T2.SetActive(false);
            T3.SetActive(false);
            T4.SetActive(false);
        }
        else if (N == 2)
        {
            T1.SetActive(false);
            T2.SetActive(true);
            T3.SetActive(false);
            T4.SetActive(false);
        }
        else if (N == 3)
        {
            T1.SetActive(false);
            T2.SetActive(false);
            T3.SetActive(true);
            T4.SetActive(false);
        }
        else if (N == 4)
        {
            T1.SetActive(false);
            T2.SetActive(false);
            T3.SetActive(false);
            T4.SetActive(true);
        }
    }

    public void SwitchTitle()
    {
        N++;
    }
}
