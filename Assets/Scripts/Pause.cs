using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1")) {
            if (Time.timeScale == 1) {
                Time.timeScale = 0.1f;
            } else {
                Time.timeScale = 1f;
            }
            Time.fixedDeltaTime = 0.02f * Time.deltaTime;
        }
    }
}
