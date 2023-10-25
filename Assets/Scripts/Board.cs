using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.U2D.Aseprite;
using UnityEngine;

public class Board : MonoBehaviour
{
    private static readonly KeyCode[] SUPPORTED_KEYS = new KeyCode[]{
        KeyCode.A ,KeyCode.B ,KeyCode.C ,KeyCode.D ,KeyCode.E ,KeyCode.F ,
        KeyCode.G ,KeyCode.H ,KeyCode.I ,KeyCode.J ,KeyCode.K ,KeyCode.L ,
        KeyCode.M ,KeyCode.N ,KeyCode.O ,KeyCode.P ,KeyCode.Q ,KeyCode.R ,
        KeyCode.S ,KeyCode.T ,KeyCode.U ,KeyCode.V ,KeyCode.W ,KeyCode.X ,
        KeyCode.Y ,KeyCode.Z 
    } ;
    
    private Row[] rows;
    public KeyRow[] keyRowsArray;


    private string[] solutions;
    private string[] validWords;
    private string word;

    private int rowIndex;
    
    private int columnIndex;

    [Header("States")]
    public Tile.TileState emptyState;
    public Tile.TileState occupiedState;
    public Tile.TileState correctState;
    public Tile.TileState wrongSpotState;
    public Tile.TileState incorrectState;



    public GameObject invalidWordText;
    public GameObject newWordButton;
    
    public CorrectAnswer correctAnswer;
    

    public Color myashBackground;
    public Color myGreenBackground;
    public Color myGreyBackground;
    public Color myYellowBackground;
    

    private void Awake(){
        rows = GetComponentsInChildren<Row>();
    }
    
    private void Start(){
        LoadData();
        SetRandomWord();
        
    }

    public void NewGame(){
        SetRandomWord();
        ClearBoard(keyRowsArray);
        enabled = true;
    }


    private void SetRandomWord(){
        word = solutions[UnityEngine.Random.Range(0, solutions.Length)]; //picks a random word form list
        word = word.ToLower().Trim();
        correctAnswer.SetCorrectAnswer(word);
    }

    private void LoadData(){
        TextAsset textFile = Resources.Load("official_wordle_all") as TextAsset; //inits the playable words
        validWords = textFile.text.Split('\n');

        textFile = Resources.Load("official_wordle_common") as TextAsset; //inits the solutions
        solutions = textFile.text.Split('\n');
    }

    public void QPress(){
        Row currentRow = rows[rowIndex];
        if (columnIndex <= currentRow.tiles.Length-1){    
            currentRow.tiles[columnIndex].SetLetter((char)KeyCode.Q);
            currentRow.tiles[columnIndex].SetState(occupiedState);
            columnIndex ++;
        }
    }

    public void WPress(){
        Row currentRow = rows[rowIndex];
        if (columnIndex <= currentRow.tiles.Length-1){    
            currentRow.tiles[columnIndex].SetLetter((char)KeyCode.W);
            currentRow.tiles[columnIndex].SetState(occupiedState);
            columnIndex ++;
        }
    }

    public void PPress(){
        Row currentRow = rows[rowIndex];
        if (columnIndex <= currentRow.tiles.Length-1){    
            currentRow.tiles[columnIndex].SetLetter((char)KeyCode.P);
            currentRow.tiles[columnIndex].SetState(occupiedState);
            columnIndex ++;
        }
    }

    public void OPress(){
        Row currentRow = rows[rowIndex];
        if (columnIndex <= currentRow.tiles.Length-1){    
            currentRow.tiles[columnIndex].SetLetter((char)KeyCode.O);
            currentRow.tiles[columnIndex].SetState(occupiedState);
            columnIndex ++;
        }
    }

    public void GPress(){
        Row currentRow = rows[rowIndex];
        if (columnIndex <= currentRow.tiles.Length-1){    
            currentRow.tiles[columnIndex].SetLetter((char)KeyCode.G);
            currentRow.tiles[columnIndex].SetState(occupiedState);
            columnIndex ++;
        }
    }

