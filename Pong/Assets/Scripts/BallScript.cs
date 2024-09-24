using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    [SerializeField]
    public GameManager gameManager;

    [SerializeField]
    private float _speed;
    private Rigidbody2D _rb;
    private AudioSource _audio;
    [SerializeField]
    private AudioClip hitSound;
    [SerializeField]
    private AudioClip lostSound;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _audio = GetComponent<AudioSource>();
        gameManager.ResetGame(_speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Audio Handler
        GetComponent<AudioSource>().clip = hitSound;
        GetComponent<AudioSource>().Play();
        //Score Handler
        if(collision.name == "WallLeft")
        {
            gameManager.RightScore();
            gameManager.ResetGame(_speed);
            return;
        }
        if (collision.name == "WallRight")
        {
            gameManager.LeftScore();
            gameManager.ResetGame(_speed);
            return;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //audioHandling
        GetComponent<AudioSource>().clip = hitSound;
        GetComponent<AudioSource>().Play();
        //speed Handling
        _rb.velocity=Vector2.ClampMagnitude(_rb.velocity, 20f);
        //Velocity Handling
        if (collision.collider.name == "RacketLeft" || collision.collider.name == "RacketRight")
        {
            Vector2 hitpoint = collision.contacts[0].point;
            Vector2 racketYpos = collision.collider.bounds.center;
            _rb.velocity = _rb.velocity + (hitpoint - racketYpos) * 2; //*2 for better angles
        }
    }

}
