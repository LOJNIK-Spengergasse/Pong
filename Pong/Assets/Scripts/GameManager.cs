using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int _winCond;

    [SerializeField] private Transform ball;
    [SerializeField] private Transform racketL;
    [SerializeField] private Transform racketR;
    private Rigidbody2D ballRb;
    private Rigidbody2D leftRacketRb;
    private Rigidbody2D rightRacketRb;
    // Start is called before the first frame update
    void Start()
    {
        ballRb = ball.GetComponent<Rigidbody2D>();
        leftRacketRb = racketL.GetComponent<Rigidbody2D>();
        rightRacketRb = racketR.GetComponent<Rigidbody2D>();
        GlobalData.LeftScore = 0;
        GlobalData.RightScore = 0;
        GlobalData.winCond = _winCond;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LateUpdate()
    {
        if (GlobalData.RightScore >= _winCond || GlobalData.LeftScore >= _winCond) EndGame();
    }

    public void ResetGame(float speed)
    {
        //ball
        ballRb.position = new Vector3(0f, 0f, 0f);
        ballRb.velocity = new Vector2(GlobalData.LastWin * speed, 0);
        //rackets
        racketL.position = new Vector3(-8f, 0f, 0f);
        leftRacketRb.velocity = new Vector2(0, 0);
        racketR.position = new Vector3(8f, 0f, 0f);
        rightRacketRb.velocity = new Vector2(0, 0);
    }

    public void LeftScore()
    {
        GlobalData.LeftScore++;
        GlobalData.LastWin = 1;
    }
    public void RightScore()
    {
        GlobalData.RightScore++;
        GlobalData.LastWin = -1;
    }

    public void EndGame()
    {
        SceneManager.LoadScene("EndScene");
    }
}
