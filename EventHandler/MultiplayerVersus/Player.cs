namespace MultiplayerVersus;

public class Player
{
    public string Name { get; set; }
    public int HP { get; private set; }
    public bool IsAlive
    {
        get
        {
            return HP > 0;
        }
    }

    public event EventHandler<PlayerDamageEventArgs> TookDamage;
    public event EventHandler Defeated;

    public Player(string name, int initialHP)
    {
        Name = name;
        HP = initialHP;
    }

    public void TakeDamage(int damage)
    {
        if (!IsAlive)
            return;

        HP -= damage;
        HP = Math.Max(HP, 0);

        TookDamage?.Invoke(this, new PlayerDamageEventArgs(damage, HP));

        if(HP <= 0)
        {
            Defeated?.Invoke(this, EventArgs.Empty);
        }
    }
}
