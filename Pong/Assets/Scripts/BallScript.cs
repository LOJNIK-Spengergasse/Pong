using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    private Rigidbody2D _rb;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        GlobalData.LeftScore = 0;
        GlobalData.RightScore = 0;
        ResetBall();
    }

    private void ResetBall()
    {
        _rb.position = new Vector3(0f, 0f, 0f);
        _rb.velocity = new Vector2(GlobalData.LastWin * _speed, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name == "WallLeft")
        {
            GlobalData.RightScore++;
            GlobalData.LastWin = -1;
            ResetBall();
            return;
        }
        if (collision.name == "WallRight")
        {
            GlobalData.LeftScore++;
            GlobalData.LastWin = 1;
            ResetBall();
            return;
        }
    }
}
