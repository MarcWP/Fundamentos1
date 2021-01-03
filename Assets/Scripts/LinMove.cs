using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class LinMove : MonoBehaviour
{
    public float distance;
    public float duration;
    public float delay;
    public GameObject endpoint;
    
    void Start(){
        Invoke("irPaBajo", 0f);

    }

    //Control de movimiento con move, podemos usar invoke o invokerepeat
    void irPaBajo(){
        transform.DOLocalMove(new Vector3(endpoint.transform.position.x,endpoint.transform.position.y,endpoint.transform.position.z), duration, false).SetEase(Ease.InOutCubic).SetDelay(delay).SetLoops(2, LoopType.Yoyo);
        Invoke("irPaBajo", duration * 2 + delay);

    }

}
