using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement2D : MonoBehaviour
{
    public GameObject inv;
    public static float moveSpeed = 50;
    public float jumpForce = 1;
    public Rigidbody2D rb;
    public Transform wheel1;
    public Transform wheel2;
    public Transform groundCheck;
    public LayerMask groundLayer;
    public static int wheelSpeed = 250;
    public static float maxMoveSpeed = 6;
    //The maximum amount of time that can pass between the player leaving the ground and pressing the spacebar to jump
    public float gTime;
    //If you press the spacebar just before grounding it will jump after (this variable stores the max delay)
    public float jTime;
    [Range(0, 50)]
    public static float friction = 34;

    //debug variables
    public bool isGrounded = false;
    public int direction = 0;
    public float lastGrounded;
    public float lastJumped;
    public Vector2 velocity;

    private float scaleX;

    public void move(InputAction.CallbackContext ctx)
    {
        direction = (int)ctx.ReadValue<float>();
        updateDirection(direction);
    }
    public void jump(InputAction.CallbackContext ctx)
    {
        if (Time.realtimeSinceStartup - lastGrounded < gTime)
        {
            rb.AddForce(new Vector2(0, ctx.ReadValue<float>() * jumpForce), ForceMode2D.Impulse);
        }
        else
        {
            lastJumped = Time.realtimeSinceStartup;
        }
    }
    private void FixedUpdate()
    {
        wheel1.Rotate(new Vector3(0, 0, -wheelSpeed * Time.fixedDeltaTime * Time.timeScale * Mathf.Abs(rb.velocity.x)));
        wheel2.Rotate(new Vector3(0, 0, -wheelSpeed * Time.fixedDeltaTime * Time.timeScale * Mathf.Abs(rb.velocity.x)));
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.15f, groundLayer);
        velocity = rb.velocity;
        if (isGrounded)
        {
            rb.AddForce(new Vector2(direction * moveSpeed * Time.fixedDeltaTime * Time.timeScale, 0), ForceMode2D.Impulse);
            lastGrounded = Time.realtimeSinceStartup;

            if (direction == 0)
            {
                //Keep the player from sliding
                rb.AddForce(new Vector2(-rb.velocity.x * Time.fixedDeltaTime * Time.timeScale * friction, 0), ForceMode2D.Impulse);
            }
            if (Time.realtimeSinceStartup - lastJumped < jTime)
            {
                rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            }
        }
        else
        {
            //If the player is in the air, apply a less strong force
            rb.AddForce(new Vector2(direction * moveSpeed * 0.1f * Time.fixedDeltaTime * Time.timeScale, 0), ForceMode2D.Impulse);
        }
        //Limit horizontal velocity
        if (rb.velocity.x > maxMoveSpeed)
        {
            rb.AddForce(new Vector2(maxMoveSpeed, 0) - new Vector2(rb.velocity.x, 0) * Time.fixedDeltaTime * 50 * Time.timeScale, ForceMode2D.Impulse);
        }
        if (rb.velocity.x < -maxMoveSpeed)
        {
            rb.AddForce(new Vector2(-maxMoveSpeed, 0) - new Vector2(rb.velocity.x, 0) * Time.fixedDeltaTime * 50 * Time.timeScale, ForceMode2D.Impulse);
        }
    }
    public void updateDirection(int direction)
    {
        if (direction == -1)
        {
            transform.localScale = new Vector2(-scaleX, transform.localScale.y);
        }
        if (direction == 1)
        {
            transform.localScale = new Vector2(scaleX, transform.localScale.y);
        }
    }
    private void Start()
    {
        scaleX = transform.localScale.x;
    }
    public void toggleInv(InputAction.CallbackContext ctx)
    {
        if (ctx.ReadValue<int>() == 1)
        {
            inv.SetActive(!inv.activeSelf);
        }
    }
}
