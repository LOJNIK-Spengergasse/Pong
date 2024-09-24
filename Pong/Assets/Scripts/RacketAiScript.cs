using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class RacketAiScript : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    public Transform ball;

    private Rigidbody2D _rb;
    private MoveRacket racketMoveScript;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        racketMoveScript = _rb.GetComponent<MoveRacket>();
        racketMoveScript.enabled = !GlobalData.isAI;
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void FixedUpdate()
    {
        if (GlobalData.isAI)
        {
            float yPos = ball.position.y + Random.Range(-GlobalData.AIerrorRange, GlobalData.AIerrorRange);
            float yDistance = yPos - _rb.position.y;

            if (Mathf.Abs(yDistance) > 0.001f)
            {
                // Apply force to move towards the target position
                _rb.AddForce(new Vector2(0, yDistance * speed));
            }
            else
            {
                // Optionally, set the velocity to zero if close enough to stop
                _rb.velocity = new Vector2(_rb.velocity.x, 0);
            }
        }   
    }
}
