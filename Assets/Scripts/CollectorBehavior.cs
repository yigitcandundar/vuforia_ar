using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class CollectorBehavior : MonoBehaviour {

    
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Finish")
        {
            other.GetComponentInParent<ARObjectManager>().HideObject();
        }
    }

}
