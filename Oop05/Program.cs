using System;

namespace Oop05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //ICircle circle = new Circle(5);
            //IRectangle rectangle = new Rectangle(4, 6);

            //circle.DisplayShaoedInfo();
            //rectangle.DisplayShaoedInfo();
            #endregion




            #region Q2
            //IAuthenticationService authService = new BasicAuthenticationService();

            //string username = "admin";
            //string password = "1234";
            //string role = "Admin";

            //if (authService.AuthenticateUser(username, password))
            //{
            //    Console.WriteLine("User authenticated.");

            //    if (authService.AuthorizeUser(username, role))
            //    {
            //        Console.WriteLine("User authorized as " + role);
            //    }
            //    else
            //    {
            //        Console.WriteLine("User is not authorized as " + role);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Authentication failed.");
            //}

            #endregion





            #region Q3
            //INotificationService emailService = new EmailNotificationService();
            //INotificationService smsService = new SmsNotificationService();
            //INotificationService pushService = new PushNotificationService();

            //emailService.SendNotification("nana@example.com", "Welcome to our service!");
            //smsService.SendNotification("01012345678", "Your code is 1234");
            //pushService.SendNotification("NanaDevice123", "You have a new alert!");
            #endregion




            #region Q4
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();

            Console.Write("Enter user type (Regular, Premium, Guest): ");
            string userType = Console.ReadLine()?.ToLower();

            User user;

            switch (userType)
            {
                case "regular":
                    user = new RegularUser(userName);
                    break;
                case "premium":
                    user = new PremiumUser(userName);
                    break;
                case "guest":
                    user = new GuestUser(userName);
                    break;
                default:
                    Console.WriteLine("Invalid type. Defaulting to Guest.");
                    user = new GuestUser(userName);
                    break;
            }

            Console.Write("Enter product price: ");
            decimal price = decimal.Parse(Console.ReadLine());

            Console.Write("Enter product quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            Discount discount = user.GetDiscount();
            decimal discountAmount = discount?.CalculateDiscount(price, quantity) ?? 0;
            decimal totalPrice = price * quantity - discountAmount;

            Console.WriteLine("\n----- Summary -----");
            Console.WriteLine($"User: {user.Name} ({userType})");
            Console.WriteLine($"Original Price: {price * quantity}");
            Console.WriteLine($"Discount: {(discount != null ? discount.Name : "No Discount")}");
            Console.WriteLine($"Discount Amount: {discountAmount}");
            Console.WriteLine($"Final Price: {totalPrice}");
        }

        #endregion
    }
    }
