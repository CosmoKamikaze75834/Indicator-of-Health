public class HealthBar : BaseBar
{
    public override void UpdateValue()
    {
        base.UpdateValue();
        Slider.value = Fullness;
    }
}