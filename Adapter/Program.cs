internal class Program
{
    public interface CrediCard
    {
        public void paymentMethod(int amount);
    }

    public class GooglePay
    {
        private int amount;

        public GooglePay(int InitialAmount)
        {
            this.amount = InitialAmount;
        }

        public void ElectronicPaymentMethod(int amountToDiscount)
        {
            this.amount = this.amount - amountToDiscount;
            Console.WriteLine($"Amount left {this.amount}");

        }
    }

    public class CreditCardAdapter : CrediCard
    {
        GooglePay googlePay;

        public CreditCardAdapter(GooglePay googlePay)
        {
            this.googlePay = googlePay;
        }

        public void paymentMethod(int amount)
        {
            this.googlePay.ElectronicPaymentMethod(amount);
        }
    }

    private static void Main(string[] args)
    {
        GooglePay googlePay = new GooglePay(100);
        CrediCard googleCard = new CreditCardAdapter(googlePay);

        googleCard.paymentMethod(10);
    }
}