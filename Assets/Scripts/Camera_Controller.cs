using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Controller : MonoBehaviour {

    public GameObject player;

	// Use this for initialization
	void Start () {
        transform.position = new Vector3(player.transform.position.x, this.transform.position.y, player.transform.position.z);
	}
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = new Vector3(player.transform.position.x, this.transform.position.y, player.transform.position.z);
    }
}
