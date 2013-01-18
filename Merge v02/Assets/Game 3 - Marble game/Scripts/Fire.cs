using UnityEngine;
using System.Collections;

public class Fire : MonoBehaviour {

    public static float FireLife;
    public float PowerReductionSpeed = 3.0f;
    public static GameObject FirePowerOB;
    public GameObject Player;

    void Awake()
    {
    }

    // Use this for initialization
    void Start()
    {
        FirePowerOB = GameObject.FindWithTag("FP");
        Player = GameObject.FindWithTag("Player");
    }
    // Update is called once per frame
    void Update()
    {

        if (HUD.HasFire && FireLife > 0)
        {
            FireLife = FireLife - (PowerReductionSpeed * Time.deltaTime);
            FirePowerOB.SetActiveRecursively(true);
            FirePowerOB.active = true;
            Player.renderer.material.color = Color.blue;
            Debug.Log("Fire Power Started");
        }
        else if (FireLife < 0)
        {
            FirePowerOB.SetActiveRecursively(false);
            FirePowerOB.active = false;
            HUD.HasFire = false;
            Player.renderer.material.color = Color.black;
            Debug.Log("Fire Power Ended");
        }
    }
}
