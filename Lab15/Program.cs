using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Реализация класса арифметической прогрессии
            ArithProgression arPr = new ArithProgression();
            Console.WriteLine("Реализация класса арифметической прогрессии");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Следующее число равно "+ arPr.getNext());
            }
            Console.WriteLine("\nСбросить");
            arPr.reset();
            Console.WriteLine("\nНачать с числа 50");
            arPr.setStart(50);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Следующее число равно " + arPr.getNext());
            }

            //Реализация класса геометрической прогрессии
            GeomProgression geoPr = new GeomProgression();
            Console.WriteLine("\nРеализация класса геометрической прогрессии");
            geoPr.setStart(3);
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Следующее число равно "+ geoPr.getNext());
            }
            Console.WriteLine("\nСбросить");

            Console.WriteLine("\nНачать с числа 43");
            geoPr.setStart(43);
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Следующее число равно " + geoPr.getNext());
            }

            Console.ReadKey();
        }
    }
    interface ISeries
    {
        void setStart(int x);
        int getNext();
        void reset();
    }
    class ArithProgression : ISeries
    {
        int start;
        int d;
        public void setStart(int x)
        {
            start = x;
            d = start;
        }
        public int getNext()
        {
                d += 2;
            return d;
        }

        public void reset()
        {
            d = start;
        }
    }

    class GeomProgression : ISeries
    {
        int start;
        int q;

        public void setStart(int x)
        {
            start = x;
            q = start;
        }
        public int getNext()
        {
            q *= 3;
            return q;

        }

        public void reset()
        {
            q = start;
        }
    }
}
