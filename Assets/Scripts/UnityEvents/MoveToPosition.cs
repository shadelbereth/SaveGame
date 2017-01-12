using UnityEngine;
using System.Collections;

public class MoveToPosition : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void MoveTo(Vector3 pos) {
        transform.position = pos;
    }
}
