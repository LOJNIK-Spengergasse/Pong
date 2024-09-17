using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EndScreenScript : MonoBehaviour
{
    [SerializeField]
    private TMP_Text TextWinner;
    [SerializeField]
    private TMP_Text TextEndScore;

    // Start is called before the first frame update
    void Start()
    {
        TextWinner.text = (GlobalData.LastWin == 1) ? "Player Left Wins" : "Player Right Wins";
        TextEndScore.text = (GlobalData.LastWin == 1) ? $"{GlobalData.LeftScore} : {GlobalData.LeftScore}": $"{GlobalData.RightScore} : {GlobalData.RightScore}";
    }
}
