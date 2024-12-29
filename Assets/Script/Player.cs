using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector2 move_dir;
    [SerializeField] private Rigidbody2D rb2d;
    [SerializeField] float move_speed;

    private void Awake()
    {
        move_dir.x = 0;
        move_dir.y = 0;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }

    void PlayerMovement()
    {
        rb2d.velocity = new Vector2(move_dir.x, move_dir.y) * move_speed * Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.W))
        {
            move_dir.x = 0;
            move_dir.y = 1;
        }
        else if(Input.GetKeyDown(KeyCode.S))
        {
            move_dir.x = 0;
            move_dir.y = -1;
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            move_dir.x = -1;
            move_dir.y = 0;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            move_dir.x = 1;
            move_dir.y = 0;
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            move_dir.x = 0;
            move_dir.y = 0;
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            move_dir.x = 0;
            move_dir.y = 0;
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            move_dir.x = 0;
            move_dir.y = 0;
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            move_dir.x = 0;
            move_dir.y = 0;
        }
    }
}
