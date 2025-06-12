namespace MultiplayerVersus;

public class PlayerDamageEventArgs :EventArgs
{
    public int Damage { get; set; }
    public int RemainingHP { get; set; }

    public PlayerDamageEventArgs(int damage, int remainingHP)
    {
        Damage = damage;
        RemainingHP = remainingHP;
    }
}
