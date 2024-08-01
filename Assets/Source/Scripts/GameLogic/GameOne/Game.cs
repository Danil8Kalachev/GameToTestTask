using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace GameOne
{
    public class Game : MonoBehaviour
    {
        [SerializeField] private Button _exitMenuButton;

        private void OnEnable()
        {
            _exitMenuButton.onClick.AddListener(OnExitMenu);
        }

        private void OnDisable()
        {
            _exitMenuButton?.onClick.RemoveListener(OnExitMenu);
        }

        private void OnExitMenu()
        {
            SceneManager.LoadScene(Constants.MENUSCENE);
        }
    }
}