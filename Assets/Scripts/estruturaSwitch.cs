using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class estruturaSwitch : MonoBehaviour {

    int estadoVilao = 1;

    // Start is called before the first frame update
    void Start() {
        switch(estadoVilao) {
            case 1:
                // vilão ataca
                break;
            case 2:
                // vilão defende
                break;
            case 3:
                // vilão foge
                break;
        }
    }

    // Update is called once per frame
    void Update() {
        
    }
}
