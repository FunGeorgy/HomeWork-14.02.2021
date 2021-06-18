using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Timers;

namespace _2020._08._12_House_Homework
{
    interface IWorker
    {
        void build_yes();
        void finish();
        void process();

        void build();
        

    }

    interface IPart
    {
        void qyantity(int quantity);
        
    }
    class House
    {
        public Timer time_to_build = new Timer(30000);
        public int number_house;
        public string nazvanie;
        public int part;
    }
    class Basement : House, IPart
    {
        public void qyantity(int i)
        {
            Console.WriteLine("Количество данного элемента дома: {0}", i);
        }
        public string chast() { return ("Фундамент"); }

    }
    class Walls : House, IPart
    {
        public void qyantity(int i)
        {
            Console.WriteLine("Количество данного элемента дома: {0}", i);
        }
        public string chast() { return ("Стена"); }
    }

    class Door : House, IPart
    {
        public void qyantity(int i)
        {
            Console.WriteLine("Количество данного элемента дома: {0}", i);
        }
        public string chast() { return ("Дверь"); }
    }

    class Window : House, IPart
    {
        public void qyantity(int i)
        {
            Console.WriteLine("Количество данного элемента дома: {0}", i);
        }
        public string chast() { return ("Окно"); }
        class Roof : House, IPart
        {
            public void qyantity(int i)
            {
                Console.WriteLine("Количество данного элемента дома: {0}", i);
            }
            public string chast() { return ("Крыша"); }
        }

        class Team : IWorker
        {
            public List<Worker> team = new List<Worker>();
            

            public int number_house;
            public string chast_doma;

            public void process()
            {
                string process_build = ("Cтроительство дома начинается");
                Console.WriteLine("Дом номер {1}.  {0}", process_build, number_house);
            }
            public void build_yes()
            {
                string process = "Cтроим";
                Console.WriteLine("{0} {1}", process, chast_doma);
            }
            public void finish()
            {
                string finish = "Строительство завершено";
                Console.WriteLine("{0} {1}", finish, chast_doma);
            }
            public void build()
            {
                string build = ("Строим новую часть");
                Console.WriteLine("{0} {1}", build, chast_doma);
            }
           
        }
        class Worker
        {
            public string name { get; set; }
            public int age { get; set; }
            public string grade { get; set; }


        }

        class TeamLeader : Worker
        {
            public void otchet() { string otchet = "Отчет сформирован."; }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Team i = new Team();
                string stop;
                House Dom = new House();
                int count = 0;
                Console.WriteLine("Введите номер дома: ");
                Dom.number_house = Convert.ToInt32(Console.ReadLine());
                do
                {
                    count++;
                    Worker a = new Worker();
                    Console.WriteLine("Номер сотрудника: {0}", count);
                    Console.WriteLine("Возраст сотрудника: ");
                    a.age = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите имя сотрудника: ");
                    a.name = Console.ReadLine();
                    Console.WriteLine("Введите должность: ");
                    a.grade = Console.ReadLine();
                    i.team.Add(a);
                    Console.WriteLine("для остановки напишите: стоп");
                    stop = Console.ReadLine();
                }
                while (stop != "стоп");
                {
                    Console.WriteLine("Добавьте ТимЛидера");
                    TeamLeader b = new TeamLeader();
                    Console.WriteLine("Возраст ТимЛидера: ");
                    b.age = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите имя сотрудника ");
                    b.name = Console.ReadLine();
                    b.grade = "ТимЛид";
                    i.team.Add(b);
                }
                foreach (Worker a in i.team)
                    Console.WriteLine("возраст: {0}, имя: {1}, грейд: {2}", a.age, a.name, a.grade);


                Console.WriteLine();
                    
                    i.number_house = Dom.number_house;
                    i.process();
                Basement basement = new Basement();
                Window window = new Window();
                Walls walls = new Walls();
                Door door = new Door();
                Roof roof = new Roof();
                i.chast_doma = basement.chast();
                for (int j = 0; j < 1; j++)
                    {
                        basement.part++;
                        i.build_yes();
                        basement.qyantity(basement.part);
                        
                    }
                    i.finish();
                    
                    
                i.chast_doma = walls.chast();
                for (int j = 0; j < 4; j++)
                        {
                            walls.part++;
                            i.build_yes();
                            walls.qyantity(window.part);
                            
                        }
                i.finish();

                        i.chast_doma = window.chast();
                        for (int j = 0; j < 4; j++)
                        {
                            window.part++;
                            i.build_yes();
                            window.qyantity(window.part);
                            
                        }
                i.finish();
                    
                        i.chast_doma = door.chast();
                        door.part++;
                        i.build_yes();
                        door.qyantity(door.part);
                        
                        i.finish();
                   
                     
                        i.chast_doma = roof.chast();
                        i.build_yes();
                        roof.part++;
                        roof.qyantity(roof.part);
                       
                        i.finish();
                  
                    
               
                    Dom.time_to_build.Stop();

                    Console.WriteLine("Дом успешно завершен.");
             
            }
        }
    }
}



