using UnityEngine;
using System;
using System.Collections;
using UnityEngine.Events;

public class RaycastPositionWithCallback : MonoBehaviour {

    [Serializable]
    public class PositionCallback : UnityEvent<Vector3> {}

    public PositionCallback pcb;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
    	RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit)) {
            pcb.Invoke(hit.point);
        }
	}
}
