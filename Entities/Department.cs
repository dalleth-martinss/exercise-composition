using System;
using System.Collections.Generic;


namespace ExerciseComposition.Entities
{
    public class Department
    {
        public string Name { get; set; }

        public Department() // construtor padrão serve para inicializar a classe.
        {

        }

        public Department(string name)// construtor que recebe o argumento nome e atribui  ao atributo Name
        {
            Name = name;
        }

    }
}
