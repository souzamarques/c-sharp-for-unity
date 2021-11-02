using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrays : MonoBehaviour {

    int[] numeros = {10, 20, 30};
    int[] novosNumeros = new int[50];
    string[] nomes = new string[5];

    // Start is called before the first frame update
    void Start() {
        nomes[0] = "Hero";
        Debug.Log(nomes[0]);

        for(int i = 0; i < novosNumeros.Length; i++) {
            novosNumeros[i] = i;
            Debug.Log(novosNumeros[i] + 1); 
        }

        foreach(int i in numeros) {
            print(i);
        }
    }

    // Update is called once per frame
    void Update() {
        
    }
}
