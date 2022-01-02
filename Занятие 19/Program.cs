using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Занятие_19
{
    class Сomputer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ProcessorType { get; set; }
        public double ProcessorSpeed { get; set; }
        public int MemorySize { get; set; }
        public int DiskSize { get; set; }
        public int VideoCardMemorySize { get; set; }
        public int Cost { get; set; }
        public int Value { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Сomputer> listСomputer = new List<Сomputer>()
            {
                new Сomputer(){Id=1,Name="ASUS",ProcessorType="Intel",ProcessorSpeed=1.2,MemorySize=6,DiskSize=256, VideoCardMemorySize=2, Cost=42000, Value=5},
                new Сomputer(){Id=2,Name="Acer",ProcessorType="AMD",ProcessorSpeed=2.3,MemorySize=12,DiskSize=512, VideoCardMemorySize=2, Cost=62000, Value=2},
                new Сomputer(){Id=3,Name="HP",ProcessorType="AMD",ProcessorSpeed=2.4,MemorySize=8,DiskSize=256, VideoCardMemorySize=4, Cost=24900, Value=10},
                new Сomputer(){Id=4,Name="Lenovo",ProcessorType="Intel",ProcessorSpeed=2.6,MemorySize=16,DiskSize=512, VideoCardMemorySize=6, Cost=85000, Value=1},
                new Сomputer(){Id=5,Name="ASUS",ProcessorType="Intel",ProcessorSpeed=2.5,MemorySize=8,DiskSize=512, VideoCardMemorySize=4, Cost=70000, Value=3},
                new Сomputer(){Id=6,Name="Acer",ProcessorType="AMD",ProcessorSpeed=2.1,MemorySize=8,DiskSize=256, VideoCardMemorySize=4, Cost=64000, Value=8},
                new Сomputer(){Id=7,Name="HP",ProcessorType="Intel",ProcessorSpeed=2.5,MemorySize=16,DiskSize=512, VideoCardMemorySize=6, Cost=99000, Value=30},
                new Сomputer(){Id=8,Name="Lenovo",ProcessorType="AMD",ProcessorSpeed=3.2,MemorySize=16,DiskSize=1000, VideoCardMemorySize=8, Cost=160000, Value=1},
            };


            Console.WriteLine("Введите тип процессора"); // компьютеры с указанным процессором
            string s = Convert.ToString(Console.ReadLine());
            List<Сomputer> сomputers = listСomputer
                .Where(d => d.ProcessorType == s)
                .ToList();


            //Console.WriteLine("Введите объем ОЗУ"); // компьютеры с объемом ОЗУ выше указанного
            //int s = Convert.ToInt32(Console.ReadLine());
            //List<Сomputer> сomputers = listСomputer
            //    .Where(d => d.MemorySize >= s)
            //    .ToList();


            //List<Сomputer> сomputers = listСomputer // список отсортированный по увеличению стоимости
            //    .OrderBy(d => d.Cost)
            //    .ToList();


            //List<Сomputer> сomputers = listСomputer // проверяет есть ли хотя бы один компьютер в количестве не менее 30 шт.
            //    .Where(d => d.Value >= 30)
            //    .ToList();


            foreach (Сomputer d in сomputers)
                Console.WriteLine($"{d.Id} {d.Name} {d.ProcessorType} {d.ProcessorSpeed} {d.MemorySize} {d.DiskSize} {d.VideoCardMemorySize} {d.Cost} {d.Value}");



            //var сomputers = listСomputer // самый дорогой и самый бюджетный компьютер
            //    .OrderBy(d => d.Cost)
            //    .Select(d => new
            //    {
            //        N = d.Name,
            //        C = d.Cost
            //    })
            //    .FirstOrDefault();

            //Console.WriteLine($"{сomputers.N} {сomputers.C}");

            //var сomputer = listСomputer
            //    .OrderBy(d => d.Cost)
            //    .Select(d => new
            //    {
            //        N = d.Name,
            //        C = d.Cost
            //    })
            //    .LastOrDefault();

            //Console.WriteLine($"{сomputer.N} {сomputer.C}");



            //var сomputers = listСomputer // список, сгруппированный по типу процессора
            //    .GroupBy(d => d.ProcessorType);

            //foreach (var d in сomputers)
            //{
            //    Console.WriteLine($"{d.Key}");
            //    List<Сomputer> сomputer = listСomputer
            //    .ToList();
            //    foreach (Сomputer s in сomputer)
            //    {
            //        if (d.Key == s.ProcessorType)
            //        {
            //            Console.WriteLine($"{s.Id} {s.Name} {s.ProcessorType} {s.ProcessorSpeed} {s.MemorySize} {s.DiskSize} {s.VideoCardMemorySize} {s.Cost} {s.Value}");
            //        }
            //    }
            //    Console.WriteLine();
            //}


            Console.ReadKey();
        }
    }
}
