using UnityEngine;
using System.Collections;

public class HUD : MonoBehaviour {

    public static bool HasAir,HasSticky,HasFire,HasElectri,HasWater;

    void OnGUI()
    {
        
        if (HasAir)
        {
            GUI.Label(new Rect(10,10,80,30),"Air");
            GUI.Label(new Rect(70, 10, 80, 30), Air.AirLife.ToString("F2"));
            GUI.Label(new Rect(10, 40, 80, 30), "Air Mode");
        }

        if (HasSticky)
        {
            GUI.Label(new Rect(10, 10, 80, 30), "Sitcky");
            GUI.Label(new Rect(70, 10, 80, 30), Sticky.StickyLife.ToString("F2"));
            GUI.Label(new Rect(10, 40, 80, 30), "Sticky Mode");
        }

        if (HasFire)
        {
            GUI.Label(new Rect(10, 10, 80, 30), "Fire");
            GUI.Label(new Rect(70, 10, 80, 30), Fire.FireLife.ToString("F2"));
            GUI.Label(new Rect(10, 40, 80, 30), "Fire Mode");
        }

        if (HasElectri)
        {
            GUI.Label(new Rect(10, 10, 80, 30), "Electricity");
            GUI.Label(new Rect(70, 10, 80, 30), Electri.ElectriLife.ToString("F2"));
            GUI.Label(new Rect(10, 40, 80, 30), "Electricity Mode");
        }
        
        if (HasWater)
        {
            GUI.Label(new Rect(10, 10, 80, 30), "Water");
            GUI.Label(new Rect(70, 10, 80, 30), Water.WaterLife.ToString("F2"));
            GUI.Label(new Rect(10, 40, 80, 30), "Water Mode");
        }
        if (HasSticky)
        {
            GUI.Label(new Rect(10, 10, 80, 30), "Sticky");
            GUI.Label(new Rect(70,10,80,30),Sticky.StickyLife.ToString("F2"));
            GUI.Label(new Rect(10, 40, 80, 30), "Sticky Mode");
        }


    }

    /*
    void Update()
    {
        Debug.Log("Water State =" + HasWater);
        Debug.Log("Fire State =" + HasFire);
        Debug.Log("Electri State =" + HasElectri);
        Debug.Log("Air State =" + HasAir);
        Debug.Log("Sticky State =" + HasSticky);
    }
     * */
}
