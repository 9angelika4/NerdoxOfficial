/*Player controller class*/
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {


	public CharacterController characterControler;
	private ManaController mana;

	private float  mouseLR;
	public float walkSpeed = 5.0f;
	public float runSpeed = 10.0f;
	public float jumpHeight = 7.0f;
	public float actualJumpPosition = 0f;
	public float mouseSensitivity = 3.0f;	
	public float mouseUpDown = 0.0f;
	public float mouseRangeUpDown = 90.0f;
	public bool isRunning;
	public float actualSpeed = 0f;
	private bool canMove = false;

	private float moveFB;
	private float moveLR;
 
	public void SetLockMovementStatus(bool newStatus) {
		this.canMove = newStatus;
	}


	private void Initialize () {
		mana = GetComponent<ManaController>();
		characterControler = GetComponent<CharacterController>();
		actualSpeed = walkSpeed;
	}
	private void Awake(){
		gameObject.SetActive (true);
	}
	private void Start () {
		
		Initialize();
	}
		
	void Update() {        
		 
			KeyController ();
			MouseControll ();
	 
	}
 
	private void KeyController(){
		FillMovesInformation ();
		JumpControll ();
		WalkControll ();
		MakeMove ();
	}

	private void FillMovesInformation(){
		moveFB = GetVerticalAxis() * actualSpeed;
		moveLR = GetHorizontalAxis () * actualSpeed;
	}
	private float GetHorizontalAxis (){
		return Input.GetAxis ("Horizontal");
	}

	private float GetVerticalAxis (){
		return Input.GetAxis ("Vertical");
	}

	private void JumpControll(){
		if(CheckIfCharacterCanJump()){
			actualJumpPosition = jumpHeight;
		} else if (CheckIfCharacterIsJumping() ){ 
			actualJumpPosition += Physics.gravity.y * Time.deltaTime;
		}
	}
	private bool CheckIfCharacterCanJump (){

		if (characterControler.isGrounded && Input.GetButton("Jump")) {
			return true;
		} 
		return false;
	}
	private bool CheckIfCharacterIsJumping(){
		if (!characterControler.isGrounded)
			return true;
		return false;
	}

	private void WalkControll(){
		 if(Input.GetKeyDown("left shift")  ) {
			Running ();
		} else if(Input.GetKeyUp("left shift")) {
			Walking ();
		}

		if ( isRunning    ) {
			actualSpeed = runSpeed;
		} else {
			actualSpeed = walkSpeed;
		} 
	}

	private void Running(){
		isRunning = true;
	}

	private void Walking(){
		isRunning = false;
	}

	private void MakeMove(){
		Vector3 move = new Vector3(moveLR, actualJumpPosition, moveFB);
		move = transform.rotation * move;
		characterControler.Move(move * Time.deltaTime);
	}

	private float GetMouseXAxis(){
		return  Input.GetAxis ("Mouse X");
	}
	private float GetMouseYAxis(){
		return Input.GetAxis ("Mouse Y");
	}

	private void MouseControll(){
		mouseLR = GetMouseXAxis () * mouseSensitivity;
		transform.Rotate (0, mouseLR, 0);
		mouseUpDown -= GetMouseYAxis ()* mouseSensitivity;
		mouseUpDown = Mathf.Clamp (mouseUpDown, -mouseRangeUpDown, mouseRangeUpDown);
		Camera.main.transform.localRotation = Quaternion.Euler (mouseUpDown, 0, 0);
	}
		
	private bool isDead(){
		Health health = gameObject.GetComponent<Health> ();
		if (health != null && !health.IsDead()) {
			return true;
		}
		return false;
	}

	public bool IsPlayerRunning(){
		return isRunning;
	}
	public bool IsPlayerWalking(){
		if (moveFB != 0 || moveLR != 0) {
			return true;
		}
		return false;
	}
}

