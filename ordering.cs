namespace симулятор_торта
{
    public class order
    {
        public string[] title = new string[5];
        public int[] price = new int[5];
        public order(string[] title1, int[] price1)
        {
            title = title1;
            price = price1;
        }
    }
}