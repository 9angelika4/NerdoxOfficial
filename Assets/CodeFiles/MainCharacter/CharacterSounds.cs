using UnityEngine;
using System.Collections;

public class CharacterSounds : MonoBehaviour {


	private AudioSource audioSource;
	public AudioClip walk;
	public AudioClip jump;
	public AudioClip land;

	private const float stepTime =0.6f;
	private float countingToNextStep = 0.0f;
	public bool isGrounded;
	private PlayerController playerController;
	private CharacterController characterController;
	private bool playerOnTheGround;

	void Start () {
		audioSource = GetComponent<AudioSource> ();
		playerController = GetComponent<PlayerController> ();
		characterController = GetComponent<CharacterController> ();
	}
	
 	void Update () {
		if (audioSource != null) {
			WalkSounds ();
		}
	}

	private void WalkSounds(){
		CounterController ();
		PlayWalkSounds ();
		PlayJumpSounds ();
		PlayLandSounds ();
		playerOnTheGround = characterController.isGrounded;
	}

	private void CounterController () {
		
		if (countingToNextStep > 0) {
			if (playerController.IsPlayerRunning ()) {
				countingToNextStep -= Time.deltaTime * 1.5f;
			} 
			else {
				countingToNextStep -= Time.deltaTime;
			}
		}
	}
	private void PlayWalkSounds(){
		if (playerController.IsPlayerWalking () && characterController.isGrounded && countingToNextStep <= 0) {
			countingToNextStep = stepTime;
			audioSource.PlayOneShot (walk);
		}
	}
	private void PlayJumpSounds(){
		if (Input.GetButton("Jump")  && characterController.isGrounded) {
			audioSource.PlayOneShot (jump);
		}
	}
	private void PlayLandSounds(){
		if (!playerOnTheGround  && characterController.isGrounded) {
			audioSource.PlayOneShot (land);
		}
	}
}
