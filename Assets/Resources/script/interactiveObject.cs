using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactiveObject : MonoBehaviour {

	//Define Enum
     public enum TypeEnum{Test1, Test2, Test3};
     
     //This is what you need to show in the inspector.
     public TypeEnum Tests;

	// Use this for initialization
	void Start () {
		
	}
	
	TypeEnum getType(){
		return Tests;
	}

	// Update is called once per frame
	void Update () {
		
	}
}
