using System.Collections;
using UnityEngine;

public class SmoothHealthBar : BaseBar
{
    [SerializeField] private float _speed;

    private Coroutine _coroutine;
    private float _targetFullness;

    public void Stop()
    {
        if (_coroutine != null)
            StopCoroutine(_coroutine);
    }

    protected override void UpdateValue(float current, float max)
    {
        _targetFullness = current / max;
        Stop();
        _coroutine = StartCoroutine(ChangeValue());
    }

    private IEnumerator ChangeValue()
    {
        while (Slider.value != _targetFullness)
        {
            float current = Mathf.MoveTowards(Slider.value, _targetFullness, _speed * Time.deltaTime);
            Slider.value = current;

            yield return null;
        }
    }
}