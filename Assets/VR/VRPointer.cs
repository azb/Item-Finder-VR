﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRPointer : Pointer {
    
    public VRController vrController;

    private void Start()
    {
        if (vrController == null)
        vrController = FindObjectOfType<VRController>();
    }

    // Update is called once per frame
    void Update () {
        
        Ray ray = new Ray(this.transform.position, transform.forward);
        
        UpdatePointer(ray,
            vrController.triggerRightHand.Pressed(),
            vrController.triggerRightHand.Held(),
            vrController.triggerRightHand.Released()
            );
    }
}
