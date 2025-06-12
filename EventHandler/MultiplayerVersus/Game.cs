namespace MultiplayerVersus;

public class Game
{
    private readonly List<Player> _players;
    private readonly Random _random = new();

    public Game()
    {
        _players = new List<Player>
        {
            new Player("Player 1", 100),
            new Player("Player 2", 100),
            new Player("Player 3", 100),
            new Player("Player 4", 100),
        };

        foreach (var player in _players)
        {
            player.TookDamage += OnPlayerTookDamage;
            player.Defeated += OnPlayerDefeated;
        }
    }

    public void Start()
    {
        Console.WriteLine("Starting Free-for-All!");
        int roundNumber = 1;

        while (_players.Count(p => p.IsAlive) > 1)
        {
            Console.WriteLine($"Round {roundNumber} Fight!");
            Console.WriteLine("=====");

            foreach (var attacker in _players.Where(p => p.IsAlive).ToList())
            {
                var targets = _players.Where(p => p.IsAlive && p != attacker).ToList();
                if (!targets.Any())
                    break;

                var target = targets[_random.Next(targets.Count)];
                int damage = _random.Next(5, 30);
                Console.WriteLine($"{attacker.Name} attacks {target.Name} for {damage} damage!");
                target.TakeDamage(damage);

                Console.WriteLine();
                System.Threading.Thread.Sleep(500); // for pacing
            }

            roundNumber++;
            Console.ReadLine();
        }

        var winner = _players.FirstOrDefault(p => p.IsAlive);
        Console.WriteLine(winner != null
            ? $"{winner.Name} wins the game!"
            : "No one survived!");
    }

    private void OnPlayerTookDamage(object? sender, PlayerDamageEventArgs e)
    {
        var player = (Player)sender!;
        Console.WriteLine($"{player.Name} took {e.Damage} damage. Remaining HP: {e.RemainingHP}");
    }

    private void OnPlayerDefeated(object? sender, EventArgs e)
    {
        var player = (Player)sender!;
        Console.WriteLine($"{player.Name} has been defeated!");
    }
}
