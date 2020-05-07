using System;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            RunMyGuess();
            RunExercise();

            Console.WriteLine("Press any key to quit...");
            Console.ReadKey();
        }

        private static void RunMyGuess()
        {
            MyGuess.Group topGroup = new MyGuess.Group();
            MyGuess.Group innerGroup1 = new MyGuess.Group(), 
                          innerGroup2 = new MyGuess.Group();
            MyGuess.Shape shape1 = new MyGuess.Shape(),
                          shape2 = new MyGuess.Shape(), 
                          shape3 = new MyGuess.Shape(), 
                          shape4 = new MyGuess.Shape();

            innerGroup1.Add(shape1);
            innerGroup1.Add(shape2);
            innerGroup2.Add(shape3);
            innerGroup2.Add(shape4);
            topGroup.Add(innerGroup1);
            topGroup.Add(innerGroup2);

            topGroup.Render();
        }

        private static void RunExercise()
        {
            Exercise.Team masterTeam = new Exercise.Team();
            Exercise.Team team1 = new Exercise.Team();
            Exercise.Team team2 = new Exercise.Team();

            team1.Add(new Exercise.Truck());
            team1.Add(new Exercise.HumanResource());
            team1.Add(new Exercise.HumanResource());

            team2.Add(new Exercise.Truck());
            team2.Add(new Exercise.HumanResource());
            team2.Add(new Exercise.HumanResource());

            masterTeam.Add(team1);
            masterTeam.Add(team2);

            masterTeam.Deploy();
        }
    }
}
