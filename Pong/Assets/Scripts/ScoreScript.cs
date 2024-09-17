using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    private TMP_Text _tx;

    // Start is called before the first frame update
    void Start()
    {
        _tx = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_tx.name == "RightScore") _tx.text = $"{GlobalData.RightScore}";
        else if (_tx.name == "LeftScore") _tx.text = $"{GlobalData.LeftScore}";
    }

    private void LateUpdate()
    {
        if(GlobalData.RightScore>=10 || GlobalData.LeftScore>=10) EndGame();
    }

    public void EndGame()
    {
        SceneManager.LoadScene("EndScene");
    }
}
