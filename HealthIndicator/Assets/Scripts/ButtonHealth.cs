
public class ButtonHealth : BaseButton
{
    private void Awake()
    {
        _amount = 25;
    }

    public override void ChangeHealth()
    {
        _health.Heal(_amount);
    }
}