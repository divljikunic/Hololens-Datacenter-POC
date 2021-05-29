using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vxp_FloorPlans : MonoBehaviour {

	public GameObject fpParent;
	Renderer[] pokazivaci;

	// Use this for initialization
	void Start () {
		pokazivaci = GetComponentsInChildren<Renderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
