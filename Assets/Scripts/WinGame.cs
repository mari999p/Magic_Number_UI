using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinGame : MonoBehaviour
{
    #region Variables

    [SerializeField] private Button _playAgain;
    [SerializeField] private Button _exitGame;

    #endregion

    #region Unity lifecycle

    private void Start()
    {
        _playAgain.onClick.AddListener(PlayAgain);
        _exitGame.onClick.AddListener(ExitGame);
    }

    #endregion

    #region Private methods

    private void ExitGame()
    {
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }

    private void PlayAgain()
    {
        SceneManager.LoadScene("GameScene");
    }

    #endregion
}