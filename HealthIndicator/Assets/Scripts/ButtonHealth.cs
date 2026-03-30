
public class ButtonHealth : BaseButton
{
    public override void ChangeHealth()
    {
        Health.ApplyHeal(Amount);
    }
}