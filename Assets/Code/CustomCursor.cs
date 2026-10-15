using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class CustomCursor : MonoBehaviour
{
    private void Awake()
    {
        transform.position = Input.mousePosition;
    }
    private void Update()
    {
        transform.position = Input.mousePosition;
    }
}

