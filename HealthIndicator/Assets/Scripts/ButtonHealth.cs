
public class ButtonHealth : BaseButton
{
    public override void ChangeHealth()
    {
        Health.Increase(Amount);
    }
}