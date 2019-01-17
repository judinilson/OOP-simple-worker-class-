using Worker.Entites.Enums;
using System.Collections.Generic;


namespace Worker.Entites
{
    class workers
    {
        public string name { get; set; }
        public WorkerLevel level { get; set; }
        public double BaseSalary { get; set; }
        public Department department { get; set; }
        public List<HourContracts> contracts { get; set; } = new List<HourContracts>();

        public workers()
        {

        }

        public workers(string name, WorkerLevel level, double baseSalary, Department department)
        {
            this.name = name;
            this.level = level;
            BaseSalary = baseSalary;
            this.department = department;
        }

        public void AddContract(HourContracts contrt)
        {
            contracts.Add(contrt);
        }

        public void RemoveContract(HourContracts contrt)
        {
            contracts.Remove(contrt);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary; 
            foreach(HourContracts contract in contracts)
            {
                if(contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue(); 
                }
            }

            return sum;
        }
    }
}
