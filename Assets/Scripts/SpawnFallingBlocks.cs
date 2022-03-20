using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFallingBlocks : MonoBehaviour
{
    [SerializeField] private GameObject fallingBlockPrefab;
    [SerializeField] private float respawnTime = 0.1f;
    private Vector2 screenBounds;
    void Awake() {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }
    void Start()
    {
        StartCoroutine(blockWave());
    }
    private void spawn() {
        Vector2 pos = new Vector2(Random.Range(-screenBounds.x + 1, screenBounds.x - 1), screenBounds.y);
        Instantiate(fallingBlockPrefab, pos, Quaternion.identity);
    }
    IEnumerator blockWave() {
        while (!GameManager.isGameOver) {
            yield return new WaitForSeconds(respawnTime);
            spawn();
        }
    }

}
