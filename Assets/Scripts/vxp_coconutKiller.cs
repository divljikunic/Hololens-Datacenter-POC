﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vxp_coconutKiller : MonoBehaviour {

    void Start()
    {
        DestroyObjectDelayed();
    }

    void DestroyObjectDelayed()
    {
        // Kills the game object in 5 seconds after loading the object
        Destroy(gameObject, 2);
    }
}
