using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    Vector2 input;
    bool isMoving = false;
    Vector2 startPos;
    Vector2 endPos;
    float t;

    private Animator animator;

    public float defWalkSpeed = 4f;
    private float walkSpeed = 4f;

    public bool isAllowedToMove = true;
    private Rigidbody2D rb2d;

    void Start()
    {
        startPos = transform.position;
        isAllowedToMove = true;
        animator = GetComponent<Animator>();

        rb2d = GetComponent<Rigidbody2D>();

    }

    private void FixedUpdate()
    {
        float inputX = Input.GetAxisRaw("Horizontal");
        float inputY = Input.GetAxisRaw("Vertical");
        bool run = Input.GetKey("left shift");

        if (!isMoving && isAllowedToMove)
        {
            input = new Vector2(inputX, inputY);
            if (Mathf.Abs(input.x) > Mathf.Abs(input.y))
                input.y = 0;
            else
                input.x = 0;

            if (input != Vector2.zero)
            {
                animator.SetFloat("SpeedX", inputX);
                animator.SetFloat("SpeedY", inputY);
                if (run)
                {
                    walkSpeed = defWalkSpeed * 2;
                }
                else
                {
                    
                    walkSpeed = defWalkSpeed;
                }
                rb2d.velocity = input * walkSpeed;
            }
            else
            {
                rb2d.velocity = input * 0f;
            }

        }

    }

    // Update is called once per frame
    void Update()
    {
        float lastInputX = Input.GetAxisRaw("Horizontal");
        float lastInputY = Input.GetAxisRaw("Vertical");
        bool running = Input.GetKey("left shift");

        if (lastInputX != 0 || lastInputY != 0)
        {
            animator.SetBool("Walking", true);
            if (running)
            {
                animator.SetBool("Running", true);
            }
            else
            {
                animator.SetBool("Running", false);
            }

            if (lastInputX > 0)
            {
                animator.SetFloat("LastMoveX", 1f);
            }
            else if (lastInputX < 0)
            {
                animator.SetFloat("LastMoveX", -1f);
            }
            else
            {
                animator.SetFloat("LastMoveX", 0f);
            }

            if (lastInputY > 0)
            {
                animator.SetFloat("LastMoveY", 1f);
            }
            else if (lastInputY < 0)
            {
                animator.SetFloat("LastMoveY", -1f);
            }
            else
            {
                animator.SetFloat("LastMoveY", 0f);
            }
        }
        else
        {

            animator.SetBool("Walking", false);
            animator.SetBool("Running", false);
        }
    }

    public IEnumerator Move(Transform entity)
    {
        isMoving = true;
        startPos = entity.position;
        t = 0;

        endPos = new Vector2(startPos.x + System.Math.Sign(input.x), startPos.y + System.Math.Sign(input.y));

        while (t < 1f)
        {
            t += Time.deltaTime * walkSpeed;
            
            rb2d.velocity = endPos * t;
            yield return null;
        }

        isMoving = false;
        yield return 0;
    }
}
