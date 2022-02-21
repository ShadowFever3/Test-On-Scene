using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleBackAndForth : MonoBehaviour
{
    [SerializeField]
    float leftSide, rightSide;

    bool direction;
    private void FixedUpdate()
    {
        if(transform.position.x < leftSide || transform.position.x > rightSide)
        {
            Score.scoreValue += 1;
            direction = !direction;
            
        }

        if (direction)
        {
            transform.Translate(new Vector2(.2f, 0));
        }
        else
        {
            transform.Translate(new Vector2(-.2f, 0));
        }
    }
}
