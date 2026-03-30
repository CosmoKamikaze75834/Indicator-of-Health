using UnityEngine;

public class SmoothHealthBar : BaseBar
{
    [SerializeField] private float _speed;

    private void Update()
    {
        float current = Mathf.MoveTowards(Slider.value, Fullness, _speed * Time.deltaTime);
        Slider.value = current;
    }

    public override void UpdateValue()
    {
        base.UpdateValue();
    }
}