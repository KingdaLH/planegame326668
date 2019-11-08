using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObstacle1 : MonoBehaviour
{
    public float rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        //rotates the obstacle
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