    public void LPress(){
        Row currentRow = rows[rowIndex];
        if (columnIndex <= currentRow.tiles.Length-1){    
            currentRow.tiles[columnIndex].SetLetter((char)KeyCode.L);
            currentRow.tiles[columnIndex].SetState(occupiedState);
            columnIndex ++;
        }
    }

    public void MPress(){
        Row currentRow = rows[rowIndex];
        if (columnIndex <= currentRow.tiles.Length-1){    
            currentRow.tiles[columnIndex].SetLetter((char)KeyCode.M);
            currentRow.tiles[columnIndex].SetState(occupiedState);
            columnIndex ++;
        }
    }

    public void NPress(){
        Row currentRow = rows[rowIndex];
        if (columnIndex <= currentRow.tiles.Length-1){    
            currentRow.tiles[columnIndex].SetLetter((char)KeyCode.N);
            currentRow.tiles[columnIndex].SetState(occupiedState);
            columnIndex ++;
        }
    }
    public void BPress(){
        Row currentRow = rows[rowIndex];
        if (columnIndex <= currentRow.tiles.Length-1){    
            currentRow.tiles[columnIndex].SetLetter((char)KeyCode.B);
            currentRow.tiles[columnIndex].SetState(occupiedState);
            columnIndex ++;
        }
    }

    public void APress(){
        Row currentRow = rows[rowIndex];
        if (columnIndex <= currentRow.tiles.Length-1){    
            currentRow.tiles[columnIndex].SetLetter((char)KeyCode.A);
            currentRow.tiles[columnIndex].SetState(occupiedState);
            columnIndex ++;
        }
    }

    public void SPress(){
        Row currentRow = rows[rowIndex];
        if (columnIndex <= currentRow.tiles.Length-1){    
            currentRow.tiles[columnIndex].SetLetter((char)KeyCode.S);
            currentRow.tiles[columnIndex].SetState(occupiedState);
            columnIndex ++;
        }
    }

    public void EPress(){
        Row currentRow = rows[rowIndex];
        if (columnIndex <= currentRow.tiles.Length-1){    
            currentRow.tiles[columnIndex].SetLetter((char)KeyCode.E);
            currentRow.tiles[columnIndex].SetState(occupiedState);
            columnIndex ++;
        }
    }

    public void RPress(){
        Row currentRow = rows[rowIndex];
        if (columnIndex <= currentRow.tiles.Length-1){    
            currentRow.tiles[columnIndex].SetLetter((char)KeyCode.R);
            currentRow.tiles[columnIndex].SetState(occupiedState);
            columnIndex ++;
        }
    }

    public void TPress(){
        Row currentRow = rows[rowIndex];
        if (columnIndex <= currentRow.tiles.Length-1){    
            currentRow.tiles[columnIndex].SetLetter((char)KeyCode.T);
            currentRow.tiles[columnIndex].SetState(occupiedState);
            columnIndex ++;
        }
    }

    public void YPress(){
        Row currentRow = rows[rowIndex];
        if (columnIndex <= currentRow.tiles.Length-1){    
            currentRow.tiles[columnIndex].SetLetter((char)KeyCode.Y);
            currentRow.tiles[columnIndex].SetState(occupiedState);
            columnIndex ++;
        }
    }

    public void UPress(){
        Row currentRow = rows[rowIndex];
        if (columnIndex <= currentRow.tiles.Length-1){    
            currentRow.tiles[columnIndex].SetLetter((char)KeyCode.U);
            currentRow.tiles[columnIndex].SetState(occupiedState);
            columnIndex ++;
        }
    }

    public void IPress(){
        Row currentRow = rows[rowIndex];
        if (columnIndex <= currentRow.tiles.Length-1){    
            currentRow.tiles[columnIndex].SetLetter((char)KeyCode.I);
            currentRow.tiles[columnIndex].SetState(occupiedState);
            columnIndex ++;
        }
    }

    public void DPress(){
        Row currentRow = rows[rowIndex];
        if (columnIndex <= currentRow.tiles.Length-1){    
            currentRow.tiles[columnIndex].SetLetter((char)KeyCode.D);
            currentRow.tiles[columnIndex].SetState(occupiedState);
            columnIndex ++;
        }
    }

