using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationDebugger : MonoBehaviour {

	public GameObject objekat;
	private TextMesh tekstt;
	private string sadrzaj;

	// Use this for initialization
	void Start () {
		tekstt = this.GetComponent<TextMesh>();
	}

	// Update is called once per frame
	void Update () {
		//sadrzaj = ToString(objekat.transform.rotation.eulerAngles.x);
		//tekstt.text = sadrzaj;
			
	}
}
