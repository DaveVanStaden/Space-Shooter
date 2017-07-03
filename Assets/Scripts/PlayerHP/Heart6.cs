using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart6 : MonoBehaviour {

    void Update() {
        if (PlayerHealth.playerHealth < 120) {
            Destroy(gameObject);
        }
    }
}
