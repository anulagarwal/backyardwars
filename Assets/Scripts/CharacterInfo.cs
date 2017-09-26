using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInfo : MonoBehaviour {
	[SerializeField]
	public string name;

	[SerializeField]
	public string _class;

	[SerializeField]
	public string level;

	public int HP;
	public int DMG;
	public int Armor;
	public int XP;

	public int xVal;

	public int yVal;

	// Use this for initialization
	void Start () {
	
		if (_class == "animal") {


		} else if (_class == "human") {


		} else if (_class == "robot") {


		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
