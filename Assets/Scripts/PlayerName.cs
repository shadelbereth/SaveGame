using UnityEngine;
using System.Collections;

public class PlayerName : MonoBehaviour {

    string playerName = "Default Name";

    public void SetName (string name) {
        playerName = name;
    }

    public void PrintName() {
        print(playerName);
    }

    public void SaveName() {
        PlayerPrefs.SetString("name", playerName);
        PlayerPrefs.Save();
    }

    public void LoadName() {
        if (PlayerPrefs.HasKey("name")) {
            playerName = PlayerPrefs.GetString("name");
        }
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
