using Array_Part1;


#region Task1
//Task1 task1 = new();
//var sequence = new int[] { 10, 20, 30, 40, 50, 60 };
//var beats = new int[] { 1, 0, 0, 1, 0, 1 };
//var result = task1.PlayRight(sequence, beats);
//Console.WriteLine(string.Join(", ", result));
#endregion

#region Task1
Task2 task2 = new();
var cards = new int[] { 10, 2, 30, 2, 50, 2, 2, 0, 0 };
var resultTask2 = task2.DiscardCards(cards, 2);
Console.WriteLine(string.Join(", ", resultTask2));
#endregion