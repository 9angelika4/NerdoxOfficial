using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;



public class TextImporter : MonoBehaviour {

	public TextAsset textFile;
	public String[] textLines;


	// Use this for initialization
	void Awake () {
		if (textFile != null) {
			textLines = (textFile.text.Split ('\n'));
		}  

	}
	public void Initialize(){
		if (textFile != null) {
			textLines = (textFile.text.Split ('\n'));
		}   
	}
	public  IList<String> getText () {
		IList<String> constArr = Array.AsReadOnly (textLines);
		return constArr;
	}

}
