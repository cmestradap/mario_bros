using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goomba : MonoBehaviour
{
    public int speed;
    private bool moveRight;

    private bool isCrushed;
    public Animator animator;

    GameObject player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("player");
    }

    // Update is called once per frame
    void Update()
    {
        if (moveRight)
        {
            transform.Translate(2 * Time.deltaTime * speed, 0, 0);
        }
        else
        {
            transform.Translate(-2 * Time.deltaTime * speed, 0, 0);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("tube") || collision.gameObject.CompareTag("enemies"))
        {
            if (moveRight)
            {
                moveRight = false;
            }
            else
            {
                moveRight = true;
            }
        }

    }
}
