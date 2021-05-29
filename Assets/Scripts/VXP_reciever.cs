using HoloToolkit.Unity;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.Receivers;
using HoloToolkit.Unity.InputModule;
using Vuforia;

public class VXP_reciever : InteractionReceiver {

	public GameObject textObjectState;
	private TextMesh txt;
	private bool isTracking = true;
    public GameObject animiraniOb;
    public Animator anim;

    void Start()
	{
		txt = textObjectState.GetComponentInChildren<TextMesh>();
        anim = animiraniOb.GetComponent<Animator>();
    }

	protected override void FocusEnter(GameObject obj, PointerSpecificEventData eventData) {
		//Debug.Log(obj.name + " : FocusEnter");
		txt.text = obj.name + " : FocusEnter";
	}

	protected override void FocusExit(GameObject obj, PointerSpecificEventData eventData) {
		//Debug.Log(obj.name + " : FocusExit");
		txt.text = obj.name + " : FocusExit";
	}

	protected override void InputDown(GameObject obj, InputEventData eventData) {
		//Debug.Log(obj.name + " : InputDown");
		txt.text = obj.name + " : InputDown";
        
        if (isTracking == true)
        {
            TrackerManager.Instance.GetTracker<ObjectTracker>().Stop();
            isTracking = false;
            anim.SetBool("stopPlaying",true);
            anim.SetBool("resumePlaying", false);

            Debug.Log ("OFF");
        }
        else {
            TrackerManager.Instance.GetTracker<ObjectTracker>().Start();
            isTracking = true;
            anim.SetBool("stopPlaying", false);
            anim.SetBool("resumePlaying", true);
            Debug.Log ("ON");
        }
        
    }

    protected override void InputUp(GameObject obj, InputEventData eventData) {
		//Debug.Log(obj.name + " : InputUp");
		txt.text = obj.name + " : InputUp";
	}
		

}
