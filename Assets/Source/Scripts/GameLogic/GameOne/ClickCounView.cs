using TMPro;
using UnityEngine;

namespace GameOne
{
    public class ClickCounView : MonoBehaviour
    {
        [SerializeField] private Clicked _clicked;
        [SerializeField] private TextMeshProUGUI _clickCountText;

        private void OnEnable()
        {
            _clicked.ClickChanged += OnClickCountView;
        }

        private void OnDisable()
        {
            _clicked.ClickChanged -= OnClickCountView;
        }

        private void Update()
        {
            OnClickCountView(_clicked.ClickCount);
        }

        private void OnClickCountView(int count)
        {
            _clickCountText.text = count.ToString();
        }
    }
}