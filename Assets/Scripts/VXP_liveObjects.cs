using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity;
using HoloToolkit.Unity.InputModule;


public class VXP_liveObjects : MonoBehaviour, IFocusable, IInputClickHandler 
{
	public Material passive;
	public Material active;

	public GameObject hover;
    public GameObject popup;
    public vxp_popupMngr popManager;
    //public List<GameObject> popups;
	MeshRenderer textrend;
	MeshRenderer rend;

	void Start()
	{
		rend = GetComponent<MeshRenderer> ();
		rend.material = passive;
		if (hover!=null)
		{
		    textrend = hover.GetComponent<MeshRenderer> ();
		    textrend.enabled = false;
		}
	}

	public void OnFocusEnter()
	{
		rend.material = active;
		if (hover!=null)
		{
			textrend.enabled = true;
		}

	}

	public void OnFocusExit()
	{
		rend.material = passive;

		if (hover!=null)
		{
			textrend.enabled = false;
		}
	}

    public void OnInputClicked(InputClickedEventData eventData) {

        popManager.Clicked(this.gameObject, popup);
    }

}