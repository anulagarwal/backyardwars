using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour {

	Tile[,] grid= new Tile[10,10];
	[SerializeField]
	int rows,cols;
	[SerializeField]
	GameObject tile;
	[SerializeField]
	int xC,yC,xD,yD;
	[SerializeField]
	public bool isConstraintApplied;

	public bool isMoveConstraintApplied;

	public int moveRange;


	public bool isCharSelected;
	// Use this for initialization
	void Start () {
		initializeGrid ();


	}
	public void initializeGrid(){
		for( int x = 0; x<rows; x++){
			for(int y = 0; y<cols; y++){
				Vector3 v = new Vector3 (x*3,transform.position.y , y*3 );
				transform.position = v;
				grid [x, y]=Instantiate (tile, transform.position, Quaternion.identity).GetComponent<Tile>();
				grid [x, y].idX = x;
				grid [x, y].idY = y;

			}


		}


	}

	public void applyMovementConstraint(int range){

		moveRange = range;

	}
	public void updateGrid(int x, int y, Character.type type, GameObject Obj){

		grid [x, y].enemyType = type;
		grid [x, y].charOBJ = Obj;
		grid [x, y].type = Tile.state.full;

	}
	public void updateGrid(int x, int y, Character.type type){

		grid [x, y].enemyType = type;
	
	}


	public bool constraintCheck(int x, int y){
		if (x <= xD && x >= xC && y >= yC && y <= yD) {
			return true;

		} else {

			return false;
		}
	}
	public bool moveConstraintCheck(int x, int y){
		if (x <= xD && x >= xC && y >= yC && y <= yD) {
			return true;

		} else {

			return false;
		}
	}
	public void applyConstraint(int fromX , int fromY, int toX, int toY){

		isConstraintApplied = true;
		xC = fromX;
		yC = fromY;
		xD = toX;
		yD = toY;

	}

	public void removeConstraint(){

		isConstraintApplied = false;
	}
	// Update is called once per frame
	void Update () {
		
	}

	public int snapToGrid(int val){


		val = Mathf.FloorToInt (val);
		return val;
	}
}
