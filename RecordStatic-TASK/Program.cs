using RecordStatic_TASK;

User[] users = new User[3];
for (int i = 0; i < users.Length; i++)
{
    Console.WriteLine($"Enter details for user  {i + 1}:");
    Console.Write("Fullname:");
    string fullname = Console.ReadLine();
    Console.Write("Email:");
    string email = Console.ReadLine();
    Console.Write("Password:");
    string password = Console.ReadLine();
    Console.WriteLine(" ");

    users[i] = new User(fullname, email, password);
}

while (true)
{
    Console.WriteLine("Menu:");
    Console.WriteLine("1)Show all students.");
    Console.WriteLine("2)Get info by Id.");
    Console.WriteLine("3)Quit.");
    Console.WriteLine(" ");
    Console.WriteLine("Select:");
    int choice = int.Parse(Console.ReadLine());
    if (choice == 1)
    {
        Console.WriteLine("All students:");
        foreach (User user in users)
        {
            user.GetInfo();
        }
        //Console.ReadLine();
        //Console.Clear();
    }
    else if (choice == 2)
    {
        Console.WriteLine("Enter user Id");
        int id = int.Parse(Console.ReadLine());
        User founduser = User.FindUserById(id, users);
        if (founduser != null)
        {
            Console.WriteLine("User found:");
            founduser.GetInfo();
        }
        else
        {
            Console.WriteLine("User not found:");
        }
        //Console.ReadLine() ;
        //Console.Clear() ;
    }
    else if (choice == 3)
    {
        return;
    }
    else
    {
        Console.WriteLine("Please enter correct choice:");
    }
}