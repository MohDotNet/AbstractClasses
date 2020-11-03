using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses
{
    public class cat : Animal
    {
        public override string GetAnimal()
        {
            return "Cat name: " + base.Name + " who has eye colour: " + base.EyeColour;
        }

        public override string AnimalSpeak()
        {
            return base.Name + " who is a cat MEEOOWWWS!!!";
        }
    }
}
