internal class Program
{
    public static void doSometing()
    {
        Console.WriteLine($"Someting");

    }
    public class Infantry
    {
        public void goForward()
        {
            Console.WriteLine($"Infantry go forward");

        }
        public void swingSword()
        {
            Console.WriteLine($"Infantry swing sword");

        }
    }
    public class Cabalry
    {
        public void run()
        {
            Console.WriteLine($"Cabalry running");

        }
        public void highAttack()
        {
            Console.WriteLine($"Cabalry Attack");

        }
    }
    public class Archer
    {
        public void recharge()
        {
            Console.WriteLine($"Archer Regener their Arrows");

        }
        public void aimTarget()
        {
            Console.WriteLine($"Archer aim the target");

        }
        public void release()
        {
            Console.WriteLine($"Archer shoot the target");

        }
    }

    public interface ICommander
    {
        void attack();
        void retive();
    }

    public class InfantryAttackCommander : ICommander
    {
        Infantry _infantry;

        public InfantryAttackCommander(Infantry infantry)
        {
            _infantry = infantry;
        }

        public void attack()
        {
            _infantry.goForward();
            _infantry.swingSword();
        }

        public void retive()
        {
            Console.WriteLine($"Yeld: RETRIVE!!");

        }
    }
    public class CabalryAttackCommander : ICommander
    {
        Cabalry _cabalry;

        public CabalryAttackCommander(Cabalry cabalry)
        {
            _cabalry = cabalry;
        }

        public void attack()
        {
            _cabalry.run();
            _cabalry.highAttack();
        }

        public void retive()
        {
            Console.WriteLine($"Yeld: RETRIVE!!");

        }
    }

    public class General
    {
        public ICommander _commander;

        public General() { }
        public void setCommand(ICommander commander)
        {
            this._commander = commander;
        }

        public void attack()
        {
            _commander.attack();
        }

    }

    private static void Main(string[] args)
    {
        var general = new General();

        var infantry = new InfantryAttackCommander(new Infantry());
        var cabalry = new CabalryAttackCommander(new Cabalry());

        general.setCommand(infantry);
        Console.WriteLine($"Infantry attack!!");
        general.attack();
        general.setCommand(cabalry);
        Console.WriteLine($"Cabalry attack!!");
        general.attack();
    }
}