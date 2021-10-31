using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class condicional : MonoBehaviour {

    int numero1 = 10, numero2 = 20, moeda = 50, precoPersonagem = 100;
    string resultado;

    // Start is called before the first frame update
    void Start() {
        resultado = numero1 > numero2 ? "sim" : "não";
        Debug.Log(resultado);

        if(moeda >= precoPersonagem) {
            print(" comprar personagem");
        } else {
            print("Não é possível comprar o personagem");
        }
    } 

    // Update is called once per frame
    void Update() {
        
    }
}
