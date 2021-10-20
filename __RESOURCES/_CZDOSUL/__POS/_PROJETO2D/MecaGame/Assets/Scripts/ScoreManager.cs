using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public static int score;
    Text text;

	void Start () {
        score = PlayerPrefs.GetInt("Score", 0);
        text = GetComponent<Text>();
	}

    private void OnGUI()
    {
        text.text = "Score: " + ScoreManager.score;
    }

    void Update () {
       
	}
}
