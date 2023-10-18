using System.Collections.Immutable;

namespace CodeWarts.Infrastructure.Implementations.CardGame;

public static class CardGame1
{
    private static readonly Dictionary<int, string> PlayersCards = new();

    private static readonly ImmutableList<string> Players =
        new List<string>() { "Frank", "Sam", "Tom" }.ToImmutableList();

    private static readonly Dictionary<string, int> PlayersScores = new();

    public static bool Game(int[] frank, int[] sam, int[] tom)
    {
        Convert(new List<int[]>() { frank, sam, tom });

        return Game(PlayersCards.First(x => x.Key == 0));
    }

    private static void Convert(IReadOnlyList<int[]> gamers)
    {
        for (int i = 0; i < gamers.Count; i++)
        {
            Convert(gamers[i], Players[i]);
            PlayersScores.Add(Players[i], 0);
        }
    }

    private static void Convert(IEnumerable<int> cards, string value)
    {
        foreach (var card in cards)
        {
            PlayersCards.Add(card, value);
        }
    }

    private static bool Game(KeyValuePair<int, string> firstCard)
    {
        var winnerCard = Round(firstCard);
        for (var i = 0; i < 4; i++)
        {
            var winner = PlayersScores.FirstOrDefault(x => x.Value == 2);
            if (!winner.IsNull())
                return winner.Key == "Frank" ? true : false;
            winnerCard = Round(PlayersCards.First(x => x.Value == winnerCard.Value));
        }

        return false;
    }

    private static KeyValuePair<int, string> Round(KeyValuePair<int, string> firstCard)
    {
        var secondCard = GetPlayerCard(NextPlayerName(firstCard.Value), firstCard);
        var firstWinner = GetWinnerCard(firstCard, secondCard);
        var thirdCard = GetPlayerCard(NextPlayerName(secondCard.Value), firstWinner);
        var winnerCard = GetWinnerCard(firstWinner, thirdCard);
        PlayersScores[winnerCard.Value] = PlayersScores.GetValueOrDefault(winnerCard.Value) + 1;
        Remove(new List<KeyValuePair<int, string>>() { firstCard, secondCard, thirdCard });
        return winnerCard;
    }

    private static KeyValuePair<int, string> GetWinnerCard(KeyValuePair<int, string> firstCard,
        KeyValuePair<int, string> secondCard) => firstCard.Key > secondCard.Key ? firstCard : secondCard;

    private static KeyValuePair<int, string> GetPlayerCard(string playerName, KeyValuePair<int, string> opponentCard)
    {
        var playerCard = PlayersCards.FirstOrDefault(x => x.Key > opponentCard.Key && x.Value == playerName);
        return playerCard.IsNull() ? PlayersCards.MinBy(x => x.Value == playerName) : playerCard;
    }

    private static bool IsNull<TKey, TValue>(this KeyValuePair<TKey, TValue> keyValuePair) =>
        Equals(keyValuePair.Key, default(TKey)) || Equals(keyValuePair.Value, default(TValue));

    private static string NextPlayerName(string name)
    {
        var index = Players.IndexOf(name) + 1;
        if (index > Players.Count - 1)
            index = 0;
        return Players[index];
    }

    private static KeyValuePair<int, string> Turn(KeyValuePair<int, string> card1, KeyValuePair<int, string> card2) =>
        card1.Key > card2.Key ? card1 : card2;

    private static void Remove(IEnumerable<KeyValuePair<int, string>> cards)
    {
        foreach (var card in cards)
        {
            PlayersCards.Remove(card.Key);
        }
    }
}