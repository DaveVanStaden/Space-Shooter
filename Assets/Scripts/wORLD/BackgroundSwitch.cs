using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundSwitch : MonoBehaviour {

    public GameObject bg1 = GameObject.FindGameObjectWithTag("bg1");
    public GameObject bg2 = GameObject.FindGameObjectWithTag("bg2");
    public GameObject bg3 = GameObject.FindGameObjectWithTag("bg3");
    public GameObject bg4 = GameObject.FindGameObjectWithTag("bg4");
    public GameObject bg5 = GameObject.FindGameObjectWithTag("bg5");
    public GameObject bg6 = GameObject.FindGameObjectWithTag("bg6");
    public GameObject bg7 = GameObject.FindGameObjectWithTag("bg7");
    public GameObject bg8 = GameObject.FindGameObjectWithTag("bg8");
    public GameObject bg9 = GameObject.FindGameObjectWithTag("bg9");

    void OnTriggerEnter2D(Collider2D coll) {

        //UP
        if (coll.gameObject.tag == "bg2") {
            bg7.transform.Translate(Vector3.up * 43.2f);
            bg8.transform.Translate(Vector3.up * 43.2f);
            bg9.transform.Translate(Vector3.up * 43.2f);

            bg7.transform.gameObject.tag = "bg1";
            bg8.transform.gameObject.tag = "bg2";
            bg9.transform.gameObject.tag = "bg3";

            bg1.transform.gameObject.tag = "bg4";
            bg2.transform.gameObject.tag = "bg5";
            bg3.transform.gameObject.tag = "bg6";

            bg4.transform.gameObject.tag = "bg7";
            bg5.transform.gameObject.tag = "bg8";
            bg6.transform.gameObject.tag = "bg9";

            bg1 = GameObject.FindGameObjectWithTag("bg1");
            bg2 = GameObject.FindGameObjectWithTag("bg2");
            bg3 = GameObject.FindGameObjectWithTag("bg3");
            bg4 = GameObject.FindGameObjectWithTag("bg4");
            bg5 = GameObject.FindGameObjectWithTag("bg5");
            bg6 = GameObject.FindGameObjectWithTag("bg6");
            bg7 = GameObject.FindGameObjectWithTag("bg7");
            bg8 = GameObject.FindGameObjectWithTag("bg8");
            bg9 = GameObject.FindGameObjectWithTag("bg9");


        }

        //LEFT
        if (coll.gameObject.tag == "bg4") {
            bg3.transform.Translate(Vector3.left * 76.8f);
            bg6.transform.Translate(Vector3.left * 76.8f);
            bg9.transform.Translate(Vector3.left * 76.8f);

            bg3.transform.gameObject.tag = "bg1";
            bg6.transform.gameObject.tag = "bg4";
            bg9.transform.gameObject.tag = "bg7";

            bg1.transform.gameObject.tag = "bg2";
            bg4.transform.gameObject.tag = "bg5";
            bg7.transform.gameObject.tag = "bg8";

            bg2.transform.gameObject.tag = "bg3";
            bg5.transform.gameObject.tag = "bg6";
            bg8.transform.gameObject.tag = "bg9";

            bg1 = GameObject.FindGameObjectWithTag("bg1");
            bg2 = GameObject.FindGameObjectWithTag("bg2");
            bg3 = GameObject.FindGameObjectWithTag("bg3");
            bg4 = GameObject.FindGameObjectWithTag("bg4");
            bg5 = GameObject.FindGameObjectWithTag("bg5");
            bg6 = GameObject.FindGameObjectWithTag("bg6");
            bg7 = GameObject.FindGameObjectWithTag("bg7");
            bg8 = GameObject.FindGameObjectWithTag("bg8");
            bg9 = GameObject.FindGameObjectWithTag("bg9");
        }

        //RIGHT
        if (coll.gameObject.tag == "bg6") {
            bg1.transform.Translate(Vector3.right * 76.8f);
            bg4.transform.Translate(Vector3.right * 76.8f);
            bg7.transform.Translate(Vector3.right * 76.8f);

            bg1.transform.gameObject.tag = "bg3";
            bg4.transform.gameObject.tag = "bg6";
            bg7.transform.gameObject.tag = "bg9";

            bg3.transform.gameObject.tag = "bg2";
            bg6.transform.gameObject.tag = "bg5";
            bg9.transform.gameObject.tag = "bg8";

            bg2.transform.gameObject.tag = "bg1";
            bg5.transform.gameObject.tag = "bg4";
            bg8.transform.gameObject.tag = "bg7";

            bg1 = GameObject.FindGameObjectWithTag("bg1");
            bg2 = GameObject.FindGameObjectWithTag("bg2");
            bg3 = GameObject.FindGameObjectWithTag("bg3");
            bg4 = GameObject.FindGameObjectWithTag("bg4");
            bg5 = GameObject.FindGameObjectWithTag("bg5");
            bg6 = GameObject.FindGameObjectWithTag("bg6");
            bg7 = GameObject.FindGameObjectWithTag("bg7");
            bg8 = GameObject.FindGameObjectWithTag("bg8");
            bg9 = GameObject.FindGameObjectWithTag("bg9");
        }

        //DOWN
        if (coll.gameObject.tag == "bg8") {
            bg1.transform.Translate(Vector3.down * 43.2f);
            bg2.transform.Translate(Vector3.down * 43.2f);
            bg3.transform.Translate(Vector3.down * 43.2f);

            bg1.transform.gameObject.tag = "bg7";
            bg2.transform.gameObject.tag = "bg8";
            bg3.transform.gameObject.tag = "bg9";

            bg7.transform.gameObject.tag = "bg4";
            bg8.transform.gameObject.tag = "bg5";
            bg9.transform.gameObject.tag = "bg6";

            bg4.transform.gameObject.tag = "bg1";
            bg5.transform.gameObject.tag = "bg2";
            bg6.transform.gameObject.tag = "bg3";

            bg1 = GameObject.FindGameObjectWithTag("bg1");
            bg2 = GameObject.FindGameObjectWithTag("bg2");
            bg3 = GameObject.FindGameObjectWithTag("bg3");
            bg4 = GameObject.FindGameObjectWithTag("bg4");
            bg5 = GameObject.FindGameObjectWithTag("bg5");
            bg6 = GameObject.FindGameObjectWithTag("bg6");
            bg7 = GameObject.FindGameObjectWithTag("bg7");
            bg8 = GameObject.FindGameObjectWithTag("bg8");
            bg9 = GameObject.FindGameObjectWithTag("bg9");
        }
    }
}
