using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Input : MonoBehaviour {

    public float speed;
    private Rigidbody2D body;

    // Use this for initialization
    void Start () {
        body = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        float moveH = Input.GetAxis("Horizontal");
        float moveV = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveH, moveV);

        body.MovePosition(body.position + (movement * speed));
	}
}
