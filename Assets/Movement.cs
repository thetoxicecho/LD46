using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    
    public GameObject Player;
    public CharacterController controller;
    public float speed = 10f;
    public float gravity = 9.81f;
    public Rigidbody Phycis;
    public Vector3 velocity;
    // Start is called before the first frame updates
    void Start()
    {
        Phycis = Player.GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space")){
            velocity.y = 5f;
        }


    }
}
