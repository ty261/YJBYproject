using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    private CharacterController cc;
    public float moveSpeed = 5f;
    public float jumpSpeed = 8f;
    private Vector3 dir;
    public float gravity = 15f; // 设置重力为标准地球重力
    private Vector3 velocity;
    public Transform groundCheck;
    public float checkRadius = 0.1f;
    public LayerMask groundLayer;
    private bool isGrounded;

    private void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    private void Update()
    {
        // Check if the player is grounded
        isGrounded = Physics.CheckSphere(groundCheck.position, checkRadius, groundLayer);

        // Apply gravity
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        else
        {
            velocity.y -= gravity * Time.deltaTime;
        }

        // Get input for movement
        float horizontalMove = Input.GetAxis("Horizontal");
        float verticalMove = Input.GetAxis("Vertical");

        // Calculate movement direction
        dir = transform.forward * verticalMove + transform.right * horizontalMove;

        // Move the character
        cc.Move(dir * moveSpeed * Time.deltaTime);

        // Check for jump input
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded) // 当按下空格键且在地面上时执行跳跃
        {
            velocity.y = jumpSpeed;
        }

        // Apply vertical velocity
        cc.Move(velocity * Time.deltaTime);
    }
}
