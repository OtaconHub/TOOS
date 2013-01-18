#pragma strict

var timer : float;
var WaitTime : float = 0.5;
var ResetPoint : float;

function Start () {

ResetPoint = WaitTime * 2;

}


function Update () {

timer += Time.deltaTime;

  if(timer < WaitTime)
  {
  guiTexture.color = Color.white;
  }

  if(timer > WaitTime)
  {
  guiTexture.color = Color.red;
  }

  if(timer > ResetPoint)
  {
  timer = 0;
  }

}