using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class classes : MonoBehaviour {

    Vampiros Dracula = new Vampiros(10, 10);

    // Start is called before the first frame update
    void Start() {
        /* Dracula.forca = 100;
        Dracula.velocidade = 100; */
    }

    // Update is called once per frame
    void Update() {
        Dracula.ataque();
    }
}

class Vampiros {
    public int forca;
    public int velocidade;

    public Vampiros(int forca, int velocidade) {
        this.forca = forca;
        this.velocidade = velocidade;
    }

    public void ataque() {
        
    }
}

class Lobisomens : Vampiros {
    public Lobisomens(int forca, int velocidade) : base(forca, velocidade) {

    }
}