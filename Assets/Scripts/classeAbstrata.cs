using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class classeAbstratas : MonoBehaviour {

    
}

public abstract class Viloes {
    public float forcaVilao, velocidadeVilao;

    public Viloes() {
        this.forcaVilao = 100;
        this.velocidadeVilao = 50;
    }

    abstract public void Ataque();
}

public class Dracula : Viloes {

    override public void Ataque() {
        // implementação do método        
    }
}
