using CureMedAI.CureMedAIBackend.Services;

class Program
{
    static void Main()
    {
        var userRepo = new UserRepository();

        userRepo.addUser("Ralph", "ralph.kjian@hotmail.com", "12345678", 20, "patient");
        Console.WriteLine("User added successfully");
    }
}