using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorytm2
{
    public class LessonsManager
    {
        public List<Lesson> list { get; set; } = new List<Lesson>();

        public void CreateLesson(int start, int end)
        {
            if(start < end)
            {
                Lesson lesson = new Lesson() { Start = start, End = end };
                list.Add(lesson);
            }
            else
            {
                Console.WriteLine("Nieprawidłowy format lekcji.");
            }
        }

        public void SortingList()
        {
            list = list.OrderBy(a => a.Start).ThenBy(b => b.End).ToList();
        }

        public void CountRooms()
        {
            int count = 1;
            int currentEnd = list[0].End;

            for (int i = 1; i < list.Count; i++)
            {
                if (list[i].Start < currentEnd)
                {
                    count++;
                }
                else
                {
                    currentEnd = list.Where(a => a.End > currentEnd).ToList().OrderBy(a => a.End)
                        .First().End;
                }
            }

            Console.WriteLine("Najmniejsza potrzebna liczba sal, tak aby mogły się odbyć " +
                "zajęcia to {0}", count);
        }
    }
}
