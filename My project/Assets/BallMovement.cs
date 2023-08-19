using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.WSA;

public class BallMovement : MonoBehaviour
{
    public float speed = 5f;//velocidade da bola
    public Rigidbody2D rig;
    public Vector3 startPosition;

    public void Reset()
    {
        rig.velocity = Vector2.zero;
        transform.position = startPosition;
        Launch();
    }


    // Start is called before the first frame update
    void Start()
    {
        Launch();
    }

    // Update is called once per frame
    void Update()

    {
        
    }
    private void Launch()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        rig.velocity = new Vector2(speed * x, speed * y);


    }
}
