using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class overloading : MonoBehaviour {

    calculadora calc = new calculadora();
    int resultadoInt, resultado;
    float resultadoFloat;

    // Start is called before the first frame update
    void Start() {
        resultadoInt = calc.soma(2, 4);
        resultadoFloat = calc.soma(3.3f, 4.4f);
        resultado = calc.soma(2, 3, 4);
    }
}

public class calculadora {

    public int soma(int a, int b) {
        return a + b;
    }

    public int soma(int a, int b, int c) {
        return a + b + c;
    }

    public float soma(float a, float b) {
        return a + b;
    }
}