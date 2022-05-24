using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flip : MonoBehaviour
{
    static Rigidbody coin;
    public static Vector3 coinVelocity;
    bool isFlipping = false;
    

    void Start()
    {
        coin = GetComponent<Rigidbody>();
    }

    void Update()
    {
        coinVelocity = coin.velocity;

        //KeyCode assigns which key gets pressed to trigger the "flip"
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //This sets the power of spin you would like and what direction.
            float dirX = Random.Range(0, 500);
            float dirY = Random.Range(0, 500);
            float dirZ = Random.Range(110, 300);

            //This is the coin's starting position and rotation.
            transform.position = new Vector3(0, 2, 0);

            //Quaternion = rotation values
            transform.rotation = Quaternion.identity;

            //This sets the force that it will send the coin upward.
            coin.AddForce(transform.up * 750);
            coin.AddTorque(dirX, dirY, dirZ);
        }

    }
}
