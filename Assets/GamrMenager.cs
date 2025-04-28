using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class GamrMenager : MonoBehaviour
{
    public Button startButton;
    public Button restartButton;

    public TextMeshProUGUI hpText;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timerText;

    private int hp = 100;
    private int score = 0;
    private float timer = 60f; // เริ่มจาก 60 วินาที
    private bool isPlaying = false;

    void Start()
    {
        startButton.onClick.AddListener(StartGame);
        restartButton.onClick.AddListener(RestartGame);

        UpdateUI();
    }

    void Update()
    {
        if (isPlaying)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                timer = 0;
                isPlaying = false;
                // ใส่โค้ดจบเกมได้
            }
            UpdateUI();
        }
    }

    void StartGame()
    {
        isPlaying = true;
    }

    void RestartGame()
    {
        hp = 100;
        score = 0;
        timer = 60f;
        isPlaying = true;
        UpdateUI();
    }

    void UpdateUI()
    {
        hpText.text = "HP: " + hp;
        scoreText.text = "Score: " + score;
        timerText.text = "Time: " + Mathf.Ceil(timer);
    }
}



