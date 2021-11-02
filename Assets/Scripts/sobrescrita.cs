using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sobrescrita : MonoBehaviour {

}

public class Monstros {

    public virtual void Ataque() { // "virtual" é necessário para fazer a sobrescrita.
        // implementação do método
    }
}

public class Frankenstein : Monstros {
    
    public override void Ataque() {
        base.Ataque();
        // implementação do método
    }
}