using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour {
	[SerializeField]
	Material lit;

	[SerializeField]
	Material charMat;

	Material origMat;

	bool isConstraintApplied;

	int xC,yC,xD,yD;
	public int idX,idY;
	GridManager gm;
	public enum state {empty, full

	};

	bool isCharSelected;

	public GameObject charOBJ;

	[SerializeField]
	public Tile.state type;


	public Character.type enemyType;

	public void applyConstraint(int fromX , int fromY, int toX, int toY){

		isConstraintApplied = true;
		xC = fromX;
		yC = fromY;
		xD = toX;
		yD = toY;

	}

	void OnCollisionEnter (Collision col){
		
		if (col.gameObject.layer == 8) {

			type = Tile.state.full;
			enemyType = col.gameObject.GetComponent<Character> ().charType;
		}


	}

	void OnCollisionExit (Collision col){
		type = Tile.state.empty;
		enemyType = Character.type.None;


	}

	// Use this for initialization
	void Start () {
		enemyType = Character.type.None;

		origMat = GetComponent<MeshRenderer> ().material;
		gm = FindObjectOfType<GridManager> ().GetComponent<GridManager> ();

	}


	void OnMouseDown(){


		if (type == Tile.state.full) {

		//	charOBJ.GetComponent<Character> ().showUI ();


			gm.isCharSelected = true;

		} else {
			gm.isCharSelected = false;

		}

		if (gm.isCharSelected) {
			FindObjectOfType<Character> ().GetComponent<Character> ().moveCharacter (idX, idY);
			gm.isCharSelected = false;

		}


	}
	void OnMouseOver(){

		if (gm.isConstraintApplied) {
			if (gm.constraintCheck(idX,idY)) {



				GetComponent<MeshRenderer> ().material = lit;

			}
		} else {

			GetComponent<MeshRenderer> ().material = lit;
			if (gm.isCharSelected) {
				GetComponent<MeshRenderer> ().material = charMat;

			}

		}

	}
	void OnMouseExit(){

		GetComponent<MeshRenderer> ().material = origMat;


	}
	// Update is called once per frame
	void Update () {
		
	}
}
