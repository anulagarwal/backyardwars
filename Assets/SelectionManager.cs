using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectionManager : MonoBehaviour {
	[SerializeField]
	Image[] characters;

	int[] selectedChar;
	[SerializeField]
	GameManager gm;

	Character.type[] charType = new Character.type[3];
	int curSelected;

	int selectionCount;
	// Use this for initialization
	void Start () {

		selectedChar = new int[3];
		curSelected = 0;

		selectionCount = 0;
	}

	public void updateSelection(Character.type type,int id){
		
		print ("a");
		if (curSelected < 3) {
			charType[curSelected] = type;

			curSelected += 1;

			characters [id-1].color = Color.green;
			selectedChar [curSelected-1] = id;

		}

	}

	public void resetSelection(){
		curSelected = 0;
		for (int x = 0; x < 9; x++) {
			characters [x].color = Color.white;

		}
		selectedChar [0] = 0;
		selectedChar [1] = 0;
		selectedChar [2] = 0;


	}

	public void completeSelection(){
		int x = 0;
		if (gm.curPlayerNumber == 1) {

			while (x < 3) {
				print (x);
				gm.P1.character [x] = charType [x];
				gm.P1.characters [x] = gm.characters [x];
				x += 1;
			}
		}
		else if (gm.curPlayerNumber == 2) {

			while (x < 3) {
				print (x);
				gm.P2.character [x] = charType [x];
				gm.P2.characters [x] = gm.characters [x];
				x += 1;
			}
		}

		selectionCount += 1;


		if (selectionCount == 2) {

			gm.InitiateSetupSequence ();
			gm.isSelectionDone = true;

		} else {

			resetSelection ();

			gm.switchPlayer ();

		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
