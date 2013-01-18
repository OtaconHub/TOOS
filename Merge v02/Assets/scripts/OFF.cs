using UnityEngine;
using System.Collections;

public class OFF : MonoBehaviour 

{
		
	void OnMouseDown()
	{
		AudioListener.volume=0;
	}
	void Update()
	{
		if(AudioListener.volume!=0)
			renderer.material.color = Color.white;
		else
			renderer.material.color = Color.yellow;
	}
}
