using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
    public GameObject jugador;
    public float totalPoints;
    private float colorRedR;
    private float colorRedG;
    private float colorRedB;
    private Color origCol;
    private Vector3 origSize;
    private float sizeRedX;
    private float sizeRedY;
    private float sizeRedZ;
    public float distance;

    private void Start()
    {
        origCol = gameObject.GetComponent<Renderer>().material.color;
        origSize = transform.localScale;
        colorRedR = origCol.r / totalPoints;
        colorRedG = origCol.g / totalPoints;
        colorRedB = origCol.b / totalPoints;
        sizeRedX= origSize.x / totalPoints;
        sizeRedY= origSize.y / totalPoints;
        sizeRedZ= origSize.z / totalPoints;

    }

    //Afectamos al color y la ganancia de puntos en función del tamaño del objeto
    void Update(){
        if (Vector3.Distance(jugador.transform.position, transform.position)<=distance){
            Score.scorePoints += 10;
            totalPoints -= 1;
            if (totalPoints<=0){
                Destroy(gameObject);
            }
            origCol= new Color(origCol.r - colorRedR, origCol.g - colorRedG, origCol.b - colorRedB);
            gameObject.GetComponent<Renderer>().material.color = origCol;
            origSize = new Vector3(origSize.x-sizeRedX, origSize.y-sizeRedY, origSize.z-sizeRedZ);
            transform.localScale = origSize;

        }
    }
}
