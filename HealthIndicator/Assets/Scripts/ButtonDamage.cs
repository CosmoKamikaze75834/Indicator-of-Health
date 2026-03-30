
public class ButtonDamage : BaseButton
{
    public override void ChangeHealth()
    {
        Health.TakeDamage(Amount);
    }
}