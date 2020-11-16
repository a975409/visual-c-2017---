using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 實例90
{
    class Program
    {
        static void Main(string[] args)
        {
            TrackItem t1 = TrackItem.Track11 | TrackItem.Track12;
            OutputInfo(t1);
            TrackItem t2 = TrackItem.Track13 | TrackItem.Track14 | TrackItem.Track15;
            OutputInfo(t2);
            TrackItem t3 = TrackItem.Track11 | TrackItem.Track12 | TrackItem.Track13 | TrackItem.Track14 | TrackItem.Track15;
            OutputInfo(t3);
            Console.ReadKey();
        }

        static void OutputInfo(TrackItem t)
        {
            string p1 = t.ToString();
            string p2 = Convert.ToString((int)t, 2).PadLeft(5, '0');
            Console.WriteLine($"{p2,-4} -- {p1}");
            
        }
    }
    [Flags]
    enum TrackItem
    {
        Track11 = 1, Track12 = 2, Track13 = 4, Track14 = 8, Track15 = 16
    }
}
