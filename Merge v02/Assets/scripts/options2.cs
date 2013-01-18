using UnityEngine;
using System.Collections;

public class options2 : MonoBehaviour {
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
void OnMouseDown()
	{
		renderer.material.color = Color.yellow;
		//AudioListener.volume=20;
		Application.LoadLevel(8);
		audio.PlayOneShot(audio.clip);
	}
	
	
	// Update is called once per frame
	void Update () {
	
	}
}
