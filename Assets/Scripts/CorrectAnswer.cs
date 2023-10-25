using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CorrectAnswer : MonoBehaviour{
    public TextMeshProUGUI corAnswText;

    public void SetCorrectAnswer(string answer){
        corAnswText.text = answer.ToUpper();
    }

    private void Awake(){
        //corAnswText = GetComponent<TextMeshProUGUI>();
    }

    public void EnableAnswer(){
        gameObject.SetActive(true);
    }

    public void DisableAnswer(){
        gameObject.SetActive(false);
    }
}
