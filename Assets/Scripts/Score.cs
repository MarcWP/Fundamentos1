using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public static int scorePoints=0;
    private Text score;

    private void Start(){
        score = GetComponent<Text>();
    }

    //Actualizamos la puntuación que podemos modificar con una variable pública, métodos públicos, eventos, etc
    void Update(){
   
        score.text = "Puntos:" + scorePoints;
    }
}
