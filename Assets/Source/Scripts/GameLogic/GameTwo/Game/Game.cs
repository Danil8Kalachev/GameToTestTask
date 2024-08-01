using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private GameObject _panel;
    [SerializeField] private Button _exitMenuButton;

    private void Awake()
    {
        _panel.SetActive(false);
        Time.timeScale = 1f;
    }

    private void OnEnable()
    {
        _exitMenuButton?.onClick.AddListener(OnExitMenu);
    }

    private void OnDisable()
    {
        _exitMenuButton?.onClick.RemoveListener(OnExitMenu);
    }

    private void OnExitMenu()
    {
        SceneManager.LoadScene(Constants.MENUSCENE);
    }

    public void OnShowPanel()
    {
        _panel.SetActive(true);
        Time.timeScale = 0f;
    }
}