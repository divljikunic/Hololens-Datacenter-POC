using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity;

//{}
public class WorldCursor : MonoBehaviour {

	private MeshRenderer meshRenderer;
	public GameObject object1; // varijabla temporary materijala
	public Material matPassive; //materijal inace
	public Material matActive; //materijal kad je overlapano

	void Start()
	{
		object1.GetComponentInChildren<Renderer>().material = matPassive;
	}

	void Update()
	{
		var headPosition = Camera.main.transform.position;
		var gazeDirection = Camera.main.transform.forward;
		var idleDirection = Vector3.Normalize (gazeDirection);

		RaycastHit hitInfo;

		if (Physics.Raycast(headPosition, gazeDirection, out hitInfo))
		{
			object1.GetComponentInChildren<Renderer>().material = matActive;
			this.transform.position = hitInfo.point; // postavi kursor na mjesto di ga je strefilo
			this.transform.rotation = Quaternion.FromToRotation(Vector3.up, hitInfo.normal); //orjentiraj kursor na pravi nacin (proucit quaternion rotaciju)
		}
		else
		{
			//this.transform.rotation = Quaternion.LookRotation(gazeDirection);
			//this.transform.position = new Vector3 (gazeDirection.x, gazeDirection.y, gazeDirection.z); 
			object1.GetComponentInChildren<Renderer>().material = matPassive;
			this.transform.position = idleDirection*2;
			this.transform.rotation = Quaternion.LookRotation(gazeDirection);
		}

	}
}
