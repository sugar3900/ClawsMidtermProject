/*
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MouseSpawner : MonoBehaviour {

	public mouseTrigger mouseBlueprint;
	public int mouseCount = 5;
	public List<mouseTrigger> mouseList = new List<mouseTrigger>();
	
	

	void Start () {
		int currentMouseCounter = 0;
		mouseTrigger newMouse;
		while ( currentMouseCounter < mouseCount ) {
			
			//add mice
			float randomDepth = Random.Range (35, 67);
			float randomStartDistance =  Random.Range (1, 130);
			Vector3 mousePosition = new Vector3( randomStartDistance / 100, 0.11f, ( randomDepth / 10f )   );
			newMouse = Instantiate ( mouseBlueprint, mousePosition, Quaternion.identity ) as mouseTrigger;
			
			mouseList.Add ( newMouse );
			currentMouseCounter++;
		}
	}

	

	void Update () {
		
		
		//if( newMouse == NULL ) { //IF NEWMOUSE DIED
			//print ( "new mouse died" );
		//}
			
		//foreach ( Mouse currentMouse in mouseList ) {
		//currentMouse.destination = new Vector3(90f, -70f, -100f);
	}
	
	
	
	
	
	
}
 */