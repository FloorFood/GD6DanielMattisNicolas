using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinnerMovement : MonoBehaviour
{
    public float maxMoveSpeed = 10;
    public float smoothTime = 0.3f;
    public float minDistance = 2;
    public float gravity = 1;
    float horizontalMove = 0f;

    public bool Following = false;

    public Animator animator;

    Vector2 currentVelocity;

    public GameObject Player;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Following = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal");
        animator.SetFloat("speed", Mathf.Abs(horizontalMove));
        //Debug.Log("Moving at: " + horizontalMove + "speeds/update");

        if (Following)
        {
            Vector2 playerPosition = Player.transform.position;
            // Offsets the target position so that the object keeps its distance.
            playerPosition += ((Vector2)transform.position - playerPosition).normalized * minDistance;
            transform.position = Vector2.SmoothDamp(transform.position, playerPosition, ref currentVelocity, smoothTime, maxMoveSpeed);

            gameObject.GetComponent<Rigidbody2D>().gravityScale = gravity;
        }
        else return;
    }
}
