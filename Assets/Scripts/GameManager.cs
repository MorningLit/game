using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static bool isGameOver;
    [SerializeField] private GameObject gameOverScreen;
    private void Awake() {
        isGameOver = false;
    }
    private void Update() {
        if (isGameOver) {
            gameOverScreen.SetActive(true);
            gameObject.SetActive(false);
        }
    }
    public void ReplayLevel() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
