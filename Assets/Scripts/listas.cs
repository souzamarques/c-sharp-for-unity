using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class listas : MonoBehaviour {

    List<int> numeros = new List<int>();

    // Start is called before the first frame update
    void Start() {
        // numeros[3] = 5; Forma não adequada
        numeros.Add(2); // Índice 0
        numeros.Add(1); // Índice 1
        numeros.Add(3); // Índice 2
        numeros.Add(7);
        numeros.Add(5);
        numeros.Add(6);

        numeros.RemoveAt(5);
        numeros.Sort();

        foreach(int i in numeros) {
            print(i);
        }

        numeros.RemoveRange(1, 2);
        foreach(int i in numeros) {
            print(i);
        }
    }

    // Update is called once per frame
    void Update() {
        
    }
}
