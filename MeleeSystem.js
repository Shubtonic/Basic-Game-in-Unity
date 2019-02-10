#pragma strict

var TheDamage : int = 25; 
var Distance : float;
var MaxDistance : float = 1.5;
var TheMace : Transform;

function Update() {
  if (Input.GetButtonDown("Fire1"))
  {  
     TheMace.GetComponent.<Animation>().Play("AttackAnimation001");
     var hit : RaycastHit;                 
     if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), hit))
	 {
	  Distance = hit.distance;
	  if (Distance < MaxDistance)
	  {

	   hit.transform.SendMessage("ApplyDamage", TheDamage, SendMessageOptions.DontRequireReceiver);
	  }
	 }
  } 
   if (TheMace.GetComponent.<Animation>().isPlaying == false)
   { 
    TheMace.GetComponent.<Animation>().CrossFade("idle"); 
   }
	
   if (Input.GetKey (KeyCode.LeftShift)) 
   { 
    TheMace.GetComponent.<Animation>().CrossFade("HumanoidRun"); 
   } 
   
   if (Input.GetKeyUp(KeyCode.LeftShift)) 
   { 
    TheMace.GetComponent.<Animation>().CrossFade("HumanoidRun"); 
   }

  }