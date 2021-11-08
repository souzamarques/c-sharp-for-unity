using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class classeSelada : MonoBehaviour {

    A objeto = new A();

    // Start is called before the first frame update
    void Start() {
        objeto.velocidade = 50;
    }
}

sealed class A { // Não é possível herdar classes seladas
    public int velocidade;
}