using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour {

	bool isPause;
	bool isStart;
	[SerializeField]
	public Player P1;

	[SerializeField]
public	Player P2;


	[SerializeField]
	GameObject UIMessagePanel;
	[SerializeField]
	Text title;

	[SerializeField]
	Text bodyText;

	[SerializeField]
	GameObject UISelectPanel;

	public GameObject[] characters;

	public int curPlayerNumber;

	public	bool isSelectionDone;

	[SerializeField]
	public Transform[] loadVal;
	// Use this for initialization
	void Start () {
		isSelectionDone = false;
		isStart = true;
		if (isStart) {

			//InitiateStartSequence ();

		}


	}

	public void switchPlayer(){

		if (curPlayerNumber == 1) {

			curPlayerNumber = 2;
		} else if (curPlayerNumber == 2) {
			curPlayerNumber = 1;

		}
	}

	public void InitiateStartSequence(){

		int number = rollDie ()%2;
		startInitialSetup (number);
	
	}
	public void InitiateSetupSequence(){


		UISelectPanel.SetActive (false);
		int x = 0;
		while (x < 3) {
			Instantiate (P1.characters [x], loadVal [x].position, Quaternion.identity);

			x += 1;
		}
		//print (loadVal [0].position);

	}
	void startInitialSetup(int p){
		string message;

		if(p==1){
			message = "Roll die was odd! Player 1 gets to go first. Start by selecting three characters to play from.";
			DisplayUIMessage (message, "Die Roll!");

			curPlayerNumber = 1;
		}

		else{

			message = "Roll die was even! Player 2 gets to go first. Start by selecting three characters to play from.";
			DisplayUIMessage (message, "Die Roll!");

			curPlayerNumber = 2;
		}
		
	}

	public void SelectCharacters(int number){
		UIMessagePanel.SetActive (false);
		UISelectPanel.SetActive (true);

	}

	void DisplayUIMessage(string message, string header){

		UIMessagePanel.SetActive (true);
		bodyText.text = message;
		title.text = header;
	}

	int rollDie(){

		return Random.Range (1, 7);
	}

	// Update is called once per frame
	void Update () {



	}
}
