using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart4 : MonoBehaviour {

    void Update() {
        if (PlayerHealth.playerHealth < 80) {
            Destroy(gameObject);
        }
    }
}
