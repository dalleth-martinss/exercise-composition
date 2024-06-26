﻿using ExerciseComposition.Entities.Enums;
using System.Collections.Generic;

namespace ExerciseComposition.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public  double BaseSalary { get; set; }
        public Department Department { get; set; }

        public List<HourContract> Contract { get; set; } = new List<HourContract>();

        public Worker()
        {

        }

        //o contract não é adicionado construtor pq não é usual passar um lista instanciada no constructor de objt
        // lista começa vazia e depois iremos adicionando conforme a necessidade
        // sempre q tiver uma associação para muitos, não adicionamos no constructor
        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            Contract.Add(contract);
        }
        public void RemoveContract(HourContract contract)
        {
            Contract.Remove(contract);
        }
        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach(HourContract contract in Contract)
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
