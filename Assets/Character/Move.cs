using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public int speed;
    public float moveHorizontal;
    public float jumpForce;
    public Rigidbody2D rb;
    private bool isFlip = true;
    public BoxCollider2D col;
    public LayerMask Ground;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        if(Input.GetKeyDown(KeyCode.Space) && IsGround())
        {
            Jump();
        }
        if(moveHorizontal > 0 && !isFlip)
        {
            Flip();
        }
        else if(moveHorizontal < 0 && isFlip)
        {
            Flip();
        }
    }
    public void Movement()
    {
        moveHorizontal = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveHorizontal * speed, rb.velocity.y);

    }
    public void Jump()
    {
        rb.velocity = Vector2.up * jumpForce;
    }
    public void Flip()
    {
        isFlip = !isFlip;
        Vector3 currentScale = gameObject.transform.localScale;
        currentScale.x*= -1;
        gameObject.transform.localScale = currentScale;
    }
    private bool IsGround()
    {
        return Physics2D.BoxCast(col.bounds.center, col.bounds.size, 0f, Vector2.down, 0.1f, Ground);
    }
    
}
