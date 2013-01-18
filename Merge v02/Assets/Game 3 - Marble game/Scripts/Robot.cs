using UnityEngine;
using System.Collections;

public class Robot : MonoBehaviour {

    public bool Yes;
	// Use this for initialization
	void Start () {


	
	}
	
	// Update is called once per frame
	void Update () {

        if (Yes)
        {
            this.rigidbody.AddForce(Vector3.right * 3);
        }
	}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            Yes = true;
        }
    }
}
