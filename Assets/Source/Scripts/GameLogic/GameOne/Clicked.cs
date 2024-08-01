using System;
using UnityEngine;
using UnityEngine.UI;

namespace GameOne
{
    public class Clicked : MonoBehaviour
    {
        [SerializeField] private int _clickCount;
        [SerializeField] private Button _clickButton;

        public int ClickCount => _clickCount;

        public event Action<int> ClickChanged;

        private void Awake()
        {
            _clickCount = 0;
            ClickChanged?.Invoke(_clickCount);
            _clickCount = PlayerPrefs.GetInt(Constants.COUNTSAVE, _clickCount);
        }

        private void OnEnable()
        {
            _clickButton?.onClick.AddListener(OnClick);
        }

        private void OnDisable()
        {
            _clickButton?.onClick.RemoveListener(OnClick);
        }

        private void OnClick()
        {
            _clickCount++;
            ClickChanged?.Invoke(_clickCount);
            PlayerPrefs.SetInt(Constants.COUNTSAVE, _clickCount);
        }
    }
}