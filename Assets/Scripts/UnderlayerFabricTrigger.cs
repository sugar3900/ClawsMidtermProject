using UnityEngine;
using System.Collections;

public class UnderlayerFabricTrigger : MonoBehaviour {

	public GameObject Overlayer;
	public bool rotateNow = false;

	void Start () {}
	
	void Update () {
		
		if ( rotateNow ) {
		transform.Rotate (0, 1f, 0);
		}
		
	}
	
	
	void OnTriggerEnter() {
		
		if ( GameObject.Find("overlayer") == null ) {
			rigidbody.useGravity = true;
			rotateNow = true;
		}
		
	}
	
	
}
