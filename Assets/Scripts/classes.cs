using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class classes : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
    }
}

class vampiros : MonoBehaviour {
    int forca;
    int ataque;
    int velocidade;

    public void setAtaque(int ataque) {
        this.ataque = ataque;
    }
}

class lobisomens : vampiros {

    private void Start() {
        int ataque = 10;
        setAtaque(ataque);
    }   


}