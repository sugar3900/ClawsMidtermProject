using UnityEngine;
using System.Collections;

public class OverlayerFabricTrigger : MonoBehaviour {
	public Color color;
	
	void Start () {
		color = renderer.material.color;
	}
	
	void Update () {
		//if ( Time.time ) 
		
		
	}
	
	void OnTriggerEnter() {
		
		color.a -= 0.5f;
		renderer.material.color = color;
		
		if( color.a < 0 ) {
			Destroy ( gameObject );
		}
		
	}
	
}
