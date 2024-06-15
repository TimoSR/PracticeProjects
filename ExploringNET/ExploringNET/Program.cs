// See https://aka.ms/new-console-template for more information

int number = 1;
string hello = "hello";
float @decimal = 1.5f;
var season = Seasons.Autumn;

Console.WriteLine($"{number}, {hello}, {@decimal}, {(int) Seasons.Winter}");
testMethod(season);

void testMethod(Seasons season)
{
    switch (season)
    {
        case Seasons.Autumn:
            Console.WriteLine("It is Autumn!");
            break;
        default:
            Console.WriteLine("We got nothing");
            break;
    }
}

enum Seasons
{
    Spring,
    Summer,
    Autumn,
    Winter,
};

