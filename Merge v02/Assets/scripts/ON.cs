using UnityEngine;
using System.Collections;

public class ON : MonoBehaviour 
{
	 void OnMouseDown()
	{
		AudioListener.volume=20;
		
	}
	void Update()
	{
		
		if(AudioListener.volume==0)
		{
			renderer.material.color = Color.white;
			
		}
		else
			renderer.material.color = Color.yellow;
	}
}
