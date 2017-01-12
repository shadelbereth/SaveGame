using UnityEngine;
using System.Collections;

public class RandomMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void RandomyMove() {
        transform.position += Random.insideUnitSphere;
    }
}
