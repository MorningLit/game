using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float playerSpeed = 7.0f;
    private Rigidbody2D rb;
    private Vector2 movement;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")); 
    }
    void FixedUpdate() {
        moveCharacter(movement);
    }
    void moveCharacter(Vector2 dir) {
        rb.MovePosition((Vector2)transform.position + (dir * playerSpeed * Time.deltaTime));
    }
    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("Death")) {
            GameManager.isGameOver = true;
        }
    }
}
