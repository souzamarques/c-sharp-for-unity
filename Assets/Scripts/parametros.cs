using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parametros : MonoBehaviour {

    int numero, soma, subtracao, somaArray;

    // Start is called before the first frame update
    void Start() {
        numero = 10;
        Exemplo(ref numero);
        // soma = operacoes(20, 20, out subtracao);
        operacoes(20, 30, out subtracao, out soma);
        somaArray = somaNumeros(20, 3, 40, 203);
    }

    void Exemplo(ref int numero) {
        print(numero);
    }

    void operacoes(int a, int b, out int subtracao, out int soma) { // Argumento "out" faz passagem por referência
        subtracao = a - b;
        soma = a + b;
    }

    int somaNumeros(params int[] array) {
        int resultado = 0;

        for(int i = 0; i < array.Length; i++) {
            resultado += array[i]; 
        }

        return resultado;
    }
}