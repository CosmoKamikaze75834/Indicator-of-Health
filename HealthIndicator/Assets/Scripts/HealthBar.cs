public class HealthBar : BaseBar
{
    protected override void UpdateValue(float current, float max)
    {
        float currentHeal = current / max;
        Slider.value = currentHeal;
    }
}