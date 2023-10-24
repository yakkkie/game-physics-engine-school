using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField]
    float walkSpeed, runSpeed, rotationSpeed;

    [SerializeField]
    Animator animator;

    Vector3 newPos;

    Rigidbody body;

    CharacterController characterController;


    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    //void Update()
    //{
    //
    //    newPos = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
    //
    //    //transform.Rotate(0.0f, newPos.x * rotationSpeed * Time.deltaTime, 0.0f);
    //
    //    if (Input.GetKey(KeyCode.LeftShift) && newPos.z == 1)
    //    {
    //        animator.SetFloat("PosX", newPos.x);
    //        animator.SetFloat("PosZ", newPos.z);
    //        characterController.Move(newPos * Time.deltaTime * runSpeed);
    //    }
    //    else
    //    {
    //        animator.SetFloat("PosX", newPos.x / 2);
    //        animator.SetFloat("PosZ", newPos.z / 2);
    //        characterController.Move(newPos * Time.deltaTime * walkSpeed);
    //    }
    //
    //
    //}


    void Update()
    {
        float hInput = Input.GetAxis("Horizontal");
        float vInput = Input.GetAxis("Vertical");
        float speed = walkSpeed;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = walkSpeed * 2.0f;
        }
        if (animator == null) return;
        transform.Rotate(0.0f , hInput * rotationSpeed * Time.deltaTime,
        0.0f);
        Vector3 forward =
        transform.TransformDirection(Vector3.forward).normalized;
        forward.y = 0.0f;
        characterController.Move(forward * vInput * speed *
        Time.deltaTime);
        animator.SetFloat("PosX", 0);
        animator.SetFloat("PosZ", vInput * speed / 2.0f * walkSpeed);

    }

}

