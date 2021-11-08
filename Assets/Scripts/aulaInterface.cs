using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aulaInterface : MonoBehaviour {

        
}

public interface IInteracoes<T> {
    void Interacao(float t);
}

public interface ICombate {
    void Atirar();
}

public class Door : MonoBehaviour, IInteracoes<float>, ICombate {
    
    public void Interacao(float game) {
        // Implementação do código
    }

    public void Atirar() {

    }
}

