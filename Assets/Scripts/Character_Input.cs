using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;





public class Character_Input : MonoBehaviour 
{

    public float speed;
    private Rigidbody body;

    public bool lightsOn;

    public Camera camera;




    // Use this for initialization
    void Start () 
    {
        lightsOn = true;
        camera.cullingMask |= 1 << LayerMask.NameToLayer("Maze");

        camera.cullingMask &=  ~(1 << LayerMask.NameToLayer("Ghosts"));

        body = GetComponent<Rigidbody>();
	}
	



	// Update is called once per frame
	void Update () 
    {
        if (Input.GetKey (KeyCode.RightArrow) || Input.GetKey (KeyCode.D))
        {
            body.AddForce (Vector3.right * speed);
        }

        if (Input.GetKey (KeyCode.LeftArrow) || Input.GetKey (KeyCode.A))
        {
            body.AddForce (-Vector3.right * speed);
        }

        if (Input.GetKey (KeyCode.UpArrow) || Input.GetKey (KeyCode.W))
        {
            body.AddForce (Vector3.forward * speed);
        }

        if (Input.GetKey (KeyCode.DownArrow) || Input.GetKey (KeyCode.S))
        {
            body.AddForce (-Vector3.forward * speed);
        }

        if (Input.GetMouseButtonDown(0))
        {
            flipSwitch();   
        }
	}




    void flipSwitch()
    {
        if (lightsOn)
        {
            print("Lights Off!");

            lightsOn = false;

            camera.cullingMask &=  ~(1 << LayerMask.NameToLayer("Maze"));

            camera.cullingMask |= 1 << LayerMask.NameToLayer("Ghosts");
        }
        else
        {
            print("Lights On!");

            lightsOn = true;

            camera.cullingMask |= 1 << LayerMask.NameToLayer("Maze");

            camera.cullingMask &=  ~(1 << LayerMask.NameToLayer("Ghosts"));
        }
    }




    void OnTriggerEnter(Collider collider)
    {
        print("#TRIGGERED!!!");
        print(collider.gameObject.tag);

        if (collider.gameObject.name == "Door")
        {
            print("Door Reached! Going To Next Level...");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        if (collider.gameObject.tag == "Ghost")
        {
            print("Dead! Restarting Level...");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }




    void OnCollisionEnter(Collision collision)
    {
        print("Collision!!!");
    }
}
