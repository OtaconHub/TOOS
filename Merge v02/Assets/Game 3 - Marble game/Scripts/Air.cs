using UnityEngine;
using System.Collections;

public class Air : MonoBehaviour
{
    public static float AirLife ;
    public float PowerReductionSpeed = 3.0f;
    public static GameObject AirPowerOB;
    public GameObject Player;

    void Awake()
    {
    }

    // Use this for initialization
    void Start()
    {
        AirPowerOB = GameObject.FindWithTag("AP");
        Player = GameObject.FindWithTag("Player");
    }
    // Update is called once per frame
    void Update()
    {

        if (HUD.HasAir && AirLife > 0)
        {
            AirLife = AirLife - (PowerReductionSpeed * Time.deltaTime);
            AirPowerOB.SetActiveRecursively(true);
            AirPowerOB.active = true;
            Player.renderer.material.color = Color.blue;
            Debug.Log("Air Power Started");
        }
        else if (AirLife < 0)
        {
            AirPowerOB.SetActiveRecursively(false);
            AirPowerOB.active = false;
            HUD.HasAir = false;
            Player.renderer.material.color = Color.black;
            Debug.Log("Air Power Ended");
        }
    }
}
