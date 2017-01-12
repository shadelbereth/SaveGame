using UnityEngine;
using System.Collections;

public class SaveButton : MonoBehaviour {

    public void Save() {
        GameManager.manager.Save();
    }

    public void Load() {
        GameManager.manager.Load();
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
