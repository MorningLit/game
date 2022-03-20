using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float playerSpeed = 7.0f;
    private Rigidbody2D rb;
    private Vector2 movement;
    private Inventory inventory;
    [SerializeField] private UI_Inventory ui_inventory;
    
    void Awake() {
        rb = this.GetComponent<Rigidbody2D>();
        inventory = new Inventory(); 
        ui_inventory.SetInventory(inventory);
    }
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        movement = new Vector2(Input.GetAxis("Horizontal"), 0); 
    }
    void FixedUpdate() {
        moveCharacter(movement);
    }
    void moveCharacter(Vector2 dir) {
        rb.MovePosition((Vector2)transform.position + (dir * playerSpeed * Time.deltaTime)); // do not actually have to multiply by Time.deltaTime cus of FixedUpdate;
    }
    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("Death")) {
            GameManager.isGameOver = true;
        }
    }
}
