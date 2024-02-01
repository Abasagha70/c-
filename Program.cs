

using LoginRegister.entity;
using LoginRegister.Manage.Abstract;
using LoginRegister.Manage.Concrete;




IUserService userService = new UserService();


bool programTime = true;


while (programTime)
{

    Console.WriteLine("Login olmaq ucun 1 \n Register olmaq ucun 2 duymesini basin");

    var userResult = int.Parse(Console.ReadLine());

    if (userResult == 1)
    {
        Console.Write("Email daxil edin");

        var email  = Console.ReadLine();


        Console.Write("Username daxil edin");

        var username=Console.ReadLine();

        Console.Write("Password daxil edin");

        var password = Console.ReadLine();

        var loginresult = userService.Login(email, password , username);

        Console.WriteLine(loginresult.ErrorMessage);

    }
    else if (userResult == 2)
    {

        User user = new LoginRegister.entity.User();

        Console.Write("Name daxil edin");
        user.Name = Console.ReadLine();

        Console.Write("Username daxil edin");
        user.Username = Console.ReadLine();


        Console.Write("Surname daxil edin");
        user.Surname = Console.ReadLine();


        Console.Write("Email daxil edin");
        user.Email = Console.ReadLine();

        Console.Write("Password daxil edin");
        user.Password = Console.ReadLine();

        var registerResult = userService.Register(user);
        Console.WriteLine(registerResult.ErrorMessage);

    }

    Console.WriteLine("Geri 1 duymesiyle qayit");

    var returnResult = int.Parse(Console.ReadLine());
    if (returnResult != 1) programTime = false;

}





