using System;
using System.Collections.Generic;

namespace Exercise_6
{
    internal class Dogs
    {
        private string _name;
        private string _sex;
        private Dogs _dogMother;
        private Dogs _dogFather;

        public Dogs(string name, string sex, Dogs dogMother, Dogs dogFather)
        {
            this._name = name;
            this._sex = sex;
            this._dogMother = dogMother;
            this._dogFather = dogFather;
        }

        public void DogTest()
        {
            Console.WriteLine(_name + ", " + _sex);
            if (_dogMother == null && _dogFather == null)
            {
                Console.WriteLine("Dog parants Unknown");
            }
            else
            {
                Console.WriteLine("Dog mother: " + _dogMother._name + " dog father: " + _dogFather._name);
            }
        }

        public bool HasSameMotherAs(Dogs otherDog)
        {
            if(this._dogMother == otherDog._dogMother)
            {
                return true;
            }
            return false;
        }

    }
}
