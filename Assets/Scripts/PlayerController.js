/// This script moves the character controller forward
    /// and sideways based on the arrow keys.
    /// It also jumps when pressing space.
    /// Make sure to attach a character controller to the same game object.
    /// It is recommended that you make only one call to Move or SimpleMove per frame.

    var speed : float = 6.0;
    var jumpSpeed : float = 8.0;
    var gravity : float = 20.0;
	var Alvo : Transform;
	// posicao do alvo
	static var AlvoPZ = 0.0;
	static var AlvoPY = 0.0;
    private var moveDirection : Vector3 = Vector3.zero;
    var posx=0;
    var posy=0;
    var posy=0;
    function Update() {
	if (morte_queda==true){
	transform.position.x=posx;
	transform.position.y=posy;
	transform.position.z=posz;
	}
	 transform.LookAt(Alvo);
	 AlvoPZ = transform.position.z;
	 AlvoPY = transform.position.y;
        var controller : CharacterController = GetComponent.<CharacterController>();
        if (controller.isGrounded) {
            // We are grounded, so recalculate
            // move direction directly from axes
            moveDirection = Vector3(0,0,0);
                                    
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;

			/*
            if (Input.GetButton ("Jump")) {
                moveDirection.y = jumpSpeed;
            }*/

        }

        // Apply gravity
        moveDirection.y -= gravity * Time.deltaTime;

        // Move the controller
        controller.Move(moveDirection * Time.deltaTime);
    } 