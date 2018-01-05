using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreHandler : MonoBehaviour {

    private Text scoreText;
    private float lastY;

	// Use this for initialization
	void Start () {
        scoreText = GetComponentInParent<Text>();
    }

    // Update is called once per frame
    void Update () {
        float characterY = GameObject.Find("Character").transform.position.y;
        if (characterY > lastY) lastY = characterY;
        scoreText.text = "Collected Amount : " + lastY;
    }
}
