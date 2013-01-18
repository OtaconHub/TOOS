using UnityEngine;
using System.Collections;

public class upgrademenu : MonoBehaviour {
public AudioSource sound;
public Texture2D change;
public Texture2D normal;

	void OnMouseEnter()
{
    this.guiTexture.texture = change;
}
	
void OnMouseExit()
{
    this.guiTexture.texture = normal;
}
	void OnMouseDown() 
	{
		Debug.Log("hhhh");
 		Application.LoadLevel(7);	
		audio.PlayOneShot(audio.clip);
	}
	
	void Update ()
	{
		
	}
}
