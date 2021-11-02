using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dicionarios : MonoBehaviour {

    Dictionary<string, string> viloes = new Dictionary<string, string>();

    // Start is called before the first frame update
    void Start() {
        viloes.Add("Ceifador", "Ceifador é o vilão da primeira fase. " +
                    "Altura: 180cm, " +
                    "Força: 200, " +
                    "Velocidade: 20");
        viloes.Add("Exterminador", "Exterminador é o vilão da segunda fase. " +
                    "Altura: 200cm, " +
                    "Força: 500, " +
                    "Velocidade: 50");
        viloes.Add("Figurante", "Figurante é o mini-vilão mais fraco em todas as fases" +
                    "altura: 160cm" +
                    "força: 10" +
                    "velocidade: 5");

        viloes.Remove("Figurante");
        int tamanhoDicionario = viloes.Count;

        print(viloes["Exterminador"]);
        print(viloes["Ceifador"]);
    }

    // Update is called once per frame
    void Update() {
        
    }
}
