using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class TriggerInteraction : MonoBehaviour
{
    PotionNumber PotionNumber;
    //public GameObject Door;
    //public int i = 0;
    public UnityEvent enteredTrigger, exitedTrigger;

    void Start()
    {
        PotionNumber=GameObject.FindGameObjectWithTag("PotionManager").GetComponent<PotionNumber>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        enteredTrigger.Invoke();
        //i++;
        if(PotionNumber.Instance == null)
        {
          PotionNumber.Instance.AddCount();  
        }
        else
        {
            Debug.Log("FAILED MORON");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        exitedTrigger.Invoke();
    }
}