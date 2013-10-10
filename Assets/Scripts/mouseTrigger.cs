using UnityEngine;
using System.Collections;

public class mouseTrigger : MonoBehaviour {
	public bool turnClockwise = true;
	public int timer;
	public int turnTime = 10;
	public Vector3 speed = new Vector3( -0.1f, 0, 0 );
	public bool caught = false;
	
	void Start () {
		timer = 0;
	}

	void Update () {
		if ( caught == false ) {
			transform.position += speed;
		
			if ( turnClockwise ) {
				if ( timer >= turnTime ) {
					turnClockwise = false;	
					timer = 0;
				}
				else {	
					transform.Rotate (0, 1f, 0);
					timer++;
				}
			}
		
			if ( turnClockwise == false ) {
				if ( timer >= turnTime ) {
					turnClockwise = true;
					timer = 0;
				}
				else {	
					transform.Rotate (0, -1f, 0);
					timer++;
				}
			}	
		}
		
		else{
			transform.position += new Vector3( 0, 0, -0.1f );	
		}
	}
	
	
	void OnTriggerEnter() {
		caught = true;
	}
}


