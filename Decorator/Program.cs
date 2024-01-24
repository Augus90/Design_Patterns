internal class Program
{
    public abstract class Beverage{
        public enum enumSize{
            TALL = 2,
            GRANDE = 4,
            VENTI = 6,
        }

        protected string description {set; get;}
        protected int _size {set; get;}

        public virtual string getDescription(){
            return $"{description} {getSize()}";
        }

        public int getSize() { return _size; }
        public void setSize(int size) { this._size = size; }

        public abstract int cost();
    }   

    public class HouseBlend : Beverage {


        public HouseBlend(){
            description = "House Blend";
        }
        public HouseBlend(enumSize size){
            description = "House Blend";
            _size = (int) size;
        }
        public override int cost(){
            return 10 + getSize();
        }
    }
    public class DarkBlend : Beverage {
        public DarkBlend(){
            description = "Dark Blend";
        }
        public DarkBlend(enumSize size){
            description = "Dark Blend";
            _size = (int) size;
        }
        public override int cost(){
            return 12 + getSize();
        }
    }
    public class EspressoBlend : Beverage {
        public EspressoBlend(){
            description = "Espresso Blend";
        }
        public EspressoBlend(enumSize size){
            description = "Espresso Blend";
            _size = (int) size;
        }
        public override int cost(){
            return 15 + getSize();
        }
    }
    public class DecafBlend : Beverage {
        public DecafBlend(){
            description = "Decaf Blend";
        }
        public DecafBlend(enumSize size){
            description = "Decaf Blend";
            _size = (int) size;
        }
        public override int cost(){
            return getSize() + 14;
        }
    }

    public abstract class CondimentDecorator : Beverage {

        protected Beverage _beverage {get; set;}

        public override string getDescription(){
            return $"{this._beverage.getDescription()}, {this.description}";
        }
    }
    
    public class Milk : CondimentDecorator{

        public Milk(Beverage beverage){
            description = "milk";
            _beverage = beverage;
        }

        public override int cost(){
            return _beverage.cost() + 2;
        }
    }
    public class Mocha : CondimentDecorator{

        public Mocha(Beverage beverage){
            description = "mocha";
            _beverage = beverage;
        }

        public override int cost(){
            return _beverage.cost() + 3;
        }
    }
    public class Soy : CondimentDecorator{

        public Soy(Beverage beverage){
            description = "soy";
            _beverage = beverage;
        }

        public override int cost(){
            return _beverage.cost() + 5;
        }
    }
    public class Whip : CondimentDecorator{

        public Whip(Beverage beverage){
            description = "with whip";
            _beverage = beverage;
        }

        public override int cost(){
            return _beverage.cost() + 2;
        }
    }

    private static void Main(string[] args)
    {
        var blackCoffe = new DarkBlend(Beverage.enumSize.GRANDE);
        var milkBlackCoffe = new Milk(blackCoffe);
        var whipMilkBlackCoffe = new Whip(milkBlackCoffe);

        var whipSoyDecaf = new Whip(new Soy(new DecafBlend(Beverage.enumSize.VENTI)));

        Console.WriteLine($"Beverage: {whipMilkBlackCoffe.getDescription()} Cost: {whipMilkBlackCoffe.cost()}");
        Console.WriteLine($"Beverage: {whipSoyDecaf.getDescription()} Cost: {whipSoyDecaf.cost()}");
        
        
    }

}