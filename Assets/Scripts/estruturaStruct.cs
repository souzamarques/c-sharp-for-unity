using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class estruturaStruct : MonoBehaviour {

    Moto falcon = new Moto(1000, "Falcon");

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
    }
}

public struct Moto {
    public float potencia;
    public string marca;

    public void ligarMoto() {

    }

    public Moto(float potencia, string marca) {
        this.potencia = potencia;
        this.marca = marca;
    }
}