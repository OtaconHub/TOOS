using UnityEngine;
using System.Collections;

public class Gotomain : MonoBehaviour {
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
		Application.LoadLevel(1);
		audio.PlayOneShot(audio.clip);
	}
}
