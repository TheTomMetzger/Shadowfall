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


    // Use this for initialization
    void Start () {
        body = GetComponent<Rigidbody>();
        currentCoordinates = 1;
    }

    // Update is called once per frame
    void Update () {
        if (Mathf.Abs(body.position.x - firstCoordinates.x) < .1 && Mathf.Abs(body.position.z - firstCoordinates.z) < .1 && currentCoordinates == 1){
            currentCoordinates = 2;
        }
        else if (Mathf.Abs(body.position.x - secondCoordinates.x) < .1 && Mathf.Abs(body.position.z - secondCoordinates.z) < .1 && currentCoordinates == 2){
            currentCoordinates = 3;
        }
        else if (Mathf.Abs(body.position.x - thirdCoordinates.x) < .1 && Mathf.Abs(body.position.z - thirdCoordinates.z) < .1 && currentCoordinates == 3){
            currentCoordinates = 4;
        }
        else if (Mathf.Abs(body.position.x - fourthCoordinates.x) < .1 && Mathf.Abs(body.position.z - fourthCoordinates.z) < .1 && currentCoordinates == 4){
            currentCoordinates = 1;
        }

        if (currentCoordinates == 1){
            body.position = Vector3.Lerp(body.position, firstCoordinates, .05f);
        }
        if (currentCoordinates == 2){
            body.position = Vector3.Lerp(body.position, secondCoordinates, .05f);
        }
        if (currentCoordinates == 3){
            body.position = Vector3.Lerp(body.position, thirdCoordinates, .05f);
        }
        if (currentCoordinates == 4){
            body.position = Vector3.Lerp(body.position, fourthCoordinates, .05f);
        }
    }

}
