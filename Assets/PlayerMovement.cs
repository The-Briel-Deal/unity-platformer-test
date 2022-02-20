using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float horiInput = 0f;
    public bool jump = false;
    public CharacterController2D controller;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        jump = Input.GetButton("Jump");
        horiInput = Input.GetAxis("Horizontal");
        Debug.Log(horiInput.ToString());
        controller.Move(horiInput, false, jump);
    }
}

