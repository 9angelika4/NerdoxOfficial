using UnityEngine;
using System.Collections;

public class LastScene : MonoBehaviour {

	private AudioSource audioSource;
	public AudioClip music;
	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource> ();
		audioSource.PlayOneShot (music);
		Destroy (GameObject.FindGameObjectWithTag ("Player"));
		Destroy (GameObject.FindGameObjectWithTag ("UI"));
	}
	
	public void ExitGame(){
		Application.Quit ();
	}
}
