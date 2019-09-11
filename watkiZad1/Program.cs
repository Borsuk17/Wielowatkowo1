using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Concurrent;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace watkiZad1
{
    class Program
    {
        //          ZADANIE 1 - Przeplot
        //           Napisać programy w Adzie ilustrujące mechanizm przeplotu dla dwóch procesów.
        //           każdy proces wyświetla swój numer;
        //           każdy proces wyświetla swój numer w pęli nieskończonej;
        //           każdy proces wyświetla swój numer w pętli skończonej;
        //           każdy program uruchom kilkakrotnie.

        //static void Main()
        //{
        //    Action<object> action = (object obj) =>
        //    {
        //        Console.WriteLine("Task={0}, obj={1}, Thread={2}",
        //        Task.CurrentId, obj,
        //        Thread.CurrentThread.ManagedThreadId);
        //    };

        //    // Create a task but do not start it.
        //    Task t1 = new Task(action, "alpha");


        //    // Construct a started task
        //    Task t2 = Task.Factory.StartNew(action, "beta");
        //    // Block the main thread to demonstrate that t2 is executing
        //    t2.Wait();

        //    // Launch t1 
        //    t1.Start();
        //    Console.WriteLine("t1 has been launched. (Main Thread={0})",
        //                      Thread.CurrentThread.ManagedThreadId);
        //    // Wait for the task to finish.
        //    t1.Wait();

        //    // Construct a started task using Task.Run.
        //    String taskData = "delta";
        //    Task t3 = Task.Run(() => {
        //        Console.WriteLine("Task={0}, obj={1}, Thread={2}",
        //                          Task.CurrentId, taskData,
        //                           Thread.CurrentThread.ManagedThreadId);
        //    });
        //    // Wait for the task to finish.
        //    t3.Wait();

        //    // Construct an unstarted task
        //    Task t4 = new Task(action, "gamma");
        //    // Run it synchronously
        //    t4.RunSynchronously();
        //    // Although the task was run synchronously, it is a good practice
        //    // to wait for it in the event exceptions were thrown by the task.
        //    t4.Wait();
        //    Console.ReadKey();
        //}




        public static void Main(string[] args)
        {
            Console.WriteLine("ble ble ble>>>");
            int sleeptime = new int();
            sleeptime = 0;
            int loopTimes = 200;
            List<Task> listOfTask = new List<Task>();
           // listOfTask.Add(new Task(int sleeptime, int loopTimes) { });  do dokończenia 

            Task T1 = Task.Run(() =>
            {
                for (int i = 0; i < loopTimes; i++)
                {
                    Console.WriteLine("Jestem watkiem nr 1");
                    Thread.Sleep(sleeptime);
                }

            });

            Task T2 = Task.Run(() =>
            {
                for (int i = 0; i < loopTimes; i++)
                {
                    Console.WriteLine("Jestem watkiem nr 2");
                    Thread.Sleep(sleeptime);
                }

            });

            Task T3 = Task.Run(() =>
            {
                for (int i = 0; i < loopTimes; i++)
                {
                    Console.WriteLine("Jestem watkiem nr 3");
                    Thread.Sleep(sleeptime);
                }

            });

            Task T4 = Task.Run(() =>
            {
                for (int i = 0; i < loopTimes; i++)
                {
                    Console.WriteLine("Jestem watkiem nr 4");
                    Thread.Sleep(sleeptime);
                }

            });
            Task T5 = Task.Run(() =>
            {
                for (int i = 0; i < loopTimes; i++)
                {
                    Console.WriteLine("Jestem watkiem nr 5");
                    Thread.Sleep(sleeptime);
                }

            });
            ThreadT6(sleeptime, loopTimes);

            Console.WriteLine("Watek główny przed oczekiwaniem        >>>>>>>>>>>>>");
            Thread.Sleep(1000);
            Console.WriteLine("Watek główny po oczekiwaniu       1sek .............");
            Thread.Sleep(1000);
            Console.WriteLine("Watek główny po oczekiwaniu       2sek .............");

            Console.ReadKey();
        }

        private static void ThreadT6(int sleeptime, int loopTimes)
        {
            Task T6 = Task.Run(() =>
            {
                for (int i = 0; i < loopTimes; i++)
                {
                    Console.WriteLine("Jestem watkiem nr 6");
                    Thread.Sleep(sleeptime);
                }

            });
        }


    }
}
