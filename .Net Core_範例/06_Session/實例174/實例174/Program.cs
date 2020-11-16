using System;

namespace 實例174
{
    class Program
    {
        static WorkItem[] items =
        {
            new WorkItem
            { 
                ID=1,
                Title="工序1",
                StartTime=new DateTime(2018,7,1,8,36,0),
                EndTime=new DateTime(2018,7,2,17,30,0)
            },
            new WorkItem
            {
                ID=2,
                Title="工序2",
                StartTime=new DateTime(2018,7,2,10,15,0),
                EndTime=new DateTime(2018,7,5,18,0,0)
            },
            new WorkItem
            {
                ID=3,
                Title="工序3",
                StartTime=new DateTime(2018,7,1,15,25,0),
                EndTime=new DateTime(2018,7,12,17,30,0)
            },
            new WorkItem
            {
                ID=4,
                Title="工序4",
                StartTime=new DateTime(2018,7,14,9,16,0),
                EndTime=new DateTime(2018,7,20,8,20,0)
            },
            new WorkItem
            {
                ID=5,
                Title="工序5",
                StartTime=new DateTime(2018,7,23,9,10,0),
                EndTime=new DateTime(2018,7,28,15,32,0)
            },
            new WorkItem
            {
                ID=6,
                Title="工序6",
                StartTime=new DateTime(2018,7,18,9,11,0),
                EndTime=new DateTime(2018,7,25,16,45,0)
            },

        };

        static void Main(string[] args)
        {
            WorkItem res = Array.Find(items, GetMatchItem);

            Console.WriteLine($"開始時間晚於{new DateTime(2018, 7, 15).ToLongDateString()}的工序：");
            Console.WriteLine($"編號：{res.ID}\n標題：{res.Title}\n開始時間：{res.StartTime}\n結束時間：{res.EndTime}\n\n");

            WorkItem[] resitems = Array.FindAll(items, GetMatchItem);

            Console.WriteLine($"所有開始時間晚於{new DateTime(2018, 7, 15).ToLongDateString()}的工序：");
            foreach (var item in resitems)
            {
                Console.WriteLine($"編號：{item.ID}\n標題：{item.Title}\n開始時間：{item.StartTime}\n結束時間：{item.EndTime}\n\n");
            }

            int index = Array.FindIndex(items, GetMatchItem);
            Console.WriteLine($"開始時間晚於{new DateTime(2018, 7, 15).ToLongDateString()}的Index值：{index}\n\n");

            bool exists = Array.Exists(items, GetMatchItem);
            Console.WriteLine($"開始時間晚於{new DateTime(2018, 7, 15).ToLongDateString()}是否存在?：{exists}");
        }

        static bool GetMatchItem(WorkItem item)
        {
            DateTime condition = new DateTime(2018, 7, 15);

            return item.StartTime > condition;
        }
    }

    public class WorkItem
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