    public void FPress(){
        Row currentRow = rows[rowIndex];
        if (columnIndex <= currentRow.tiles.Length-1){    
            currentRow.tiles[columnIndex].SetLetter((char)KeyCode.F);
            currentRow.tiles[columnIndex].SetState(occupiedState);
            columnIndex ++;
        }
    }

    public void HPress(){
        Row currentRow = rows[rowIndex];
        if (columnIndex <= currentRow.tiles.Length-1){    
            currentRow.tiles[columnIndex].SetLetter((char)KeyCode.H);
            currentRow.tiles[columnIndex].SetState(occupiedState);
            columnIndex ++;
        }
    }

   public void JPress(){
        Row currentRow = rows[rowIndex];
        if (columnIndex <= currentRow.tiles.Length-1){    
            currentRow.tiles[columnIndex].SetLetter((char)KeyCode.J);
            currentRow.tiles[columnIndex].SetState(occupiedState);
            columnIndex ++;
        }
    }

    public void KPress(){
        Row currentRow = rows[rowIndex];
        if (columnIndex <= currentRow.tiles.Length-1){    
            currentRow.tiles[columnIndex].SetLetter((char)KeyCode.K);
            currentRow.tiles[columnIndex].SetState(occupiedState);
            columnIndex ++;
        }
    }

    public void ZPress(){
        Row currentRow = rows[rowIndex];
        if (columnIndex <= currentRow.tiles.Length-1){    
            currentRow.tiles[columnIndex].SetLetter((char)KeyCode.Z);
            currentRow.tiles[columnIndex].SetState(occupiedState);
            columnIndex ++;
        }
    }

    public void XPress(){
        Row currentRow = rows[rowIndex];
        if (columnIndex <= currentRow.tiles.Length-1){    
            currentRow.tiles[columnIndex].SetLetter((char)KeyCode.X);
            currentRow.tiles[columnIndex].SetState(occupiedState);
            columnIndex ++;
        }
    }

    public void CPress(){
        Row currentRow = rows[rowIndex];
        if (columnIndex <= currentRow.tiles.Length-1){    
            currentRow.tiles[columnIndex].SetLetter((char)KeyCode.C);
            currentRow.tiles[columnIndex].SetState(occupiedState);
            columnIndex ++;
        }
    }

    public void VPress(){
        Row currentRow = rows[rowIndex];
        if (columnIndex <= currentRow.tiles.Length-1){    
            currentRow.tiles[columnIndex].SetLetter((char)KeyCode.V);
            currentRow.tiles[columnIndex].SetState(occupiedState);
            columnIndex ++;
        }
    }

    public void EnterPress(){
        Row currentRow = rows[rowIndex];
        SubmitRow(currentRow, keyRowsArray);
    }

    
    public void BackPress(){
        Row currentRow = rows[rowIndex];
        invalidWordText.SetActive(false);
        columnIndex = Mathf.Max(columnIndex -1, 0);
        currentRow.tiles[columnIndex].SetLetter('\0');
        currentRow.tiles[columnIndex].SetState(emptyState);
        
    }

    private void Update()
    {
        Row currentRow = rows[rowIndex];

        if (Input.GetKeyDown(KeyCode.Backspace)){ //set the tile and state to empty
            invalidWordText.SetActive(false);
            columnIndex = Mathf.Max(columnIndex -1, 0);
            currentRow.tiles[columnIndex].SetLetter('\0');
            currentRow.tiles[columnIndex].SetState(emptyState);
        }

        else if (columnIndex >= currentRow.tiles.Length){ //calls submit row
            if (Input.GetKeyDown(KeyCode.Return)){
                SubmitRow(currentRow, keyRowsArray);
            }
        }

        else
        {
            for (int i = 0; i < SUPPORTED_KEYS.Length; i++){ //checks for a letter press, sets the letter for that tile, set tile to occupied
                if (Input.GetKeyDown(SUPPORTED_KEYS[i])){
                    currentRow.tiles[columnIndex].SetLetter((char)SUPPORTED_KEYS[i]);
                    currentRow.tiles[columnIndex].SetState(occupiedState);
                    columnIndex ++;
                    break;
                }
            }
        }
    }


