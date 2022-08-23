using System;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Dogs dog6 = new Dogs("Lady", "female", null, null);
            Dogs dog7 = new Dogs("Molly", "female", null, null);
            Dogs dog3 = new Dogs("Sparky", "male", null, null);
            Dogs dog4 = new Dogs("Buster", "male", dog6, dog3);
            Dogs dog2 = new Dogs("Rocky", "male", dog7, dog4);
            Dogs dog1 = new Dogs("Max", "male", dog6, dog2);
            Dogs dog5 = new Dogs("Sam", "male", null, null);
            Dogs dog8 = new Dogs("Coco", "female", dog7, dog4);


            dog1.DogTest();
            dog2.DogTest();
            dog3.DogTest();
            dog4.DogTest();
            dog5.DogTest();
            dog6.DogTest();
            dog7.DogTest();
            dog8.DogTest();

            Console.WriteLine(dog4.HasSameMotherAs(dog1));
        }

    }
}
