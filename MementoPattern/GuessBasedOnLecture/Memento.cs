using System;

namespace GuessBasedOnLecture
{
    public class Memento
    {
        public string Content { get; set; }

        public Memento(Originator originator)
        {
            Originator temp = originator.ShallowCopy();
            //Shallow copy
            Content = temp.Content;
        }
    }
}
