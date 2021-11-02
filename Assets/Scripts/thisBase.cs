using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thisBase : MonoBehaviour {
    int numero;
    void exemplo(int numero) {
        this.numero = numero;
    }
}

public class Inimigo {
    public int velocidade;
}

public class Orc : Inimigo {

    void ataque(int velocidade) {
        base.velocidade = velocidade; // Acesso e atribuição a variável "velocidade" da classe Inimigo.
    }
}