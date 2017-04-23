using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolGhost : MonoBehaviour 
{
    private Rigidbody body;
    public Vector3 firstCoordinates;
    public Vector3 secondCoordinates;
    public Vector3 thirdCoordinates;
    public Vector3 fourthCoordinates;
    private int currentCoordinates;
    public float speed;


    // Use this for initialization
    void Start () {
        body = GetComponent<Rigidbody>();
        currentCoordinates = 1;
    }

    // Update is called once per frame
    void Update () {
        if (Mathf.Abs(body.position.x - firstCoordinates.x) < .2 && Mathf.Abs(body.position.z - firstCoordinates.z) < .2 && currentCoordinates == 1){
            currentCoordinates = 2;
        }
        else if (Mathf.Abs(body.position.x - secondCoordinates.x) < .2 && Mathf.Abs(body.position.z - secondCoordinates.z) < .2 && currentCoordinates == 2){
            currentCoordinates = 3;
        }
        else if (Mathf.Abs(body.position.x - thirdCoordinates.x) < .2 && Mathf.Abs(body.position.z - thirdCoordinates.z) < .2 && currentCoordinates == 3){
            currentCoordinates = 4;
        }
        else if (Mathf.Abs(body.position.x - fourthCoordinates.x) < .2 && Mathf.Abs(body.position.z - fourthCoordinates.z) < .2 && currentCoordinates == 4){
            currentCoordinates = 1;
        }

        if (currentCoordinates == 1){
            body.position = Vector3.Lerp(body.position, firstCoordinates, speed);
        }
        if (currentCoordinates == 2){
            body.position = Vector3.Lerp(body.position, secondCoordinates, speed);
        }
        if (currentCoordinates == 3){
            body.position = Vector3.Lerp(body.position, thirdCoordinates, speed);
        }
        if (currentCoordinates == 4){
            body.position = Vector3.Lerp(body.position, fourthCoordinates, speed);
        }
    }

}
