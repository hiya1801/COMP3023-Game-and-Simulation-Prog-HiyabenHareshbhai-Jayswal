using UnityEngine;

public class GoalZone : MonoBehaviour
{
    public bool isLeftGoal;
    public PongGameManager gameManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ball"))
        {
            if (isLeftGoal)
                gameManager.ScoreRight();
            else
                gameManager.ScoreLeft();
        }
    }
}