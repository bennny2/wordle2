using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Tile : MonoBehaviour
{
    [System.Serializable]
    public class TileState{

        public Color fillColor;
        public Color outlineColor;

    }
    private TextMeshProUGUI text;
    private Image fill;
    private Outline outline;

    public char Letter { get; private set; }
    public TileState State { get; private set; }

    private void Awake(){

        text = GetComponentInChildren<TextMeshProUGUI>();
        fill = GetComponent<Image>();
        outline = GetComponent<Outline>();
    }

    public void SetLetter(char letter){

        Letter = letter;
        text.text = letter.ToString();

    }

    public void SetState(TileState state){

        State = state;
        fill.color = state.fillColor;
        outline.effectColor = state.outlineColor;
    }
}
