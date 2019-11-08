using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObstacle2 : MonoBehaviour
{
    public Vector3 startPosition;
    public float start;
    public float end;
    public bool up = true;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        start = startPosition.y;

        end = startPosition.y + 7f;
    }
    // Update is called once per frame
    void Update()
    {
        //if statement to move the obstacle up and down in rapid succession.
        if (transform.position.y > end)
        {
            up = false;
        }else if(transform.position.y < start)
        {
            up = true;
        }
        if (up)
        {
            transform.Translate(0, Time.deltaTime * 100f, 0);
        }
        else
        {
            transform.Translate(0, Time.deltaTime * -100f, 0);
        }
    }
}
