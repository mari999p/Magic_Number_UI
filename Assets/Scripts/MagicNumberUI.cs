using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MagicNumberUI : MonoBehaviour
{
    [SerializeField] private TMP_Text _guessLabel;
    [SerializeField] private TMP_Text _attemptLabel;
    private int _magicNumber;
    private int _guess;
    private int _attempts;
    #region Unity lifecycle

    private void Start()
    {
        _magicNumber = Random.Range(1, 101);
        _guess = 50;
        _attempts = 0;
        UpdateUI();
    }

    public void Higner()
    {
        _guess++;
        _attempts++;
        CheckGuess();
    }

    private void CheckGuess()
    {
        if (_guess > _magicNumber)
        {
            _guessLabel.text = "Уменьшите ваше число";
        }
        else if (_guess < _magicNumber)
        {
            _guessLabel.text = "Увеличьте ваше число";
        }
        else
        {
            WinScene();
        }
    }

    private static void WinScene()
    {
        SceneManager.LoadScene("WinScene");
    }

    private void UpdateUI()
    {
        _guessLabel.text = $"Текущий guess: '{_guess}'";
        _attemptLabel.text = $"Количество попыток: '{_attempts}'";
    }
    #endregion
}