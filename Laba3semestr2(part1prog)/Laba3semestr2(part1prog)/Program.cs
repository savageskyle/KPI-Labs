using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Laba3semestr2_part1prog_
{
    internal class Program
    {
        static string Path = @"D:\Arsen\Studying KPI\visual projects\Laba3semestr2(part1prog)\tretiy.json";
        static void Main(string[] args)
        {
            Schedule schedule = new Schedule();

            // Додаємо нові елементи розкладу
            ScheduleItem item1 = new ScheduleItem(new DateTime(2023, 4, 12, 9, 0, 0), new DateTime(2023, 4, 12, 11, 0, 0), "A101", "Консультації з математики");
            ScheduleItem item2 = new ScheduleItem(new DateTime(2023, 4, 12, 12, 0, 0), new DateTime(2023, 4, 12, 14, 0, 0), "A102", "Лекція з фізики");
            ScheduleItem item3 = new ScheduleItem(new DateTime(2023, 4, 12, 16, 0, 0), new DateTime(2023, 4, 12, 18, 0, 0), "A101", "Консультації з англійської");
            schedule.Add(item1);
            schedule.Add(item2);
            schedule.Add(item3);

            // Виводимо всі елементи розкладу на певну дату
            List<ScheduleItem> itemsOnDate = schedule.GetItemsByDate(new DateTime(2023, 4, 12));
            Console.WriteLine("Елементи розкладу на 12 квітня:");
            foreach (ScheduleItem item in itemsOnDate)
            {
                Console.WriteLine("{0} - {1} ({2}) - {3}", item.StartTime, item.EndTime, item.Location, item.Comment);
            }
            Console.WriteLine();

            // Виводимо всі елементи розкладу за певним місцем проведення
            List<ScheduleItem> itemsAtLocation = schedule.GetItemsByLocation("A101");
            Console.WriteLine("Елементи розкладу у приміщенні A101:");
            foreach (ScheduleItem item in itemsAtLocation)
            {
                Console.WriteLine("{0} - {1} ({2}) - {3}", item.StartTime, item.EndTime, item.Location, item.Comment);
            }
            Console.WriteLine();

            // Додаємо новий елемент розкладу, який перетинається з існуючим елементом
            ScheduleItem item4 = new ScheduleItem(new DateTime(2023, 4, 12, 10, 0, 0), new DateTime(2023, 4, 12, 12, 0, 0), "A101", "Консультації з історії");
            try
            {
                schedule.Add(item4);
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Помилка: {0}", e.Message);
            }

            SerializeJSON(itemsAtLocation, Path); 
            var deserialized = DeserializeCounter(Path);
            Console.WriteLine($"deserialized: ");
            Console.ReadLine();
        }
        static void SerializeJSON(object obj, string path)
        {
            var jdaughter = JsonConvert.SerializeObject(obj);
            File.WriteAllText(path, jdaughter);
            Console.Write($"serialized:{jdaughter}");
        }
        static Schedule DeserializeCounter(string path)
        {
            var objStr = File.ReadAllText(Path);

            return JsonConvert.DeserializeObject<Schedule>(objStr);
        }
    }
    class ScheduleItem
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Location { get; set; }
        public string Comment { get; set; }

        public ScheduleItem(DateTime startTime, DateTime endTime, string location, string comment)
        {
            StartTime = startTime;
            EndTime = endTime;
            Location = location;
            Comment = comment;
        }
    }

    class Schedule
    {
        private List<ScheduleItem> scheduleItems;

        public Schedule()
        {
            scheduleItems = new List<ScheduleItem>();
        }

        public List<ScheduleItem> GetItemsByDate(DateTime date)
        {
            return scheduleItems.FindAll(item => item.StartTime.Date == date.Date);
        }

        public void Clear()
        {
            scheduleItems.Clear();
        }

        public void Add(ScheduleItem item)
        {
            if (CanAddItem(item))
            {
                scheduleItems.Add(item);
            }
            else
            {
                throw new InvalidOperationException("Cannot add item to the schedule");
            }
        }

        public void Replace(int index, ScheduleItem item)
        {
            if (CanAddItem(item))
            {
                scheduleItems[index] = item;
            }
            else
            {
                throw new InvalidOperationException("Cannot replace item in the schedule");
            }
        }

        public void Remove(int index)
        {
            scheduleItems.RemoveAt(index);
        }

        public void Insert(int index, ScheduleItem item)
        {
            if (CanAddItem(item))
            {
                scheduleItems.Insert(index, item);
            }
            else
            {
                throw new InvalidOperationException("Cannot insert item into the schedule");
            }
        }

        public List<ScheduleItem> GetItemsByLocation(string location)
        {
            return scheduleItems.FindAll(item => item.Location == location);
        }

        public bool CanAddItem(ScheduleItem item)
        {
            foreach (ScheduleItem currentItem in scheduleItems)
            {
                if (currentItem.StartTime >= item.EndTime || currentItem.EndTime <= item.StartTime)
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        public bool Intersects(Schedule otherSchedule)
        {
            foreach (ScheduleItem currentItem in scheduleItems)
            {
                foreach (ScheduleItem otherItem in otherSchedule.scheduleItems)
                {
                    if (currentItem.StartTime >= otherItem.EndTime || currentItem.EndTime <= otherItem.StartTime)
                    {
                        continue;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
