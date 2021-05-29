using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class RotateOnTap : MonoBehaviour, IInputClickHandler
{


    public virtual void OnInputClicked(InputClickedEventData eventData)
    {
        if (this.GetComponent<DoRotate>().enabled == false)
        {
            this.GetComponent<DoRotate>().enabled = true;
        }

        else
        {
            this.GetComponent<DoRotate>().enabled = false;
        }

    }

}


