using UnityEngine;
using System.Collections;

public class ScoreButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	   
	}

    public void GetScore (int amount) {
        GameManager.manager.AddScore(amount);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
