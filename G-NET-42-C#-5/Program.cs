namespace G_NET_42_C__5_
{
    enum Grade
    {
        A,
        B,
        C,
        D,
        F
    }
    internal class Program
    {
        const int NumberOfStudents = 5;
        static void Main(string[] args)
        {

            int[] scores = ReadStudentScores();

            Console.WriteLine("\n--- Report ---");

            for (int i = 0; i < scores.Length; i++)
            {
                Grade studentGrade = GetGrade(scores[i]);
                Console.WriteLine($"Student {i + 1}: {scores[i]} -> Grade: {studentGrade}");
            }

            double average = CalculateAverage(scores);
            GetMinMax(scores, out int minScore, out int maxScore);

            Console.WriteLine($"\nAverage: {average}");
            Console.WriteLine($"Minimum Score: {minScore}");
            Console.WriteLine($"Highest Score: {maxScore}");
        }
        static int[] ReadStudentScores()
        {
            int[] scores = new int[NumberOfStudents];

            for (int i = 0; i < NumberOfStudents; i++)
            {
                Console.Write($"Enter score for Student {i + 1}: ");
                scores[i] = int.Parse(Console.ReadLine() ?? "0");
            }

            return scores;
        }
        static Grade GetGrade(int score)
        {
            if (score >= 90)
                return Grade.A;
            else if (score >= 80)
                return Grade.B;
            else if (score >= 70)
                return Grade.C;
            else if (score >= 60)
                return Grade.D;
            else
                return Grade.F;
        }
        static double CalculateAverage(int[] scores)
        {
            int total = 0;

            for (int i = 0; i < scores.Length; i++)
            {
                total += scores[i];
            }

            return (double)total / scores.Length;
        }
        static void GetMinMax(int[] scores, out int min, out int max)
        {
            min = scores[0];
            max = scores[0];

            for (int i = 1; i < scores.Length; i++)
            {
                if (scores[i] < min)
                    min = scores[i];

                if (scores[i] > max)
                    max = scores[i];
            }
        }
    }
}
