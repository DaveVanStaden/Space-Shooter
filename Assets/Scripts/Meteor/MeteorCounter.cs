using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MeteorCounter : MonoBehaviour {
    public static float meteorcounter = 0;
    public static int playerCounter = 0;
    int standardCounter = 0;
    // Use this for initialization
    private Text countertext;
    private void Awake()
    {
        countertext = GameObject.Find("meteorCounter").GetComponent<Text>();
    }
    void Start()
    {
        playerCounter = standardCounter;
    }
    void Update()
    {
        countertext.text = "Meteor's destroyed: " + playerCounter;
        
    }
}