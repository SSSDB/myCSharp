using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{

  namespace OrderManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Order Management System!");
            OrderService service = new OrderService();
                string path = @"orders.xml";
                //Person p = new Person { id = 1001, name = "tommy", age = 30 };
                //List<Order> ord = (List<Order>)service.Import(path, typeof(List<Order>)); 
                //foreach (Order ords in ord) { Console.Write(ords.ToString1()); }
                service.Import(path);
                while (true)
            {
                try
                {
                    String orderID;
                    String customerName;
                        Console.WriteLine("\n");
                        String action = GetInput("1.add an order\t2.delete an order\t3.alter your order\t4.sort your orders\nPlease select an action: ");
                    switch (action)
                    {
                        case "1":
                            customerName = GetInput("Customer name:");
                            service.AddOrder(customerName, Int32.Parse(DateTime.Now.ToString("HHmmss")));
                            Console.WriteLine("Add an order successful!");
                                service.PrintOrders(service.orderList);
                            //Console.WriteLine("Your order ID is:" );
                            break;
                        case "2":
                            orderID = GetInput("Order ID:");
                            service.DeleteOrder(Int32.Parse(orderID));
                                Console.WriteLine("Delete the order successful!");
                                service.PrintOrders(service.orderList);

                            break;
                        case "3":
                            orderID = GetInput("Order ID:");
                            String operation = GetInput( "add item\t" +"delete item\nPlease select an operation:" );
                                /*String modifyData = "";
                                if(operation != "add item")
                                {
                                    modifyData = GetInput("The data After modify:");
                                }*/
                            //object data = null;
                            //int goodsID = 0;
                            
                            switch (operation)
                            {
                                case "add item":
                                        Console.WriteLine("Please enter item，amount and unitprice ,Separated by space");
                                        //goodsID = Int32.Parse(GetInput("Goods ID:"));
                                        string[] string1 = System.Text.RegularExpressions.Regex.Split(Console.ReadLine(), @"[ ]+");
                                        string[] par3 = new string[3];
                                        for (int i = 0; i < 3; i++)
                                        {
                                            par3[i] = string1[i];
                                        }
                                        service.AlterOrder(Int32.Parse(orderID), operation, par3);

                                        service.PrintOrders(service.orderList);
                                        break;

                                case "delete item":
                                        Console.WriteLine("Please enter item and amount ,Separated by space");
                                        //goodsID = Int32.Parse(GetInput("Goods ID:"));
                                        string[] string2 = System.Text.RegularExpressions.Regex.Split(Console.ReadLine(), @"[ ]+");
                                        string[] par2 = new string[2];
                                        for (int i = 0; i < 2; i++)
                                        {
                                            par2[i] = (string2[i]);
                                        }
                                        service.AlterOrder(Int32.Parse(orderID), operation, par2);
                                        service.PrintOrders(service.orderList);
                                        break;                              
                                default:
                                        throw new ArgumentException("Invalid input!");
                            }
                            break;
                            case "4":
                             Console.WriteLine("Please enter search conditions:");
                             customerName = GetInput("Customer name:");
                             orderID = GetInput("Order ID:");
                             String goodsName = GetInput("Goods name:");
                             customerName = customerName == "" ? null : customerName;
                             orderID = orderID == "" ? null : orderID;                             
                             goodsName = goodsName == "" ? null : goodsName;
                             List<Order> results = service.SearchOrder(customerName, orderID, goodsName);
                             service.PrintOrders(results);
                                /*Console.WriteLine("Result:");
                             foreach(Order order in results)
                             {
                                 Console.WriteLine(order);
                             }*/
                             break;
                          default:
                             throw new ArgumentException("No such operation!");
                    }
                        service.Export(path);
                    }
                catch(ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch(FormatException)
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }
        private static String GetInput(String tip)
        {
            Console.Write(tip);
            return Console.ReadLine();
        }
    }
}
}
