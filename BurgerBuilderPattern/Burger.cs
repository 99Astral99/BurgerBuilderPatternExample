using System.Text;

namespace BurgerBuilderPattern
{
    public class Burger
    {
        public bool Cotlet { get; set; }
        public bool Cucumber { get; set; }
        public bool Salad { get; set; }
        public bool Bacon { get; set; }
        public bool Cheeze { get; set; }
        public bool Tomato { get; set; }
        public decimal Total { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(">>> Your order! <<<\n");
            sb.Append("Tasty burger with: \n\n");

            if (Cotlet)
                sb.Append("- Cotelet\n");
            if (Cucumber)
                sb.Append("- Cucumber\n");
            if (Salad)
                sb.Append("- Salad\n");
            if (Bacon)
                sb.Append("- Bacon\n");
            if (Cheeze)
                sb.Append("- Cheeze\n");
            if (Tomato)
                sb.Append("- Tomato\n");

            sb.Append($"\nTotal: {Total}$\n");
            sb.Append("\n>>> Thanks for purchasing! <<<\n");
            return sb.ToString();
        }
    }
}
