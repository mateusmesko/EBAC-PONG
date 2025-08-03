using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[DefaultExecutionOrder(-1)]
public class GameManager : MonoBehaviour
{
    [SerializeField] private Ball ball;
    [SerializeField] private Paddle playerPaddle;
    [SerializeField] private Paddle computerPaddle;
    [SerializeField] private Text playerScoreText;
    [SerializeField] private Text computerScoreText;
    [SerializeField] private int scoreMax;
    private int playerScore;
    private int computerScore;
    public string sceneToOpen;
    private void Start()
    {
        NewGame();
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) {
            NewGame();
        }
    }

    public void NewGame()
    {
        SetPlayerScore(0);
        SetComputerScore(0);
        NewRound();
    }

    public void NewRound()
    {
        playerPaddle.ResetPosition();
        computerPaddle.ResetPosition();
        ball.ResetPosition();

        CancelInvoke();
        Invoke(nameof(StartRound), 1f);
    }

    private void StartRound()
    {
        ball.AddStartingForce();
    }

    public void OnPlayerScored()
    {
        SetPlayerScore(playerScore + 1);
        NewRound();
    }

    public void OnComputerScored()
    {
        SetComputerScore(computerScore + 1);
        NewRound();
    }

    private void SetPlayerScore(int score)
    {
        if(score > SaveController.Instance.score)
        {
            SaveController.Instance.score = score;
        }
        playerScore = score;
        CheckEndGame(score);
        playerScoreText.text = score.ToString();
    }
    
    private void SetComputerScore(int score)
    {
        computerScore = score;
        CheckEndGame(score);
        computerScoreText.text = score.ToString();
    }
    private void CheckEndGame(int score)
    {
        if (score == scoreMax)
        {
            SceneManager.LoadScene("END_GAME");
        }
    }
    private void Reset()
    {
        SaveController.Instance.colorPlayer = Color.white;
        SaveController.Instance.namePlayer = "";
        SaveController.Instance.score = 0;
    }

}
