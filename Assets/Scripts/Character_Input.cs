using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Input : MonoBehaviour {

    public float speed;
    private Rigidbody body;

    // Use this for initialization
    void Start () {
        body = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        float moveH = Input.GetAxis("Horizontal");
        float moveV = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveH, 0, moveV);

        body.MovePosition(body.position + (movement * speed));
	}


    void OnTriggerEnter(Collider collider)
    {
        print("Collision!!!");
        print(collider.gameObject.tag);
    }
}
