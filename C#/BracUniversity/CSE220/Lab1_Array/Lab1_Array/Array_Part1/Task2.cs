namespace Array_Part1;

public class Task2
{
    private int[] EmptyRequiredPosition(int[] cards, int number)
    {
        return cards
            .Select(card => card == number ? 0 : card)
            .ToArray();
    }

    public int[] DiscardCards(int[] cards, int number)
    {
        var discardCards = EmptyRequiredPosition(cards, number);



        return discardCards;
    }
}
