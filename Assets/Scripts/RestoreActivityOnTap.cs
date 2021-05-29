using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit;
using HoloToolkit.Unity.InputModule;






public class RestoreActivityOnTap : MonoBehaviour, IInputClickHandler

{

    public GameObject[] gameObjectToToggle;
    public GameObject[] gameObjectsTotoggleOn;


    private bool clicked;


    // Use this for initialization
    /*void Start ()
    {
        clicked = true;


        foreach (GameObject item in gameObjectsTotoggleOn)
        {
            item.SetActive(clicked);
        }

  
          
        
    }  */
    public virtual void OnInputClicked(InputClickedEventData eventData)
    {
        if (clicked == true)
        {

        clicked = false;

        //gameObjectToToggle.SetActive(clicked);


            foreach (GameObject item in gameObjectToToggle)
            {
                item.SetActive(clicked);
            }



            foreach (GameObject item in gameObjectsTotoggleOn)
            {
                item.SetActive(true);
            }
        }

        else
        {
        clicked = false;
        //gameObjectToToggle.SetActive(clicked);

            foreach (GameObject item in gameObjectToToggle)
            {
                item.SetActive(clicked);
            }




            foreach (GameObject item in gameObjectsTotoggleOn)
            {
                item.SetActive(true);
            }
        }
    }
}
