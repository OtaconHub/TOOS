using UnityEngine;
using System.Collections;

public class gameobject : MonoBehaviour {

	public Texture2D background;
	
	private void OnGUI()
	{
		if (background != null)
			GUI.DrawTexture(new Rect(0,0,Screen.width , Screen.height),background);
		
	}
}
