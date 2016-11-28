using UnityEngine;
using System.Collections;


public class DeathCount : MonoBehaviour {


	private int howManyShouldKill;
	private int howManyIsKilled;

	public void  AddOneDeath () {
		Debug.Log (" added  -" + (howManyShouldKill - howManyIsKilled));
		howManyIsKilled ++ ;
	}

	void Start () {
		//2do remove 1 !
		howManyShouldKill = 1;
		//howManyShouldKill = Random.Range (5,20);
		howManyIsKilled = 0;
	}
	

	public bool getDeathStatus(){
		if (howManyIsKilled >= howManyShouldKill) {
			return true;
		}
		return false;
	}

}
