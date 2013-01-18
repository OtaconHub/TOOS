using UnityEngine;
using System.Collections;

public class gotomainmenu : MonoBehaviour
{	
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
		Application.LoadLevel(1);
		}
		
}
