using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            RunMyGuess();
            RunGuessBasedOnLecture();
            RunExercise();

            Console.WriteLine("Press any key to quit...");
            Console.ReadKey();
        }

        private static void RunMyGuess()
        {
            MyGuess.CloudStream cloudStream = new MyGuess.CloudStream();
            string dataToStore = "There is a lot of data to store here";
            cloudStream.Write(dataToStore);

            MyGuess.ExtensibleCloudStream extensibleCloudStream = new MyGuess.ExtensibleCloudStream(cloudStream);
            extensibleCloudStream.Extensions.Add(new MyGuess.CompressionExtension());
            extensibleCloudStream.Extensions.Add(new MyGuess.EncryptionExtension());

            extensibleCloudStream.Write(dataToStore);
        }

        private static void RunGuessBasedOnLecture()
        {
            GuessBasedOnLecture.CloudStream stream = new GuessBasedOnLecture.CloudStream();
            string dataToStore = "There is a lot of data to store here";

            stream.Write(dataToStore);
            GuessBasedOnLecture.CompressedCloudStream compressed = new GuessBasedOnLecture.CompressedCloudStream(stream);
            GuessBasedOnLecture.EncryptedCloudStream encrypted = new GuessBasedOnLecture.EncryptedCloudStream(compressed);

            encrypted.Write(dataToStore);
        }

        private static void RunExercise()
        {
            Exercise.Editor editor = new Exercise.Editor();
            editor.OpenProject(@"C:\temp\project");
        }
    }
}
