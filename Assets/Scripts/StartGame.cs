using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    #region Variables

    [SerializeField] private Button _startButton;
    [SerializeField] private Button _exitButton;

    #endregion

    #region Unity lifecycle

    private void Start()
    {
        {
            _startButton.onClick.AddListener(StartScene);
            _exitButton.onClick.AddListener(ExitScene);
        }
    }

    #endregion

    #region Private methods

    private void ExitScene()
    {
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }

    private void StartScene()
    {
        SceneManager.LoadScene("GameScene");
    }

    #endregion
}