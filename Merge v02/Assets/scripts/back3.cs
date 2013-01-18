using UnityEngine;
using System.Collections;

public class back3 : MonoBehaviour {
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
		Application.LoadLevel (3);
		audio.PlayOneShot(audio.clip);
		}
		
}