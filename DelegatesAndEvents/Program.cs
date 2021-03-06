﻿using System;

namespace DelegatesAndEvents
{
   // public delegate int WorkPerformedHandler(int hours, WorkType workType);
    class Program
    {
        static void Main(string[] args)
        {
            //WorkPerformedHandler del1 = new WorkPerformedHandler(WorkPerformed1);
            //WorkPerformedHandler del2 = new WorkPerformedHandler(WorkPerformed2);
            //WorkPerformedHandler del3 = new WorkPerformedHandler(WorkPerformed3);

            //del1 += del2 + del3;

            //del1(10, WorkType.GenerateReports);

            var worker = new Worker();
            worker.WorkPerformed += delegate (object sender, WorkPerformedEventArgs e)
            {
                Console.WriteLine("Hours Worked: " + e.Hours + " " + e.WorkType);
            };
            worker.WorkCompleted += delegate (object sender, EventArgs e)
            {
                Console.WriteLine("Work is done.");
            };
            worker.DoWork(8, WorkType.GenerateReports);
        }

        //static void Worker_WorkPerformed(object sender, WorkPerformedEventArgs e)
        //{
        //    Console.WriteLine("Hours Worked: " + e.Hours + " " + e.WorkType);
        //}

        //static void Worker_WorkCompleted(object sender, EventArgs e)
        //{
        //    Console.WriteLine("Work is done.");
        //}

        //static void DoWork(WorkPerformedHandler del)
        //{
        //    del(5, WorkType.GoToMeetings);
        //}

        //static int WorkPerformed1(int hours, WorkType workType)
        //{
        //    Console.WriteLine("WorkPerformed1 called " + hours.ToString());
        //    return hours + 1;
        //}

        //static int WorkPerformed2(int hours, WorkType workType)
        //{
        //    Console.WriteLine("WorkPerformed2 called " + hours.ToString());
        //    return hours + 2;
        //}

        //static int WorkPerformed3(int hours, WorkType workType)
        //{
        //    Console.WriteLine("WorkPerformed3 called " + hours.ToString());
        //    return hours + 3;
        //}
    }

    public enum WorkType
    {
        GoToMeetings,
        Golf,
        GenerateReports
    }
}
