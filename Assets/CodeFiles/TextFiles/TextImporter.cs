using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;



public class TextImporter : MonoBehaviour {

	public TextAsset textFile;
	public String[] textLines;


	// Use this for initialization
	void Start () {
		if (textFile != null) {
			Debug.Log (" file is found !");
			textLines = (textFile.text.Split ('\n'));
		}   

	}
	public  IList<String> getText () {
		IList<String> constArr = Array.AsReadOnly (textLines);
		Debug.Log (" Show " + textLines [0]);
		return constArr;
	}

}
