using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharUI : MonoBehaviour {

	[SerializeField]
	string charName;

	[SerializeField]
	string tagLine;

	[SerializeField]
	string details;


	int HP,DMG,Armor;
	CharacterInfo ci;

	// Use this for initialization
	void Start () {
		ci = GetComponent<CharacterInfo> ();

		HP = ci.HP;
		DMG = ci.DMG;
		Armor = ci.Armor;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
