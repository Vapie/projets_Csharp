using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading;

namespace Tp1_Projet
{
    public class TdDebug
    {
        #region Exercice 2 Error / Warning

        //private int Exercice2_Error()
        //{
        //    Pays p;
        //     return p.Id;
        //}

        private string Exercice2_Warning()
        {
            Pays p;

            return "warning";
        }

        private int Exercice2_Warning(int a, int b) 
        {
		#warning TODO : return the calcul result
            return 0;
        }

        #endregion

        #region Exercice 3 Assertion

        /// <summary>
        /// Multiplication for positive integer
        /// </summary>
        /// <param name="a">positive integer</param>
        /// <param name="b">positive integer</param>
        /// <returns></returns>
        private int PositiveMult(int a, int b)
        {
            System.Diagnostics.Debug.Assert(a > 0 && b > 0, "A et/ou B sont négatif");
            return a * b;
        }

        public void Exercice3()
        {
            int c = PositiveMult(3, 2);
            Console.WriteLine("c = " + c);
            c = PositiveMult(3, -2);
            Console.WriteLine("c = " + c);
        }

        #endregion

        #region Exercice 4 Step By Step / BreakPoint Simple / Call Stack


        private void Exercice4Func3()
        {
            int a = 8;
            a--;
        }

        private void Exercice4Func2()
        {
            int a = 7;
            a--;
            Exercice4Func3();
        }

        private void Exercice4Func1() 
        {
            for (int i = 0; i < 100; i++)
            {
                Exercice4Func2();
            }
        }

        public void Exercice4() 
        {
            System.Diagnostics.Debugger.Break();
            Exercice4Func1();
            Exercice4Func1();
            Exercice4Func1();
            Exercice4Func1();
        }

        #endregion

        #region Exercice 5 Watch / BreakPoint Conditionnel

        /// <summary>
        /// Watch simple
        /// </summary>
      /*  public void Exercice5_1(List<Pays> lesPays)
        {
            System.Diagnostics.Debugger.Break();
            IEnumerable<Pays> pays = lesPays;
            foreach (Pays p in pays)
            {
                string name = p.Name;
            }
        }*/

        /// <summary>
        /// To String Method 
        /// </summary>
       /* public void Exercice5_2(List<Pays> lesPays)
        {
            IEnumerable<Pays> pays = lesPays;
            System.Diagnostics.Debugger.Break();
        }*/

    
        private int Fibonacci(int n)
        {
            if (n <= 1)
                return n;
            int result = Fibonacci(n - 1) + Fibonacci(n - 2);
            return result;
        }

        /// <summary>
        /// Conditionnal BreakPoint 1
        /// </summary>
        public void Exercice5_3()
        {
            System.Diagnostics.Debugger.Break();
            Fibonacci(40);
        }

        /// <summary>
        /// Conditionnal BreakPoint 1
        /// </summary>
        
         /*public void Exercice5_4(List<Pays> lesPays)
        {
            System.Diagnostics.Debugger.Break();
            foreach (Pays p in (lesPays.OrderBy( s => s.Id)))
            {
                string name = p.Name;
            }
        }*/
        
        #endregion

        #region Exercice 6 #if DEBUG

        private int IntFunc()
        {
            int a;
#if DEBUG
            a = 3;
#else
            a = 6;
#endif
            return a;
        }

        public void Exercice6()
        {
            int a = IntFunc();
            Console.WriteLine("a = " + a);
            Console.ReadKey();
        }

        #endregion

        #region Exercice 7 - Event Logger

        public void LogWarning(string msg)
        {
            if (!EventLog.SourceExists("TP1Debug"))
                EventLog.CreateEventSource("TP1Debug", "Application");
            EventLog.WriteEntry("TP1Debug", msg, EventLogEntryType.Warning);
        }

        public void LogError(string msg)
        {
            if (!EventLog.SourceExists("TP1Debug"))
                EventLog.CreateEventSource("TP1Debug", "Application");
            EventLog.WriteEntry("TP1Debug", msg, EventLogEntryType.Error);
        }

        public void Exercice7()
        {
            this.LogWarning("My First Warning");
            this.LogError("My First Error");
        }

        #endregion

        #region Exercice 8 - Process Debuging

        public void Exercice8()
        {
            for (int i = 0; i < 1000; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Iteration : {0} Time : {1} ", i, DateTime.Now.ToLongTimeString());
            }
        }

        #endregion
    }
}
