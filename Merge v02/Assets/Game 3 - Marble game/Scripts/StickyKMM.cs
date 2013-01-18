using UnityEngine;
using System.Collections;

public class StickyKMM : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (!HUD.HasSticky)
        {
            transform.parent = this.gameObject.transform.parent;
            rigidbody.useGravity = true;
            rigidbody.isKinematic = false;
            gameObject.collider.enabled = true;
        }
	}

    void OnCollisionEnter(Collision other)
    {
        if (HUD.HasSticky )
        {
            rigidbody.isKinematic = true;
            rigidbody.useGravity = false;
            transform.parent = GameObject.FindGameObjectWithTag("Player").transform;
            gameObject.collider.enabled = false;
        }

    }
}
