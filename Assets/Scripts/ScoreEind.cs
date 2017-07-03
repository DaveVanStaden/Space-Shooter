using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreEind : MonoBehaviour {

    // Use this for initialization
    private Text counterText;
    public int playerCounter;
    private void Awake()
    {
        counterText = GameObject.Find("meteorCounter").GetComponent<Text>();
    }
    void Start()
    {
        playerCounter = PlayerPrefs.GetInt("PlayerScore");
    }
    void Update()
    {
        counterText.text = "Meteor's destroyed: " + playerCounter;

    }
}
