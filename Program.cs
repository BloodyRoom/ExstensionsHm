using Homework_1;
namespace Homework_1;

public class Program
{
    static async Task Main(string[] args)
    {
        string image = "https://images.panda.org/assets/images/pages/welcome/orangutan_1600x1000_279157.jpg";
        // Console.WriteLine(await image.UriToBase64());
        // File.WriteAllText(@"base64.txt", await image.UriToBase64());

        string phone = "0509985114";
        Console.WriteLine(phone.ToPhoneFormat());
    }
}
