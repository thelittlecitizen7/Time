using System;

namespace TimeMiliseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            Time ff = new Time(new TimeSpan(12,3,44,44));
            ff.Print();
        }
    }
}
