using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    [SerializeField] private Button _startButton;
    [SerializeField] private Button _exitButton;
    
   private void Start()
    {
        {
            _startButton.onClick.AddListener(StartGameScene);
            _exitButton.onClick.AddListener(ExitScene);
        }

        private void StartGameScene()
        {
            SceneManager.LoadScene("GameMagicNumberUI");
        }

        private void ExitScene()
        {
            Application.Quit();
        }
    }
   

   
}
