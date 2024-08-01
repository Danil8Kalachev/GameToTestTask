using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _recordTime;
    [SerializeField] private TextMeshProUGUI _timerText;
    [SerializeField] private Game _game;

    private void Awake()
    {
        _recordTime = 0;
        _recordTime = PlayerPrefs.GetFloat(Constants.RECORDSAVE, _recordTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out House house))
        {
            IsPlaying(play: false);
            _game.OnShowPanel();
        }
    }

    private void Update()
    {
        if (IsPlaying(play: true))
        {
            _recordTime += Time.deltaTime;
            PlayerPrefs.SetFloat(Constants.RECORDSAVE, _recordTime);
            _timerText.text = "Record:" + _recordTime.ToString();
        }
    }

    private bool IsPlaying(bool play)
    {
        return true;
    }
}