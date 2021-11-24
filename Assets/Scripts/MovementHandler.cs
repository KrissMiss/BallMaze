using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementHandler : MonoBehaviour
{
    public InputHandler inputHandler;
    public float speed = 1;

    private void Start()
    {
        Time.timeScale = 1;
    }

    private void MoveBall()
    {
        if (inputHandler.IsThereTouchInput())
        {
            Vector2 currPos = inputHandler.GetTouchDeltaPosition();
            currPos *= speed;
            Vector3 gravityPos = new Vector3(currPos.y * -1, Physics.gravity.y, currPos.x);
            Physics.gravity = gravityPos;
        }
    }

    // Update is called once per frame
    void Update()
    {
        MoveBall();
    }
}
