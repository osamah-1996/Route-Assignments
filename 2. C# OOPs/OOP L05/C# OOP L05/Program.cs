using C__OOP_L05.NotificationExample;
using C__OOP_L05.ShapeExample;

namespace C__OOP_L05
{
    internal class Program
    {
        static void Main()
        {
            #region Q 1: This is the part of Question  1
            //ICircle myCircle = new Circle(5.5);
            //IRectangle myRectangle = new Rectangle(4.0, 6.0);
            //myCircle.DisplayShapeInfo();
            //myRectangle.DisplayShapeInfo(); 
            #endregion



            #region Q 2:  This is the part of Question  2
            //IAuthenticationService authService = new BasicAuthenticationService();

            //Console.Write("Enter Username: ");
            //string username = Console.ReadLine();

            //Console.Write("Enter Password: ");
            //string password = Console.ReadLine();

            //// Authenticate User
            //if (authService.AuthenticateUser(username, password))
            //{
            //    Console.WriteLine("Authentication successful!");

            //    Console.Write("Enter Role to Check Authorization: ");
            //    string role = Console.ReadLine();

            //    // Authorize User
            //    if (authService.AuthorizeUser(username, role))
            //    {
            //        Console.WriteLine("Authorization successful! User has access.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Authorization failed! User does not have the required role.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Authentication failed! Invalid username or password.");
            //}

            #endregion


            #region Q 3:This is the part of Question  3

            //INotificationService emailService = new EmailNotificationService();
            //INotificationService smsService = new SmsNotificationService();
            //INotificationService pushService = new PushNotificationService();

            //string recipient = "osamahshweesh@gmail.com";
            //string message = "Your order has been shipped!";

            //emailService.SendNotification(recipient, message);
            //smsService.SendNotification("+601121329117", message);
            //pushService.SendNotification("OsamahShweeshId", message); 
            #endregion







        }
    }
}
