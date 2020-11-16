using System;

namespace 實例157
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "10026\t小張\t28\t成都";
            Student stu = str;

            Console.WriteLine("學員資訊：");
            Console.WriteLine($"學號：{stu.ID}\n姓名：{stu.Name}\n年齡：{stu.Age}\n所在城市：{stu.City}");
        }
    }

    class Student
    { 
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }

        public static implicit operator Student(string input)
        {
            string[] strAry = input.Split('\t');

            if (strAry.Length != 4)
                return null;

            return new Student
            {
                ID = Convert.ToInt32(strAry[0]),
                Name = strAry[1],
                Age = Convert.ToInt32(strAry[2]),
                City = strAry[3]
            };
        }
    }
}
