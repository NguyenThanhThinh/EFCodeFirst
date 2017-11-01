using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Models
{
    using Animals.Interfaces;
    using Animals.Utilities;
    public abstract class Animal : ISoundProducable
    {
        private string name;
        private int age;
        private string gender;
        protected Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ErrorMessages.InvalidInput);
                }
                this.name = value;

            }
        }
        public int Age
        {
            get => age;
            set
            {
                if(string.IsNullOrWhiteSpace(value.ToString())|| value < 0)
                {
                    throw new ArgumentException(ErrorMessages.InvalidInput);
                }
                this.age = value;
            }
        }
        public string Gender
        {
            get => gender;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ErrorMessages.InvalidInput);
                }
                this.gender = value;

            }
        }
        public abstract string ProduceSound();
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.GetType().Name}");
            sb.AppendLine($"{this.Name} {this.Age} {this.Gender}");
            sb.Append($"{this.ProduceSound()}");

            return sb.ToString();
        }

    }
}
