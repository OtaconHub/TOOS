using UnityEngine;
using System.Collections;

public class Electri : MonoBehaviour {

    public static float ElectriLife ;
    public float PowerReductionSpeed = 3.0f;
    public static GameObject ElectriPowerOB;
    public GameObject Player;

    void Awake()
    {
    }

    // Use this for initialization
    void Start()
    {
        ElectriPowerOB = GameObject.FindWithTag("EP");
        Player = GameObject.FindWithTag("Player");

    }
    // Update is called once per frame
    void Update()
    {

        if (HUD.HasElectri && ElectriLife > 0)
        {
            ElectriLife = ElectriLife - (PowerReductionSpeed * Time.deltaTime);
            ElectriPowerOB.SetActiveRecursively(true);
            ElectriPowerOB.active = true;
            Player.renderer.material.color = Color.blue;
            Debug.Log("Electri Power Started");
        }
        else if (ElectriLife < 0)
        {
            ElectriPowerOB.SetActiveRecursively(false);
            ElectriPowerOB.active = false;
            HUD.HasElectri = false;
            Player.renderer.material.color = Color.black;
            Debug.Log("Electri Power Ended");
        }
    }
}
