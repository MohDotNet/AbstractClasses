using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses
{
    public abstract class Animal
    {
        public string EyeColour { get; set; }
        public int NumberOfLegs { get; set; }
        public string Name { get; set; }



        /// <summary>
        /// When using virtual - this code will be execute, unless u override it.
        /// </summary>
        /// <returns></returns>
        public virtual string GetAnimal()
        {
            return "Name : " + Name + " EyeColour :" + EyeColour + " Number of Legs :" + NumberOfLegs;
        }

        public abstract string AnimalSpeak();

    }
}
