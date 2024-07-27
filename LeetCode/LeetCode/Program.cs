using LeetCode.HackerRank.Problem_Solving.DateTime;
using LeetCode.SystemBasics;

/*BinaryHexASCII.CharHexBinaryStuff();
WorkingWithStringTemplates.StringStuffReplace();
WorkingWithStringTemplates.StringStuffFormat();
WorkingWithStringTemplates.StringStuffInterpolation();*/
SpreadElement.CombineArrays();
LongRawStringLiterals.LongString();

List<int> arr = [];

arr.Count();

var template = "[A], [B]!";

var test = template.Replace("[A]", "Hello").Replace("[B]", "World");

var test2 = "Hello World 2!";

Console.WriteLine(test);

foreach (var value in test2)
{
    Console.WriteLine(value);
}

int[] arr3 = [0, 2, 3, 4, 5, 6];

var arr4 = new int[arr3.Length];

foreach (var value in arr3)
{
    Console.Write($"{value} ");
}

Console.WriteLine("\n");

for (int i = 0; i < arr3.Length; i++)
{
    arr4[i] = arr3[i];
    Console.Write($"{arr4[i]} ");
}

Console.WriteLine("\n");



var time = TimeConversion.timeConversion("07:01:00PM");
Console.WriteLine(time);
