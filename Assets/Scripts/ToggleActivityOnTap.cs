using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit;
using HoloToolkit.Unity.InputModule;






public class ToggleActivityOnTap : MonoBehaviour, IInputClickHandler

{

    public GameObject[] gameObjectToToggle;
    public GameObject[] gameObjectsTotoggleOff;


    private bool clicked;


	// Use this for initialization
	void Start ()
    {
        clicked = false;
        foreach (GameObject item in gameObjectToToggle)
        {
            item.SetActive(clicked);
          //gameObjectToToggle.SetActive(clicked);
        }


        
        
    }
    public virtual void OnInputClicked(InputClickedEventData eventData)
    {
        if (clicked == false)
        {
        clicked = true;
            foreach (GameObject item in gameObjectToToggle)
            {
                item.SetActive(clicked);
                //gameObjectToToggle.SetActive(clicked);
            }




            foreach (GameObject item in gameObjectsTotoggleOff)
            {
                item.SetActive(false);
            }
        }

        else
        {
        clicked = false;


            foreach (GameObject item in gameObjectToToggle)
            {
                item.SetActive(clicked);
                //gameObjectToToggle.SetActive(clicked);
            }
   
        }
    }
}
