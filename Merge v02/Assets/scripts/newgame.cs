using UnityEngine;
using System.Collections;

public class newgame : MonoBehaviour
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
		Application.LoadLevel(2);
		audio.PlayOneShot(audio.clip);
	}
	
}
