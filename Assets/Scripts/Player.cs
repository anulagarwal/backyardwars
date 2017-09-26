using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {



	[SerializeField]
	int numberOfCharacters;

	public Character.type[] character;
	[SerializeField]
	public GameObject[] characters = new GameObject[3];
	public enum type{ P1,P2};

	[SerializeField]
	public Player.type pType;

	// Use this for initialization
	void Start () {



	}

	public void setChar(){
		character = new Character.type[3];

	}

	public void displayChar(){

		print (character [1]);
	}

	// Update is called once per frame
	void Update () {
		
	}
}
