using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity;
using HoloToolkit.Unity.InputModule;

public class vxp_coconuts : MonoBehaviour, IInputClickHandler
{

    public Rigidbody kokos;
    Vector3 location;

    public void SpawnCoco() {

        //Rigidbody kokosInstance;
        //kokosInstance = Instantiate(kokos) as Rigidbody;
        Instantiate(kokos, location, transform.rotation);

        //Instantiate(prefab, Vector3(0, 0, 0), transform.rotation);
    }



    public void OnInputClicked(InputClickedEventData eventData)
    {

        SpawnCoco();

    }




}
