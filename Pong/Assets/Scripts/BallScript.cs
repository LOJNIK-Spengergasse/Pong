using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    private Rigidbody2D _rb;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rb.position = new Vector3(0f,0f,0f);
        //x-Range: -2.5 - 2.5 y-Range: -2 - 2
        _rb.velocity = new Vector2(5 * Random.value - 2.5f, 4 * Random.value - 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name == "WallLeft")
        {
            GlobalData.RightScore++;
            Start();
            return;
        }
        if (collision.name == "WallRight")
        {
            GlobalData.LeftScore++;
            Start();
            return;
        }
    }
}
