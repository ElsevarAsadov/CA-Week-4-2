using System;
using System.Runtime.Intrinsics.Arm;

namespace HomeWork
{
    public class Department
    {
        public string Name;
        public Worker[] Workers = new Worker[0];

        public Department AddWorker(Worker worker)
        {
            Array.Resize(ref Workers, Workers.Length + 1);
            Workers[^1] = worker;

            return this;
        }

        public Worker SearchWorker(string Name) { 
            for(int i = 0; i < Workers.Length; i++)
            {
                if (Workers[i].Name == Name)
                {
                    return Workers[i];
                }
            }
            return null;
            
        }

        public void ShowAllWorkers()
        {
            foreach(Worker worker in Workers)
            {

                Console.WriteLine(worker.Name);
            }
        }


    }


}
