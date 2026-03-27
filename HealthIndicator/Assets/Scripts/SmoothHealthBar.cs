using UnityEngine;

public class SmoothHealthBar : BaseBar
{
    [SerializeField] private float _speed;

    public override void UpdateValue()
    {
        base.UpdateValue();
        float current = Mathf.MoveTowards(_slider.value, fullness, _speed * Time.deltaTime);
        _slider.value = current;
    }
}