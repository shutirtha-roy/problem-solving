using Array_Part1;


#region Task1
Task1 task1 = new();
var sequence = new int[] { 10, 20, 30, 40, 50, 60 };
var beats = new int[] { 1, 0, 0, 1, 0, 1 };
var result = task1.PlayRight(sequence, beats);
Console.WriteLine(string.Join(", ", result));
#endregion

