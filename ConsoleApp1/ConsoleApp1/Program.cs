using System.Numerics;

namespace FirstLesson
{

    // Zásadní rozdíl pro abstraktní třídu je, že může mít i atributy, nejen metody
    public abstract class GameObject
    {
        protected Vector2 position;
        public abstract void Draw();
    }

    public interface IMovable
    {
        void Move(Vector2 direction);
    }

    public interface ICollidable
    {
        bool CollidesWith(GameObject other);
    }

    public class Weapon
    {
        private int damage;
        private int durability;
        private int range;

        public int Damage
        {
            get { return damage; }
        }

        public int Durability
        {
            get { return durability; }
        }

        public int Range
        {
            get { return range; }
        }

        public Weapon(int damage, int durability, int range)
        {
            this.damage = damage;
            this.durability = durability;
            this.range = range;
        }
    }


    // Třída Character dědí z GameObject a implementuje IMovable
    public class Character : GameObject, IMovable
    {

        // Princip encapsulation - atributy jsou private a přistupuje se k nim přes property
        private int health;

        // Příklad kompozice
        private Weapon weapon;


        public int Health
        {
            get { return health; }
        }


        public void Equip(Weapon weapon)
        {
            this.weapon = weapon;
        }


        public Character()
        {
            this.position = new Vector2(0, 0);
            this.weapon = new Weapon(10, 100, 10);
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing character");
        }

        public void Move(Vector2 direction)
        {
            this.position += direction;
        }
    }

    // Třída Enemy dědí z GameObject a implementuje ICollidable
    public class Enemy : GameObject, ICollidable
    {

        private int stamina;

        public int Stamina
        {
            get { return stamina; }
        }


        // Konstruktor - speciální metoda, pomocí tohoto rodíme instance
        public Enemy()
        {
            this.position = new Vector2(0, 0);
        }

        public override void Draw()
        {
            Console.WriteLine("Draw enemy");
        }

        public bool CollidesWith(GameObject other)
        {
            return true;
        }
    }


    // Ukázka polymorfismu s rozhraním
    public interface IShape
    {
        void Draw();
    }

    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing circle");
        }
    }


    public class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing Square");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            List<IShape> shapes = new List<IShape>();

            shapes.Add(new Circle());
            shapes.Add(new Square());
            shapes.Add(new Circle());

            // Jednotny přístup k instancím různých tříd
            foreach (IShape shape in shapes)
            {
                shape.Draw();
            }

            Character character = new Character();
            character.Draw();
            Enemy enemy = new Enemy();
            enemy.Draw();

            character.Equip(new Weapon(10, 1, 500));

            Console.ReadLine();
        }
    }
}