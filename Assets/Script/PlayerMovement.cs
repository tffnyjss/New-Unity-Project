using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    void start()
    {
        // use this function to initialize
        // anything
    }

    // Update is called once per frame
    void update()
    {
        MainPlayer.velocity() = new Vector2(Input.GetAxisRaw("Horizontal") * speed, Input.GetAxisRaw("Vertical") * 2);
    }

}
