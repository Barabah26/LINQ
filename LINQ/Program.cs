var words = new List<string> { "a", "bb", "ccc", "dddd"};
var wordsLongerTnan2Letters = words.Where(w => w.Length > 2);


var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
var oddNumber = numbers.Where(n => n % 2 == 1);

Console.ReadKey();