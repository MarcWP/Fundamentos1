using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interchange : MonoBehaviour
{
    public GameObject one;
    public GameObject two;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("cambiazo",0f,2f);
    }

    //cambiazo de la posición de dos objetos
    void cambiazo(){
        Vector3 pos=one.transform.position;
        one.transform.position = two.transform.position;
        two.transform.position = pos;
    }
}
