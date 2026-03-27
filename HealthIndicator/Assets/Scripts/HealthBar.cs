public class HealthBar : BaseBar
{
    public override void UpdateValue()
    {
        base.UpdateValue();
        _slider.value = fullness;
    }
}