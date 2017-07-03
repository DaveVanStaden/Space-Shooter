using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shake : MonoBehaviour {

    public GameObject Camera;
    public float shake;
    public float shakeAmount;
    public float decreaseFactor;
    
    void Update() {
            if (shake > 0) {
                Camera.transform.localPosition = Random.insideUnitSphere * shakeAmount;
                shake -= Time.deltaTime * decreaseFactor;

            } else {
                shake = 0.0f;
            }
        }
}
