using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart5 : MonoBehaviour {

    void Update() {
        if (PlayerHealth.playerHealth < 100) {
            Destroy(gameObject);
        }
    }
}
