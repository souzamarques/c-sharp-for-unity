using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrays : MonoBehaviour {

    int[] numeros = {10, 20, 30};
    int[] novosNumeros = new int[50];
    string[] nomes = new string[5];

    // Start is called before the first frame update
    void Start() {
        print(numeros[0]);
        print(numeros[1]);
        print(numeros[2]);
        numeros[1] = 30;
        nomes[0] = "Hero";

        for(int i = 0; i < novosNumeros.Length; i++) {
            novosNumeros[i] = i;
            Debug.Log(novosNumeros[i] + 1); 
        }
    }

    // Update is called once per frame
    void Update() {
        
    }
}
