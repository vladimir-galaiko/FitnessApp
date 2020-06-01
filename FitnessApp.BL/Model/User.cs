using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.BL.Model
{
    class User
    {
        public string Name { get;}

        public Gender Gender { get;}

        public DateTime BirthDate { get; }

        public double Weight { get; set; }

        public double Height { get; set; }

        public User(string name,
            Gender gender,
            DateTime birthDate,
            double weight,
            double height)
        {


            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("Name cannot be blank", nameof(name));
            }
            if (gender == null)
            {
                throw new ArgumentNullException("Gender cannot be blank", nameof(name));
            }

            if (birthDate < DateTime.Parse("01.01.1900") || birthDate >= DateTime.Now)
            {
                throw new ArgumentException("Invalid Birth Date", nameof(birthDate));
            }

            if (weight <= 0)
            {
                throw new ArgumentException("Weigth cannot be 0 oo less", nameof(weight));
            }

            if (height <= 0)
            {
                throw new ArgumentException("Height cannot be 0 oo less", nameof(height));
            }

            Name = name;
            Gender = gender;
            BirthDate = birthDate;
            Weight = weight;
            Height = height;
        }

        public override string ToString()
        {
            return Name;
        }

    }
}
