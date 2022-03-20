using UnityEngine;

public class FallingBlock : MonoBehaviour {
    [SerializeField] private float speed = -3.0f;
    private Rigidbody2D rb;
    private Vector2 screenBounds;
    void Awake() {
        rb = this.GetComponent<Rigidbody2D>();
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        rb.velocity = new Vector2(0, speed);
    }
    void Start() {
    }
    void Update() {
        if (transform.position.y < -screenBounds.y) {
            Destroy(this.gameObject);
        }
    }
}