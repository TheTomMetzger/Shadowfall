using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow_Character : MonoBehaviour {

    public float speed;
    private Rigidbody2D body;
    public GameObject player;

	// Use this for initialization
	void Start () {
        body = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        float angle = Mathf.Tan(player.transform.position.y / player.transform.position.x);
        Vector2 movement = new Vector2(angle * (player.transform.position.x - body.position.x), angle * (player.transform.position.y - body.position.y));
		body.MovePosition(body.position + (movement * speed));
    }
}
