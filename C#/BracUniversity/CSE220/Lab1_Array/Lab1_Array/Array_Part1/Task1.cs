namespace Array_Part1;

public class Task1
{
    private int CalculateTotalBeats(int[] beats)
    {
        return (from beat in beats
            where beat == 1
            select beat).Count();
    }

    private int CheckWhetherPointerExceedsLength(int pointer, int length)
    {
        return pointer == length
                ? 0
                : pointer;
    }

    public int[] PlayRight(int[] sequence, int[] beats)
    {
        var totalBeats = CalculateTotalBeats(beats);
        var afterRightSequence = new int[sequence.Length];
        var pointer = totalBeats;

        for(var index = 0; index < sequence.Length; index++)
        {
            pointer = CheckWhetherPointerExceedsLength(pointer, sequence.Length);
            afterRightSequence[pointer] = sequence[index];
            pointer++;
        }

        return afterRightSequence;
    }
}
