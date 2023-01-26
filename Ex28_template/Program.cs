using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("222e004", DateTime.Today, "シバヤ", 40, 164, 30, 40);
            Console.WriteLine($"名前{student.Name}：ID{student.ID}：重さ{student.weight}kg");
            Worker worker = new Worker("Youtuber", DateTime.Today, "田中", 50, 160, 40, 50);
           Console.WriteLine($"名前{worker.Name}：職業{worker.Occupation}：重さ{worker.weight}kg");
            Fish fish = new Fish("外来種", DateTime.Today, "ブラックバス", 80, 10, 3, 13);
            Console.WriteLine($"名前{fish.Name} :種類{fish.Type}重さ{fish.Width}");
            Refrigerator refrigerator = new Refrigerator(20, "TOSHIBA", 650, 1833, 699, 70);
            Console.WriteLine($"値段{refrigerator.Price}万：名前{refrigerator.Name}：重さ{refrigerator.Weight}kg");
            Insect insect = new Insect("夏", DateTime.Today, "セミ", 3, 5, 2, 2);
            Console.WriteLine($"名前{insect.Name}:季節{insect.Season}");
            Car car = new Car(308, "GRスープラ", 1865, 4380, 1295, 1500);
            Console.WriteLine($"速さ{car.Speed}km/h：名前{car.Name}：重さ{car.Weight}kg");
            Cat cat = new Cat("マンチカン", DateTime.Today, "ミミ", 30, 25, 16, 4);
            Console.WriteLine($"名前{cat.Name}：猫種{cat.catBreed}：重さ{cat.weight}kg");
            Dog dog = new Dog("柴犬", DateTime.Today, "小春", 40,50, 70, 40);
            Console.WriteLine($"名前{dog.Name} 犬種{dog.DogType}");
        }
    }
}
