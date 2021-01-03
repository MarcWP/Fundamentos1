using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 0;
    private CharacterController cc;

    //Usamos un characterController
    private void Start()
    {
        cc = gameObject.GetComponent<CharacterController>();
    }

    //Mendiante inputs controlamos al personaje
    void Update()
    {
        cc.Move(speed * Time.deltaTime * (transform.forward * Input.GetAxis("Vertical") + transform.right * Input.GetAxis("Horizontal")));
    }
}
