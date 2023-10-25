using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.U2D.Aseprite;
using UnityEngine;
using UnityEngine.UI;

public class KeyRow : MonoBehaviour
{

    public KeyboardButton[] keyboardButtons { get; private set; }

    // Start is called before the first frame update
    void Awake()
    {
        keyboardButtons = GetComponentsInChildren<KeyboardButton>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
