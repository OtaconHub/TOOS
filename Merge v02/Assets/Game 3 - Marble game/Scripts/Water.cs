using UnityEngine;
using System.Collections;

public class Water : MonoBehaviour {

    public static float WaterLife;
	public float PowerReductionSpeed =3.0f;
    public static GameObject WaterPowerOB;
    public GameObject Player;
	
	void Awake()
	{
	}

	// Use this for initialization
	void Start () {
        WaterPowerOB = GameObject.FindWithTag("WP");
        Player = GameObject.FindWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {

        if (HUD.HasWater && WaterLife>0)
        {
            WaterLife = WaterLife - (PowerReductionSpeed * Time.deltaTime);
            WaterPowerOB.SetActiveRecursively(true);
            WaterPowerOB.active = true;
            Player.renderer.material.color = Color.blue;
            Debug.Log("Water Power Started");
        }
        else if (WaterLife < 0)
        {
            WaterPowerOB.SetActiveRecursively(false);
            WaterPowerOB.active = false;
            HUD.HasWater = false;
            Player.renderer.material.color = Color.black;
            Debug.Log("Water Power Ended");
        }
	}
}
