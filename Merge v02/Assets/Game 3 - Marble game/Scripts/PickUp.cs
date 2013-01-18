using UnityEngine;
using System.Collections;

public class PickUp : MonoBehaviour {

    public enum Item
    {
        Air, 
        Sticky, 
        Fire, 
        Electri, 
        Water
    }


    public Item item;

    void OnTriggerEnter()
    {
        if (item == Item.Water)
        {
            Water.WaterLife = 100;
            HUD.HasWater = true; //enables Water HUD
            HUD.HasAir = false;
            HUD.HasSticky = false;
            HUD.HasFire = false;
            HUD.HasElectri = false;
        }
        else if (item == Item.Sticky)
        {
            Sticky.StickyLife = 100;
            HUD.HasWater = false; ; //enables Water HUD
            HUD.HasAir = false;
            HUD.HasSticky = true;
            HUD.HasFire = false;
            HUD.HasElectri = false;
        }
        else if (item == Item.Fire)
        {
            Fire.FireLife = 100;
            HUD.HasWater = false; //enables Water HUD
            HUD.HasAir = false;
            HUD.HasSticky = false;
            HUD.HasFire = true;
            HUD.HasElectri = false;
        }
        else if (item == Item.Electri)
        {
            Electri.ElectriLife= 100;
            HUD.HasWater = false; //enables Water HUD
            HUD.HasAir = false;
            HUD.HasSticky = false;
            HUD.HasFire = false;
            HUD.HasElectri = true;
        }
        else if (item == Item.Air)
        {
            Air.AirLife = 100;
            HUD.HasWater = false; //enables Water HUD
            HUD.HasAir = true;
            HUD.HasSticky = false;
            HUD.HasFire = false;
            HUD.HasElectri = false;
        }

      //  Destroy(gameObject);
    }
}
