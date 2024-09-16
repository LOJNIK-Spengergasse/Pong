using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRacket : MonoBehaviour
{
    [SerializeField]
    private KeyCode inputUp;
    [SerializeField]
    private KeyCode inputDown;

    private bool _moveUp;
    private bool _moveDown;

    [SerializeField]
    private float _moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(inputUp)) _moveUp = true;
        if (Input.GetKey(inputDown)) _moveDown = true;
    }

    // Called after Update has finished
    void LateUpdate()
    {
        
    }

    //For physics, own updatetime, not dependant on Framerate
    void FixedUpdate()
    {
        if(_moveUp)
        {
            transform.Translate(new Vector2(0.0f, _moveSpeed));
            _moveUp = false;
        }
        if (_moveDown)
        {
            transform.Translate(new Vector2(0.0f, -_moveSpeed));
            _moveDown = false;
        }
    }
}
