using UnityEngine;
using System.Collections;

public class WalkableWall : MonoBehaviour {

    public GameObject Player;
    private Vector3 myNromal,Normal;

	// Use this for initialization
	void Start () {
        myNromal = transform.right;
        Normal = transform.up;
        Player = GameObject.FindWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider collision)
    {
        Debug.Log("Collided");
        if (collision.gameObject.tag == "Player")
        {
            Player.rigidbody.AddForce(Vector3.left * -10);
        }
    }

    void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.tag == "Player" && HUD.HasSticky)
        {
            Player.rigidbody.AddForce(Vector3.up * 10);
        }

    }

    void OnTriggerExit(Collider collision)
    {
        Debug.Log("Collided Left");
        if (collision.gameObject.tag == "Player")
        {
            Player.rigidbody.AddForce(Vector3.down * 10);
        }
    }
}
