using UnityEngine;

public class FallingBlock : MonoBehaviour {
    [SerializeField] private float speed = -3.0f;
    private Rigidbody2D rb;
    private Vector2 screenBounds;
    void Start() {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, speed);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }
    void Update() {
        if (transform.position.y < -screenBounds.y) {
            Destroy(this.gameObject);
        }
    }
}