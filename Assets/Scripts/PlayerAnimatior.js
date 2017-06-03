#pragma strict
var  comecar = false;
var animator : Animator; 
var gravidade = -50.0;


function Start () {
animator = GetComponent(Animator); 
	
}

function Update () {
   Physics.gravity = Vector3(0,gravidade,0);
	
	if (Input.GetKeyDown("s")){
	 comecar = true;
	} 
	if (comecar ==true){
	 animator.SetFloat("Correr",1.0);
	} 
	 

}
