using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    [SerializeField] private Button _gameOneButton;
    [SerializeField] private Button _gameTwoButton;

    private void OnEnable()
    {
        _gameOneButton?.onClick.AddListener(StartGameOne);
        _gameTwoButton?.onClick.AddListener(StartGameTwo);
    }

    private void OnDisable()
    {
        _gameOneButton.onClick.RemoveListener(StartGameOne);
        _gameTwoButton.onClick.RemoveListener(StartGameTwo);
    }

    private void StartGameOne()
    {
        SceneManager.LoadScene(Constants.GAMEONESCENE);
    }

    private void StartGameTwo()
    {
        SceneManager.LoadScene(Constants.GAMETWOSCENE);
    }
}