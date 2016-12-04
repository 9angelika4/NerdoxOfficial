using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.Collections.Generic;

public class TextManager : MonoBehaviour {

	public GameObject textPanel;
	public TextImporter textImporter;
	private Canvas dialogCanvas; 
	private Text textLine;
	private int currentLine;
	private int endAtLine;
	private IList<String> textLines;

	private TurnDownTextPanel turnDownDialog; 


	// Use this for initialization
	void Start () {

		currentLine = 0;
		dialogCanvas = GetComponent<Canvas> ();
		turnDownDialog = dialogCanvas.GetComponentInParent<TurnDownTextPanel> ();
		textLine = textPanel.GetComponentInChildren<Text> ();
		textLines = textImporter.getText ();
		if (endAtLine == 0) {
			endAtLine = textLines.Count;
		}

	}
	
	// Update is called once per frame
	void Update () {	
		
		textLine.text = textLines [currentLine];
		if(Input.GetKeyDown(KeyCode.LeftArrow)){
			moveBefore();
		}
		else if (Input.GetKeyDown(KeyCode.RightArrow)){
			moveNext ();
		}
	}

	private void moveNext () {

		if (currentLine < endAtLine) {
			currentLine++;
		}
		if (currentLine >= endAtLine) {
			turnDownDialog.turnDownPanel ();
			currentLine = 0;
		}
	}
	private void moveBefore () {
		if (currentLine - 1 >= 0) {
			currentLine--;
		}
	
	}
}
