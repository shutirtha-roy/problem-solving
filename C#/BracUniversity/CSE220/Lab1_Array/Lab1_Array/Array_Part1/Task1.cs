namespace Array_Part1;

public class Task1
{
    private int CalculateTotalBeats(int[] beats)
    {
        return (from beat in beats
            where beat == 1
            select beat).Count();
    }

    public int[] PlayRight(int[] sequence, int[] beats)
    {
        var totalBeats = CalculateTotalBeats(beats);
        var pointer = totalBeats;

        for(var index = 0; index < sequence.Length / 2; index++)
        {
            var position = sequence[pointer];
            sequence[pointer] = sequence[index];
            sequence[index] = position;
            pointer++;
        }

        return sequence;
    }
}
