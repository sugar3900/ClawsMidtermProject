using UnityEngine;
using System.Collections;

public class KeyboardMovements : MonoBehaviour {
	
	public float w, h, wUnit, hUnit;
	
	//position method//
	public Vector3 pos;
	public float xSum = 0, xInputs = 0, zInputs = 0, increment, zMin;
	public float oldPosZ;
	
	public Vector3 downAngle = new Vector3( 288f, 180f, 3.7f ); 
	public Vector3 upAngle = new Vector3( 300f, 180f, 2.2f );
	public float upHeight = 1.24f; 
	public float downHeight = 1.16f;
	
	/*//Velocity Method
	public Vector3 goTo;
	public Vector3 direction;
	public Vector3 oldDirection;
	*/
		
	void Start () {
	
		w = 1f;
		h = 3f;
		wUnit = w/13f;
		hUnit = h/5f;
		
		pos = transform.position;
		
		/*//Velocity Method
		goTo = new Vector3( w/2f, 0, h/2f );
		direction = Vector3.zero;
		*/
	}
	

	void Update () {
		
		//lower/raise arm
		if ( Input.anyKey ) {
			pos.y = downHeight;
			transform.eulerAngles = downAngle;
		}
		else {
			pos.y = upHeight;
			transform.eulerAngles = upAngle;
		}
		
		
		oldPosZ = pos.z;
		xSum = 0;
		xInputs = 0;
		
		//choose lowest row that was selected
		zMin = hUnit * 5;
		ChooseRow();
		//print ( zInputs );
		if (zInputs != 0 ) pos.z = zMin;
	
		
		//if in top few rows, call ChooseColumn()
		if (  pos.z > oldPosZ ) { 
			ChooseColumn();
			//print (  xInputs );
			if ( xInputs != 0 ) pos.x = xSum/xInputs;
		}
		
		//move forward so it looks better when swatting
		if ( Input.anyKey ) {
			pos.z += 1.2f;
		}
		
		transform.position = pos;
		
		//revert z position back to how it was before
		if ( Input.anyKey ) {
				pos.z -= 1.2f;
			}
		
		/*//Velocity Method
		oldDirection = direction; //
		direction = goTo - transform.position;
		
		//makes sure changing directions is smooth
		/*Vector3 vel = rigidbody.velocity;
		if ( ( oldDirection.x > 0 && direction.x < 0 ) || ( oldDirection.x < 0 && direction.x > 0 ) ) {
			vel.x = 0;
		}
		if ( ( oldDirection.y > 0 && direction.y < 0 ) || ( oldDirection.y < 0 && direction.y > 0 ) ) {
			vel.y = 0;
		}
		rigidbody.velocity = vel;
		
		//add the force
		//rigidbody.AddForce ( direction );
		*/
		
	}
	
	
	void ChooseRow() {	
		
		//Transform method//
		zInputs = 0;

		//top row
		if ( Input.GetKeyDown("escape") || Input.GetKeyDown("f1") || Input.GetKeyDown("f2")
			|| Input.GetKeyDown("f3") || Input.GetKeyDown("f4") || Input.GetKeyDown("f5")
			|| Input.GetKeyDown("f6")|| Input.GetKeyDown("f7") || Input.GetKeyDown("f8") 
			|| Input.GetKeyDown("f9") || Input.GetKeyDown("f10") || Input.GetKeyDown("f11")
			|| Input.GetKeyDown("f12") || Input.GetKeyDown("insert") || Input.GetKeyDown("delete")  ) {
			
			/*//Velocity method//
			goTo.z = hUnit * 5;
			*/
				
			//makes sure to choose the lowest row
			zInputs++;
			increment = hUnit * 5;
			if ( increment <  zMin ) zMin = increment;
		}
		
		//row 2
		if ( Input.GetKeyDown("1") || Input.GetKeyDown("2") || Input.GetKeyDown("3") 
			|| Input.GetKeyDown("4") || Input.GetKeyDown("5") || Input.GetKeyDown("6")
			|| Input.GetKeyDown("7")|| Input.GetKeyDown("8") || Input.GetKeyDown("9")
			|| Input.GetKeyDown("0") || Input.GetKeyDown("-") || Input.GetKeyDown("+")
			|| Input.GetKeyDown("backspace") || Input.GetKeyDown("home") ) {
			zInputs++;
			increment = hUnit * 4;
			if ( increment <  zMin ) zMin = increment;
		}
		
		//row 3
		 if ( Input.GetKeyDown("tab") || Input.GetKeyDown("q") || Input.GetKeyDown("w") 
			|| Input.GetKeyDown("e") || Input.GetKeyDown("r") || Input.GetKeyDown("t")
			|| Input.GetKeyDown("y")|| Input.GetKeyDown("u") || Input.GetKeyDown("i")
			|| Input.GetKeyDown("o") || Input.GetKeyDown("p") || Input.GetKeyDown("[")
			|| Input.GetKeyDown("]") || Input.GetKeyDown("page up")  ) {
			zInputs++;
			increment = hUnit * 3;
			if ( increment <  zMin ) zMin = increment;
		}
		
		//row 4
		 if ( Input.GetKeyDown("a") || Input.GetKeyDown("s") || Input.GetKeyDown("d") 
			|| Input.GetKeyDown("f") || Input.GetKeyDown("g") || Input.GetKeyDown("h")
			|| Input.GetKeyDown("j")|| Input.GetKeyDown("k") || Input.GetKeyDown("l")
			|| Input.GetKeyDown(";") || Input.GetKeyDown("'") || Input.GetKeyDown("enter")
			|| Input.GetKeyDown ("return") || Input.GetKeyDown("page down") ) {
			zInputs++;
			increment = hUnit * 2;
			if ( increment <  zMin ) zMin = increment;
		}
		
		//row 5
		 if ( Input.GetKeyDown("left shift") || Input.GetKeyDown("z") || Input.GetKeyDown("x") 
			|| Input.GetKeyDown("c") || Input.GetKeyDown("v") || Input.GetKeyDown("b")
			|| Input.GetKeyDown("n")|| Input.GetKeyDown("m") || Input.GetKeyDown(",")
			|| Input.GetKeyDown(".") || Input.GetKeyDown("/") || Input.GetKeyDown("right shift")
			|| Input.GetKeyDown("end") ) {
			zInputs++;
			increment = hUnit * 1;
			if ( increment <  zMin ) zMin = increment;
		}
		
		//bottom row
		 if ( Input.GetKeyDown("left ctrl") || Input.GetKeyDown("left alt") 
			|| Input.GetKeyDown("space")|| Input.GetKeyDown("right alt") 
			|| Input.GetKeyDown("right ctrl") ) {
			zInputs++;
			increment = hUnit * 0;
			if ( increment <  zMin ) zMin = increment;
		}
	}
		
	
	void ChooseColumn() {
		
		//left column
		if ( Input.GetKeyDown("escape") || Input.GetKeyDown("f1") || Input.GetKeyDown("1")
			|| Input.GetKeyDown("tab") || Input.GetKeyDown("q") || Input.GetKeyDown("a") 
			|| Input.GetKeyDown("left shift") || Input.GetKeyDown("left ctrl") ) {
			
			//Transform method
			xInputs++;
			xSum += hUnit * 0;
			
			/*//velocity method
			goTo.x = hUnit * 0;
			*/
		}
		
		//column 2
		 if ( Input.GetKeyDown("f2") || Input.GetKeyDown("2") || Input.GetKeyDown("w")
			|| Input.GetKeyDown("s") || Input.GetKeyDown("z") ) {
			xInputs++;
			xSum += hUnit * 1;
		}
		
		//column 3
		 if ( Input.GetKeyDown("f3") || Input.GetKeyDown("3") || Input.GetKeyDown("e")
			|| Input.GetKeyDown("d") || Input.GetKeyDown("x") || Input.GetKeyDown("left alt") ) {
			xInputs++;
			xSum += hUnit * 2;
		}
		
		//column 4
		 if ( Input.GetKeyDown("f4") || Input.GetKeyDown("4") || Input.GetKeyDown("r")
			|| Input.GetKeyDown("f") || Input.GetKeyDown("c") ) {
			xInputs++;
			xSum += hUnit * 3;
		}
		
		//column 5
		 if ( Input.GetKeyDown("f5") || Input.GetKeyDown("5") || Input.GetKeyDown("t")
			|| Input.GetKeyDown("v") ) {
			xInputs++;
			xSum += hUnit * 4;
		}
		
		//column 6
		 if ( Input.GetKeyDown("f6") || Input.GetKeyDown("6") || Input.GetKeyDown("y")
			|| Input.GetKeyDown("g") || Input.GetKeyDown("b") || Input.GetKeyDown("space") ) {
			xInputs++;
			xSum += hUnit * 5;
		}
		
		//column 7
		 if ( Input.GetKeyDown("f7") || Input.GetKeyDown("7") || Input.GetKeyDown("u")
			|| Input.GetKeyDown("h") || Input.GetKeyDown("n") ) {
			xInputs++;
			xSum += hUnit * 6;
		}
		
		//column 8
		 if ( Input.GetKeyDown("f8") || Input.GetKeyDown("8") || Input.GetKeyDown("j")
			|| Input.GetKeyDown("n") ) {
			xInputs++;
			xSum += hUnit * 7;
		}
		
		//column 9
		 if ( Input.GetKeyDown("f9") || Input.GetKeyDown("9") || Input.GetKeyDown("i")
			|| Input.GetKeyDown("k") ) {
			xInputs++;
			xSum += hUnit * 8;
		}
		
		//column 10
		 if ( Input.GetKeyDown("f10") || Input.GetKeyDown("0") || Input.GetKeyDown("o")
			|| Input.GetKeyDown("l") || Input.GetKeyDown(",") || Input.GetKeyDown("right alt") ) {
			xInputs++;
			xSum += hUnit * 9;
		}
		
		//column 11
		 if ( Input.GetKeyDown("f11") || Input.GetKeyDown("-") || Input.GetKeyDown("p")
			|| Input.GetKeyDown(";") || Input.GetKeyDown(".") ) {
			xInputs++;
			xSum += hUnit * 10;
		}
		
		//column 12
		 if ( Input.GetKeyDown("f12") || Input.GetKeyDown("[") || Input.GetKeyDown("'")
			|| Input.GetKeyDown("/") || Input.GetKeyDown("right ctrl") ) {
			xInputs++;
			xSum += hUnit * 11;
		}
		
		//column 13
		 if ( Input.GetKeyDown("insert") || Input.GetKeyDown("backspace")
			|| Input.GetKeyDown("enter") || Input.GetKeyDown("return") 
			|| Input.GetKeyDown("right shift") ) {
			xInputs++;
			xSum += hUnit * 12;
		}
		
		//right column
		 if ( Input.GetKeyDown("delete") || Input.GetKeyDown("home") 
			|| Input.GetKeyDown("page up") || Input.GetKeyDown("page down") 
			|| Input.GetKeyDown("end") ) {
			xInputs++;
			xSum += hUnit * 13;
		}
		
	}
	
	
}
