using UnityEngine;
using System.Collections;

public class SandAnimation : MonoBehaviour
{
    public GameObject ClickHere;
	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
    void Update()
    {
        Debug.Log("START");
        if (gameObject.animation.isPlaying == false)
        {
            Debug.Log("IN LOOP FIN");
            GameObject.Find("Clickhere").GetComponent<MeshRenderer>().enabled = true;
            //ClickHere = gameObject.GetComponent<MeshRenderer>();
           // ClickHere.renderer = true;
           // ClickHere = GameObject.FindWithTag("ClickHere");
           // ClickHere.GetComponent("MeshRenderer").enabled = true;
            GameObject.Find("Star004").GetComponent<Transform>().Rotate(new Vector3(0, 0, 1));
            GameObject.Find("Star005").GetComponent<Transform>().Rotate(new Vector3(0, 0, 1));
            GameObject.Find("Star006").GetComponent<Transform>().Rotate(new Vector3(0, 0, 1));
        }
    }
}
