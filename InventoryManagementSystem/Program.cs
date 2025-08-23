namespace InventoryManagementSystem
{
    internal class Program
    {
        const int numberOfProduct = 50;
        static string[,] inventory = new string[ numberOfProduct , 3 ];
        static int productcount = 0;
        static void Main(string[] args)
        {
            // add product (id name quantaty price)
            // update product
            // view product 
            // exit 
            while (true)
            {
                Console.WriteLine("Welcome To My InventoryManagementSystem");
                Console.WriteLine("=======================================");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Update Product");
                Console.WriteLine("3. View Product");
                Console.WriteLine("4. Exit");

                Console.WriteLine("Choose The Number");
                int userInput = Convert.ToInt32(Console.ReadLine());

                switch (userInput)
                {
                    case 1:
                        // add product
                        AddProduct();
                        break;
                    case 2:
                        // update product
                        updateProduct();
                        break;
                    case 3:
                        // view product 
                        ViewProduct();
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
            Console.WriteLine("Enter Product Name : ");
            string productName = Console.ReadLine();

            Console.WriteLine("Enter Product Quantaty : ");
            string productQuantaty = Console.ReadLine();

            Console.WriteLine("Enter Product Price : ");
            string productPrice = Console.ReadLine();


            inventory[productcount, 0] = productName;
            inventory[productcount, 1] = productQuantaty;
            inventory[productcount, 2] = productPrice;

            productcount++;

            Console.WriteLine("Product Added Successfuly");

        }
        private static void updateProduct()
        {

            Console.WriteLine("Enter The Name Product To Update :");
            string searchProduct = Console.ReadLine();

            int productID = -1;

            if (productcount > 0)
            {
                for (int i = 0; i < productcount; i++)
                {

                    if (inventory[i, 0] == searchProduct)
                    {
                        productID = i;
                        break;
                    }

                }
                if (productID != -1)
                {
                    Console.WriteLine("Enter The New Quantaty");
                    string newQantaty = Console.ReadLine();

                    inventory[productID, 1] = newQantaty;

                    Console.WriteLine("Quantaty Updated Successfuly");
                }


            }
            else
            {
                Console.WriteLine("Inventory Is Empty");
            }
        }
        private static void ViewProduct()
        {
            if (productcount > 0)
            {

                Console.WriteLine("Product List :");
                Console.WriteLine();
                for (int i = 0; i < productcount; i++)
                {

                    Console.WriteLine($"Product Id :{i} , Product Name :{inventory[i, 0]} , Product Quantaty : {inventory[i, 1]} , Product Price :{inventory[i, 2]}");
                }

            }
            else 
            {
                Console.WriteLine("Inventory Is Empty");
            }

        }
    }
}
