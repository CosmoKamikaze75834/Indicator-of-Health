
public class ButtonDamage : BaseButton
{
    private void Awake()
    {
        _amount = 25;
    }

    public override void ChangeHealth()
    {
        _health.TakeDamage(_amount);
    }
}