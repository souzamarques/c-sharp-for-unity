using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class modificadores : MonoBehaviour {

    public int numero;
    private int numero2;
    protected float numero3;

    public int passaValor() {
        return numero2;
    }

    public void modificaValor(int numero2) {
        this.numero2 = numero2;
    }
}

public class exemplo1 : modificadores {
    
    void acessa() {
        numero = 10;
        numero = passaValor();
        modificaValor(100);
        numero3 = 2.5f;
    }
}

public class exemplo2 {
    modificadores objeto = new modificadores();

    void acessa() {
        objeto.numero = 20;
        // objeto.numero3 = 3.5f;
    }
}