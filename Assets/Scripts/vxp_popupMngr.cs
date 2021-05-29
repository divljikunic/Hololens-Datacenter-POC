using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vxp_popupMngr : MonoBehaviour
{
    public List<GameObject> popups;
    //public List<GameObject> objects;
  

    void Start () {

        foreach (GameObject go in popups) {
            go.SetActive(false);
        }
	}

    public void Clicked(GameObject ime, GameObject imep) {
       
        foreach (GameObject go in popups)
        {
            if (imep.activeSelf)
            {

                if (imep == go)
                {
                    go.SetActive(false);
                }
                else
                {
                    go.SetActive(false);
                }
            }
            else
            {
                if (imep == go)
                {
                    go.SetActive(true);
                }
                else
                {
                    go.SetActive(false);
                }
            }

        }

        //Debug.Log("object: "+ ime.name + " has a popup: " + imep.name);

    }
}
