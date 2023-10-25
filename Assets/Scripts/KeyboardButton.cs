using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.U2D.Aseprite;
using UnityEngine;
using UnityEngine.UI;
public class KeyboardButton : MonoBehaviour
{

    public Image fill;

    public TextMeshProUGUI text;
    public char Letter { get; private set; }
    
    private void Awake(){
        fill = GetComponent<Image>();
        text = GetComponentInChildren<TextMeshProUGUI>();
        Letter = SetLetter(text.text);// get/set? letter in the keyboard button and assign it to Letter char
     }

    private char SetLetter(string keyboardLetter){
        return char.Parse(keyboardLetter.Trim());
    }


}


