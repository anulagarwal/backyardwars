using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {

	[SerializeField]
	public enum type{ Cats,Dogs,Snakes,H1,H2,H3,R1,R2,R3,None};

	public Character.type charType;

	bool inTurn;

	bool isMoving;
	Vector3 moveTarget;
	public float speed;
	[SerializeField]
	GameObject popupUI;

	bool isMoveConstraintApplied;

	GridManager gm;
	// Use this for initialization
	void Start () {
		speed = 4f;
		gm = FindObjectOfType<GridManager> ().GetComponent<GridManager> ();
	}
	
	// Update is called once per frame
	void Update () {

		if(inTurn)
		checkGrid ();

		if (isMoving) {
			float step = speed * Time.deltaTime;
			transform.position = Vector3.MoveTowards (transform.position, moveTarget, step);
			//print (moveTarget);
			if (transform.position == moveTarget) {
				isMoving = false;
			}

		}
	}

	public void checkGrid(){



	}

	void OnMouseDown(){

		moveCharacter (0, 0);
	}

	public void applyMoveConstraint(int range){



	}
	public void startTurn(){
		gm.isMoveConstraintApplied = true;
		gm.applyMovementConstraint (1);

	}

	public void endTurn(){

		gm.isMoveConstraintApplied = false;

	}
	public void moveCharacter(int x, int y){
		x = (int)Mathf.Floor (x);
		y =(int) Mathf.Floor (y);
		int curX = (int)Mathf.Floor (transform.position.x)/3;
		int curY= (int)Mathf.Floor (transform.position.y)/3;
		print (curX+""+ curY);
		FindObjectOfType<GridManager> ().GetComponent<GridManager> ().updateGrid (curX, curY, Character.type.None);

		FindObjectOfType<GridManager> ().GetComponent<GridManager> ().updateGrid (x, y, charType,gameObject);

		moveTarget = new Vector3 (x*3,  transform.position.y,y*3);

		isMoving = true;
	}


	public void showUI(){

		popupUI.SetActive (true);
	}


}
