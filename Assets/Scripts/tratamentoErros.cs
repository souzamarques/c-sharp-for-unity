using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tratamentoErros : MonoBehaviour {

    public int n1, n2, resultado;

    // Start is called before the first frame update
    void Start() {
        try {
            resultado = n1 * n2;

            if(resultado < 0) {
                throw new System.Exception("Resultado é negativo");
            }
        } catch(UnityException x) {
            Debug.Log(x);
        } finally {
            Debug.Log("Processo finalizado");
        }    
    }
}
