using UnityEngine;
using System.Collections;

public class options : MonoBehaviour
{
	public AudioSource sound;
		
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
		Application.LoadLevel(4);
		audio.PlayOneShot(audio.clip);
	}
	
}
