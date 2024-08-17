using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MagicNumberUI : MonoBehaviour
{
    #region Variables

    [Header("UI")]
    [SerializeField] private TMP_Text _guessLabel;
    [SerializeField] private TMP_Text _attemptLabel;
    [SerializeField] private Button _upButton;
    [SerializeField] private Button _guessButton;
    [SerializeField] private Button _downButton;
    [Header("Counter")]
    [SerializeField] private int _attempts;
    [SerializeField] private int _guess;
    [SerializeField] private int _magicNumber;

    #endregion

    #region Unity lifecycle

    private void Start()
    {
        StartGame();
        _upButton.onClick.AddListener(Up);
        _guessButton.onClick.AddListener(Guess);
        _downButton.onClick.AddListener(Down);
        UpdateUI();
    }

    #endregion

    #region Private methods

    private void CheckGuess()
    {
        if (_guess == _magicNumber)
        {
            WinGame();
        }
        else if (_guess > _magicNumber)
        {
            Debug.Log("Меньше!");
        }
        else
        {
            Debug.Log("Больше!");
        }

        UpdateUI();
    }

    private void Down()
    {
        if (_guess > 1)
        {
            _guess--;
            _attempts++;
            CheckGuess();
        }
    }

    private void Guess()
    {
        WinGame();
    }

    private void StartGame()
    {
        _magicNumber = Random.Range(1, 20);
        _attempts = 0;
        _guess = 10;
    }

    private void Up()
    {
        if (_guess < 20)
        {
            _guess++;
            _attempts++;
            CheckGuess();
        }
    }

    private void UpdateUI()
    {
        _guessLabel.text = $"Текущий предположение: {_guess}";
        _attemptLabel.text = $"Количество попыток: {_attempts}";
    }

    private static void WinGame()
    {
        SceneManager.LoadScene("WinScene");
    }

    #endregion
}