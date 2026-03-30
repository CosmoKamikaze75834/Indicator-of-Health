using System.Collections;
using UnityEngine;

public class SmoothHealthBar : BaseBar
{
    [SerializeField] private float _speed;

    private Coroutine _coroutine;

    public void Stop()
    {
        if (_coroutine != null)
            StopCoroutine(_coroutine);
    }

    public override void UpdateValue()
    {
        base.UpdateValue();
        _coroutine = StartCoroutine(ChangeValue());
    }

    private IEnumerator ChangeValue()
    {
        while (Slider.value != Fullness)
        {
            float current = Mathf.MoveTowards(Slider.value, Fullness, _speed * Time.deltaTime);
            Slider.value = current;

            yield return null;
        }
    }
}