using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{


    float Speed = 12;
    CharacterController characterController;
    
    
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        Application.targetFrameRate = 60
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
    }


    void PlayerMove()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.forward * z + transform.right * x;
        characterController.SimpleMove(move * Speed * Time.deltaTime);
    }
}
