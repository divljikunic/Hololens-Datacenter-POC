using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowOnGaze : MonoBehaviour {

    // Represents the hologram that is currently being gazed at.
    public GameObject FocusedObject { get; private set; }
    public GameObject ShowThisOnGaze;   // Which object to show when this object is gazed

    void Start ()

    {
		if (ShowThisOnGaze.gameObject != null)
        {
            ShowThisOnGaze.SetActive(false);
        }
    }
	
	// Update is called once per frame
	void Update () {

        // Figure out which hologram is focused this frame.
        GameObject oldFocusObject = FocusedObject;
        GameObject oldShowThisOnGaze = ShowThisOnGaze;

            // Do a raycast into the world based on the user's
            // head position and orientation.
            var headPosition = Camera.main.transform.position;
            var gazeDirection = Camera.main.transform.forward;

            RaycastHit hitInfo;

            if (Physics.Raycast(headPosition, gazeDirection, out hitInfo))
            {
                // If the raycast hit a hologram, use that as the focused object.
                FocusedObject = hitInfo.collider.gameObject;

                if (FocusedObject.tag.Equals("cooling") == true)
                {
                oldShowThisOnGaze.SetActive(true);
                }
                /*else
                {
                oldShowThisOnGaze.SetActive(false);
                }*/
            }
            else
            {
                // If the raycast did not hit a hologram, clear the focused object.
                FocusedObject = null;
            oldShowThisOnGaze.SetActive(false);
        }



    }
    
}
