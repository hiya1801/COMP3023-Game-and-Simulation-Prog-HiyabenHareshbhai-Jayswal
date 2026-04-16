using TMPro;
using UnityEngine;

public class PongGameManager : MonoBehaviour
{
    public TextMeshProUGUI leftScoreText;
    public TextMeshProUGUI rightScoreText;
    public BallController ball;

    private int leftScore = 0;
    private int rightScore = 0;

    void Start()
    {
        UpdateUI();
    }

    public void ScoreLeft()
    {
        leftScore++;
        UpdateUI();
        ball.ResetBall();
    }

    public void ScoreRight()
    {
        rightScore++;
        UpdateUI();
        ball.ResetBall();
    }

    void UpdateUI()
    {
        leftScoreText.text = leftScore.ToString();
        rightScoreText.text = rightScore.ToString();
    }
}