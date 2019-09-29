using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleRayTest : MonoBehaviour
{
    enum ActionState {Idle, Trimming, Cutting, Watering};
    public GameObject SpawnPrefab;
    ActionState actionState;

    void Start()
    {
        actionState = ActionState.Trimming;
        
    }

    

    void Update()
    {
        if (Input.touchCount>0)
        {
            if(Input.GetTouch(0).phase == TouchPhase.Began)
            {
                Debug.Log("TouchMade");
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit))
                {
                    if (actionState == ActionState.Trimming)
                    {
                        if (hit.collider.tag == "branchE")
                        {
                            Debug.Log("Collision");
                            Destroy(hit.collider.gameObject);
                        }

                    }

                }
            }
            
        }


        
    }


}
