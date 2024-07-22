using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public TextMeshProUGUI textScore;

    int score;

    void Awake()
    {
        instance = this;
    }

    public void IncreaseScore(int increment)
    {
        score += increment;
        textScore.text = "Ñ÷¸ò: " + score;
    }
}