    private void SubmitRow(Row row, KeyRow[] keyRowsArrayP){

        if(!IsVaildWord(row.Word)){
            invalidWordText.SetActive(true);
            return;
        }

        string remaining = word;
        
        for(int i = 0; i < row.tiles.Length; i++){

            Tile tile = row.tiles[i];

            if (tile.Letter == word[i]){
                tile.SetState(correctState); // correct

                remaining = remaining.Remove(i, 1); // removes correct letter from solution so cant get a yellow for an already green letter
                remaining = remaining.Insert(i, " ");


                foreach (KeyRow keyRow in keyRowsArrayP)
                {
                    foreach (KeyboardButton button in keyRow.keyboardButtons)
                        {   
                            if(Char.ToUpper(tile.Letter) == button.Letter){
                                button.fill.color = myGreenBackground;
                            }
                        }
                }


            }
            else if (!word.Contains(tile.Letter)){
                tile.SetState(incorrectState); // incorrect
                foreach (KeyRow keyRow in keyRowsArrayP)
                {
                    foreach (KeyboardButton button in keyRow.keyboardButtons)
                        {   
                            if(Char.ToUpper(tile.Letter) == button.Letter & button.fill.color != myGreenBackground){
                                button.fill.color = myGreyBackground;
                                
                            }
                        }
                }
            }
            }

        for(int i = 0; i < row.tiles.Length; i++){
            Tile tile = row.tiles[i];

            if(tile.State!= correctState && tile.State != incorrectState){ //if not immediately green or wrong
                if (remaining.Contains(tile.Letter)){
                    tile.SetState(wrongSpotState);
                    foreach (KeyRow keyRow in keyRowsArrayP)
                {
                    foreach (KeyboardButton button in keyRow.keyboardButtons)
                        {   
                            if(Char.ToUpper(tile.Letter) == button.Letter & button.fill.color != myGreenBackground){
                                button.fill.color = myYellowBackground;           
                            }
                        }
                }

                    int index = remaining.IndexOf(tile.Letter); //finds correct index for the letter that should be removed
                    remaining = remaining.Remove(index, 1); // removes correct letter from solution so cant get a yellow for an already green letter
                    remaining = remaining.Insert(index, " ");
                }
                else{
                   tile.SetState(incorrectState); // incorrect
                   foreach (KeyRow keyRow in keyRowsArrayP)
                {
                    foreach (KeyboardButton button in keyRow.keyboardButtons)
                        {   
                            if(Char.ToUpper(tile.Letter) == button.Letter & button.fill.color != myGreenBackground){
                                button.fill.color = myGreyBackground;
                                
                            }
                        }
                } 
                }
            }

        }
        
        if (HasWon(row)){
            enabled = false;
        }
        
        rowIndex++;
        columnIndex = 0;

        if (rowIndex >= rows.Length){
            enabled = false;
            if (!HasWon(row)){
                correctAnswer.EnableAnswer();
            }
        } 
    } 


    private bool IsVaildWord(string word){
        for(int i = 0; i < validWords.Length; i++){
            if(word == validWords[i]){
                return true;
            }
        }
        return false;
    }
    
    private bool HasWon(Row row){
        for (int i = 0; i < row.tiles.Length; i++){
            if(row.tiles[i].State != correctState){
                return false;
            }
        }
        return true;
    }

    private void OnEnable(){
        newWordButton.SetActive(false);
        correctAnswer.DisableAnswer();
    }

    private void OnDisable(){
        newWordButton.SetActive(true);
    }

    private void ClearBoard(KeyRow[] keyRowsArrayP){
        for(int row = 0; row < rows.Length; row++){
            for(int tile = 0; tile < rows[row].tiles.Length; tile++){
                rows[row].tiles[tile].SetLetter('\0');
                rows[row].tiles[tile].SetState(emptyState);
            }
        }
        rowIndex = 0;
        columnIndex = 0;
         foreach (KeyRow keyRow in keyRowsArrayP)
                {
                    foreach (KeyboardButton button in keyRow.keyboardButtons)
                        {   
                            button.fill.color = myashBackground;
                        }
                } 
    } 
}


