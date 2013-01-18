
var damageTimer = 0.0;


function DoDamage()
{
	if(damageTimer==0.0)
	{
		damageTimer = Time.time;
	}
	if((damageTimer+0.05) > Time.time)
	{
		return;
	}
	else
	{
		Player.HEALTH -= 1;
		print(Player.HEALTH);
		damageTimer = Time.time;
	}
}


function OnTriggerStay (other : Collider)
	{
	DoDamage();
	
	}