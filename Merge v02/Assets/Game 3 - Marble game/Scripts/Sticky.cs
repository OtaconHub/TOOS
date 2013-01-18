using UnityEngine;
using System.Collections;

public class Sticky : MonoBehaviour {

    public static float StickyLife = 100;
    //public Light Headlight;
    public float PowerReductionSpeed = 3.0f;
    public static GameObject StickyPowerOB;
    public GameObject Player;
    void Awake()
    {
    }

    // Use this for initialization
    void Start()
    {
        StickyPowerOB = GameObject.FindWithTag("SP");
        Player = GameObject.FindWithTag("Player");
    }
    // Update is called once per frame
    void Update()
    {

        if (HUD.HasSticky && StickyLife > 0)
        {
            StickyLife = StickyLife - (PowerReductionSpeed * Time.deltaTime);
            StickyPowerOB.SetActiveRecursively(true);
            StickyPowerOB.active = true;
            Player.renderer.material.color = Color.blue;
            Debug.Log("Sticky Power Started");
        }
        else if (StickyLife < 0)
        {
            StickyPowerOB.SetActiveRecursively(false);
            StickyPowerOB.active = false;
            HUD.HasSticky = false;
            Player.renderer.material.color = Color.black;
            Debug.Log("Sticky Power Ended");
        }
    }
}
