using UnityEngine;
using System.Collections;

public class backbutton2 : MonoBehaviour 
	// Use this for initialization
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
		Application.LoadLevel (6);
		audio.PlayOneShot(audio.clip);
		}
		
}

	
