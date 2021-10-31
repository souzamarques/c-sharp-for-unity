using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variaveis : MonoBehaviour {

    int vidaPlayer = 50, vidaEnemy = 10;
    string nomePlayer = "Hero";
    float tempo;
    bool mortePlayer = false;

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        tempo = tempo + Time.deltaTime;
        Debug.Log(tempo);
    }
}