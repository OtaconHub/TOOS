using UnityEngine;
using System.Collections;

public class CoinGameManager : MonoBehaviour
{
    public static CoinGameManager SP;
	
    public static int totalGems;
    public static int foundGems;


    void Awake()
    {
        SP = this; 
        foundGems = 0;
        totalGems = GameObject.FindGameObjectsWithTag("Coins").Length;
        Time.timeScale = 1.0f;
    }

	void OnGUI () {
	    GUILayout.Label(" Found gems: "+foundGems+"/"+totalGems );
	}

    public void FoundGem()
    {
        foundGems++;
    }
	
	void Update()
	{
		//staticText.text = "Unity is totally awesome";
	}
}
