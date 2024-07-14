namespace LeetCode.HackerRank.Problem_Solving.FlowControl;

public class Grades
{
    public static List<int> gradingStudents(List<int> grades)
    {

        List<int> processedGrades = [];
        
        foreach(var grade in grades)
        {
            if (grade < 38)
            {
                processedGrades.Add(grade);
            }
            else
            {
                var roundedGrade = RoundToNearest5(grade);
                var distance = roundedGrade - grade;

                if (distance < 3)
                {
                    processedGrades.Add(roundedGrade);
                }
                else
                {
                    processedGrades.Add(grade);
                }
            }
        }

        return processedGrades;
    }
    
    private static int RoundToNearest5(int grade)
    { 
        return (int)Math.Round(grade/ 5.0, MidpointRounding.ToPositiveInfinity) * 5;
    }

    private static bool Fail(int grade)
    {
        return grade < 40;
    }

    private static bool Pass(int grade)
    {
        return grade >= 40;
    }
}