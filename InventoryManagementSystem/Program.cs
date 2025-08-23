namespace InventoryManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // add product (id name quantaty price)
            // update product
            // view product 
            // exit 

            while (true) { 
            Console.WriteLine("Welcome To My InventoryManagementSystem");
            Console.WriteLine("=======================================");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Update Product");
            Console.WriteLine("3. View Product");
            Console.WriteLine("4. Exit");

            int userInput = Convert.ToInt32(Console.ReadLine());

            switch (userInput)
                {
                 case 1:
                        // add product 
                        break;
                 case 2:
                        // update product
                        break;
                 case 3:
                        // view product 
                        break;
                 case 4:
                        // exit 
                        Environment.Exit(0);
                        break;
                }


            }






















            }

        private static void AddProduct()
        {

        }






















    }
}
