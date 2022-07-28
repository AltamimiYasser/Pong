using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] BallMovment ballMovment;
    [SerializeField] Paddle playerPaddle;
    [SerializeField] Paddle aiPaddle;
    [SerializeField] TMP_Text playerScoreText;
    [SerializeField] TMP_Text aiScoreText;

    int playerScore;
    int aiScore;

    public void playerScored()
    {
        playerScore++;
        playerScoreText.SetText(playerScore.ToString());
        resetPositions();
    }

    public void AiScored()
    {
        aiScore++;
        aiScoreText.SetText(aiScore.ToString());
        resetPositions();
    }

    void resetPositions()
    {
        ballMovment.ResetPosition();
        playerPaddle.ResetPosition();
        aiPaddle.ResetPosition();
    }

}
