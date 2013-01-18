//The script starts from here

var h10 : Texture2D;
var h20 : Texture2D;
var h30 : Texture2D;
var h40 : Texture2D;
var h50 : Texture2D;
var h60 : Texture2D;
var h70 : Texture2D;
var h80 : Texture2D;
var h90 : Texture2D;
var h100 : Texture2D;
var h110 : Texture2D;
var h120 : Texture2D;
var h130 : Texture2D;

var damage = 10;
var wait_time = 2;
var lock = 0;



static var HEALTH = 130;

  function OnCollisionEnter(hit: Collision)
  {
        if(hit.gameObject.tag == "enemy" && lock == 0)
        {
           DecreasingHealth();
        }
 else if(hit.gameObject.tag == "sablon")
        {
          HEALTH=HEALTH+damage;
        Destroy(hit.gameObject);
        }
  }
 
    function DecreasingHealth()
    {
        lock=1;
        HEALTH=HEALTH-damage;
        yield WaitForSeconds(wait_time);
        lock=0;
    }

    function Update()
    {
    	var Health = gameObject.Find("Health");
    	
	if (HEALTH > 130)
	{
	HEALTH = 130;
	}
	
	else if(HEALTH > 120)
	{
		Health.guiTexture.texture = h130;
		return;
	}
	else if (HEALTH > 110)
	{
		Health.guiTexture.texture = h120;
		return;		
	}
	else if (HEALTH > 100)
	{
		Health.guiTexture.texture = h110;
		return;		
	}
	else if (HEALTH > 90)
	{
		Health.guiTexture.texture = h100;
		return;		
	}
	else if (HEALTH > 80)
	{
		Health.guiTexture.texture = h90;
		return;		
	}
	else if (HEALTH > 70)
	{
		Health.guiTexture.texture = h80;
		return;		
	}
	else if (HEALTH > 60)
	{
		Health.guiTexture.texture = h70;
		return;		
	}
		else if (HEALTH > 50)
	{
		Health.guiTexture.texture = h60;
		return;		
	}
	else if (HEALTH > 40)
	{
		Health.guiTexture.texture = h50;
		return;		
	}
	else if (HEALTH > 30)
	{
		Health.guiTexture.texture = h40;
		return;		
	}
	else if (HEALTH > 20)
	{
		Health.guiTexture.texture = h30;
		return;		
	}
	else if (HEALTH > 10)
	{
		Health.guiTexture.texture = h20;
		return;		
	}
	
	else if (HEALTH > 0)
	{
		Health.guiTexture.texture = h10;
		return;		
	}
	
     else if(HEALTH == 0)
         {
Application.LoadLevel(3);
    }
}
