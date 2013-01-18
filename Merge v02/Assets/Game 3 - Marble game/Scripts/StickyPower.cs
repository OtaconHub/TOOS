using UnityEngine;
using System.Collections;

public class StickyPower : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log("Sticky Power Active");
	}

    /*
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "SmallCube")
        {
            Debug.Log("Collided with small Objects");
            other.gameObject.transform.parent = GameObject.FindGameObjectWithTag("Player").transform;
            gameObject.collider.enabled = false;
        }
    }
     * */
}
