// See https://aka.ms/new-console-template for more information
using lad5._1;

Controller controller=new Controller();
int ch;
do {
    Console.WriteLine("====Action====");
    Console.WriteLine("1. Add Product");
    Console.WriteLine("2. Edit Product");
    Console.WriteLine("3. Delete Product");
    Console.WriteLine("4. View all Product");
    Console.WriteLine("5. Search product by Id ");
    Console.WriteLine("6. Search product by Name ");
    Console.WriteLine("7. End ");
    Console.WriteLine("Please enter your selection");
    ch=int.Parse(Console.ReadLine());
    switch (ch) {
        case 1:
            controller.CreateProduct();
            break;
        case 2:
            controller.EditProduct();
            break;
        case 3:
            controller.DeleteById();
            break;
        case 4:
            controller.GetAllProduct();
            break;
        case 5:
            controller.SearchProductById();
            break;
        case 6:
            controller.SearchProductByName();
            break;
        case 7:
            default: Console.WriteLine("====================");
            Console.WriteLine("Exit");
            break;
    }

} while (ch!=7);

