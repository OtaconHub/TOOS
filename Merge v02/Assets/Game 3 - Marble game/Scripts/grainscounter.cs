using UnityEngine;
using System.Collections;

public class grainscounter : MonoBehaviour {


    public static grainscounter SP;
	
    public static int totalGems;
    public static int foundGems;


    void Awake()
    {
        SP = this; 
        foundGems = 0;
        totalGems = GameObject.FindGameObjectsWithTag("Coins").Length;
        Time.timeScale = 1.0f;
    }

   public void FoundGem()
    {
        foundGems++;
    }
	
	void Update()
	{
		guiText.text = (""+foundGems+"/"+totalGems );
		
	}
}
