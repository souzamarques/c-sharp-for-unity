using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class estruturaFor : MonoBehaviour {

    // Start is called before the first frame update
    void Start() {
        for(int i = 0; i <= 10; i++) {
            Debug.Log(i);
        }

        int k = 0;
        while(k <= 10) {
            Debug.Log(k);
            if(k == 5)
                continue;
            k++;
        }

        k = 10;
        do {
            if(k == 5)
                break;
            Debug.Log(k);
            k--;
        } while(k >= 0);
    }
}
