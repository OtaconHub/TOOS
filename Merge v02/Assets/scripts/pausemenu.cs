using UnityEngine;
using System.Collections;

public class pausemenu : MonoBehaviour {
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
	
 		Application.LoadLevel(6);	
	audio.PlayOneShot(audio.clip);
	}
	// Update is called once per frame
	void Update ()
	{
	
	}
}
