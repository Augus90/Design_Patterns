
using System.Security.Cryptography.X509Certificates;

internal class Program
{

    public interface IWeaponBehavior{
        void useWeapon();
    }

    public class SwordBehavior : IWeaponBehavior{
        public void useWeapon(){
            Console.WriteLine($"Do 10 Damage");
            
        }
    }
    public class KnifeBehavior : IWeaponBehavior{
        public void useWeapon(){
            Console.WriteLine($"Do 3 Damage and Bleeding");
        }
    }
    public class AxeBehavior : IWeaponBehavior{
        public void useWeapon(){
            Console.WriteLine($"Do 8 Damage and Stun");
        }
    }
    public class BowAndArrowBehavior : IWeaponBehavior{
        public void useWeapon(){
            Console.WriteLine($"Do 2 Damage");
            Console.WriteLine($"Do 2 Damage");
            Console.WriteLine($"Do 2 Damage");
        }
    }

    public abstract class Character {
        private IWeaponBehavior? _weaponBehavior {get; set;}

        public void SetWeapon(IWeaponBehavior weapon){
            this._weaponBehavior = weapon;
        }

        public void Fight(){
            this._weaponBehavior?.useWeapon();
        }
    }


    public class King : Character{
        public int health = 100;
        public void Attack(){
            Console.Write($"I'm a King and i ");
            this.Fight();
        }    
    }

    public class Queen : Character{
        public int health = 80;

        public void Attack(){
            Console.Write($"I'm a Queen and i ");
            this.Fight();
        }    
    }

    public class Knight : Character{
        public int health = 90;

        public void Attack(){
            Console.Write($"I'm a Knight and i ");
            this.Fight();
        }    
    }

    public class Troll : Character{
        public int health = 120;

        public void Attack(){
            Console.Write($"I'm a Troll and i ");
            this.Fight();
        }    
    }

    private static void Main(string[] args)
    {
        Knight character = new Knight();

        character.SetWeapon(new SwordBehavior());

        character.Attack();

        character.SetWeapon(new KnifeBehavior());

        character.Attack();
    }
}