using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorytm2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LessonsManager lessonsManager = new LessonsManager();
            lessonsManager.CreateLesson(0, 75);
            lessonsManager.CreateLesson(0, 35);
            lessonsManager.CreateLesson(40, 90);
            lessonsManager.CreateLesson(20, 70);

            lessonsManager.SortingList();

            lessonsManager.CountRooms();
        }
    }
}
