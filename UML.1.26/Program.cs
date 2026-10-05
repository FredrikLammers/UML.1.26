using UML._1._26;

Pizza pizza1 = new Pizza(1,"Marcerita","Tomato & Chesse",69);
Pizza pizza2 = new Pizza(2,"Vesuvio", "Tomato, Chesse & Ham", 75);
Pizza pizza3 = new Pizza(3,"Capricciosa", "Tomato, Chesse, Ham & Mushroom", 80);

Customer customer1 = new Customer("Peter", 12345678, "Gade 123", 1);
Customer customer2 = new Customer("Mikkel", 98765432, "Alleen 321", 2);
Customer customer3 = new Customer("Charlotte", 24682468, "Vej 111", 0);

Order order1 = new Order(customer1,pizza1,"10:10",1,false);
Order order2 = new Order(customer2,pizza2,"12:01", 0, true);
Order order3 = new Order(customer3,pizza3,"06:04",2,false);

Console.WriteLine("--------------------------- Pizza --------------------------");
Console.WriteLine(pizza1.ToString());
Console.WriteLine(pizza2.ToString());
Console.WriteLine(pizza3.ToString());
Console.WriteLine("------------------------------------------------------------");
Console.WriteLine();

Console.WriteLine("--- Customers ---");
Console.WriteLine(customer1.ToString());
Console.WriteLine();
Console.WriteLine(customer2.ToString());
Console.WriteLine();
Console.WriteLine(customer3.ToString());
Console.WriteLine("-----------------");
Console.WriteLine();

Console.WriteLine(order1.ToString());
Console.WriteLine();
Console.WriteLine(order2.ToString());
Console.WriteLine();
Console.WriteLine(order3.ToString());
