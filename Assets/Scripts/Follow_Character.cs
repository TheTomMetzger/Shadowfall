using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow_Character : MonoBehaviour
{

    private Rigidbody body;
    public Rigidbody player;
    public float speed;




    // Use this for initialization
    void Start () 
    {
        body = GetComponent<Rigidbody>();
    }




    // Update is called once per frame
    void Update () 
    {
        body.position = Vector3.Lerp(body.position, player.transform.position, speed);
    }
}
