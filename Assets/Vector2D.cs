using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector2D : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector2 startpoint;
    public Vector2 endpoint;
    public Vector2 distance;
    // Start is called before the first frame update
    void Start()
    {
        print("Welcome To the Game");
        print("Use KeyBoard to play the Game");
        print("Use UpArrow to Move forward");
        print("Use DownArrow to Move Back");
        print("Use LeftArrow to Move Left");
        print("Use RightArrow to Move Right");
        distance = startpoint - endpoint;
        print("Distance is:" + distance.magnitude);
        if (startpoint.magnitude > endpoint.magnitude)
        {
            print("Move Forward");
        }
        else if (startpoint.magnitude < endpoint.magnitude)
        {
            print("Move Backward");
        }
        else
        {
            print("You Reached the destinaton");
        }



    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement(KeyCode.UpArrow, new Vector2(0, 1));
        PlayerMovement(KeyCode.DownArrow, new Vector2(0, -1));
        PlayerMovement(KeyCode.LeftArrow, new Vector2(-1, 0));
        PlayerMovement(KeyCode.RightArrow, new Vector2(1, 0));

    }

    private void PlayerMovement(KeyCode arrow, Vector2 values)
    {
        Method(arrow, values);
    }
    private void Method(KeyCode arrow, Vector2 values)
    {
        if (Input.GetKeyDown(arrow))
        {
            startpoint = startpoint + values;
            distance = startpoint - endpoint;
            print("Distance is: " + distance);
            if (startpoint == endpoint)
            {
                print("You reached your Denstination");
            }

        }
    }
}
