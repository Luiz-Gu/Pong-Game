using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;


public class Player : MonoBehaviour
{
    public bool Isplayer1;
    public float speed; //variavel para regular a velocidade de movimento
    public Rigidbody2D rig;
    public Vector3 startPosition;

    private float direction;//direcao de movimento do objeto

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }
    // Update is called once per frame
    void Update()

    {
        if (Isplayer1)
        {
            direction = Input.GetAxis("Vertical"); //puxa os inputs de teclas da unity/pressiona cima 1 se baixo -1 se nada 0
        }
        else
        {
            direction = Input.GetAxis("Vertical2");
        }
        rig.velocity = new Vector2(rig.velocity.x, direction * speed);
        
    }
    public void Reset()
    {
        rig.velocity = Vector2.zero;
        transform.position = startPosition;
    }

}



   
   