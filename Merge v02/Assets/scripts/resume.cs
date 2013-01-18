using UnityEngine;
using System.Collections;

public class resume : MonoBehaviour {
public AudioSource sound;	
	// Use this for initialization
		void OnMouseEnter()
	{
		renderer.material.color = Color.white;
	}
	void OnMouseExit()
	{
		renderer.material.color = Color.black;
	}

		void OnMouseDown () 
	{
	
 		renderer.material.color = Color.yellow;
		Application.LoadLevel(3);	
		audio.PlayOneShot(audio.clip);
	}
	// Update is called once per frame
	void Update ()
	{
	
	}
}
