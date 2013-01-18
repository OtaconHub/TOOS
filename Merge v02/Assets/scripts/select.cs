using UnityEngine;
using System.Collections;

public class select : MonoBehaviour
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
		Application.LoadLevel(5);
		audio.PlayOneShot(audio.clip);
	}
	
}
