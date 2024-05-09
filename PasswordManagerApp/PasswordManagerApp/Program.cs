
using System.Text;

namespace App
{
    public class Program
    {
        private static readonly Dictionary<string, string> _passwords = new();
        static void Main(string[] args)
        {
            ReadPasswords();

            if (_passwords.ContainsKey("MasterKey"))
            {
                Console.Write("please Enter the Password: ");
                string masterPassword = Console.ReadLine();

                if (_passwords["MasterKey"].Equals(masterPassword))
                {
                    App();
                }
                else
                {
                    Console.WriteLine("Invalid Password ");
                }
            }
            else
            {
                Console.Write("Enter your Master Password: ");
                string masterPassword = Console.ReadLine();
                _passwords.Add("MasterKey", masterPassword);
                App();
            }
        }

        private static void App()
        {
            bool programFlag = true;
            while (programFlag)
            {

                Console.WriteLine("Please Select an Option.");
                Console.WriteLine("[1] List all of your passwords.");
                Console.WriteLine("[2] Add or Change a password.");
                Console.WriteLine("[3] Get a passwords.");
                Console.WriteLine("[4] Delete a passwords.");
                Console.WriteLine("[5] Exit the Program.");

                string selectedOption = Console.ReadLine().Trim();

                switch (selectedOption)
                {
                    case "1":
                        ListPasswords();
                        break;
                    case "2":
                        AddChangePassword();
                        break;
                    case "3":
                        GetPassword();
                        break;
                    case "4":
                        DeletePassword();
                        break;
                    case "5":
                        programFlag = false;
                        break;
                    default:
                        Console.WriteLine("Please Enter a Valid Option");
                        break;
                }
                Console.WriteLine("=================================\n");

            }
        }



        private static void ReadPasswords()
        {
            if (File.Exists("passwords.txt"))
            {
                var passwordLines = File.ReadAllText("passwords.txt");

                foreach (var line in passwordLines.Split(Environment.NewLine))
                {
                    if (!string.IsNullOrEmpty(line))
                    {
                        var equalSign = line.IndexOf("=");
                        var key = line.Substring(0, equalSign);
                        var password = line.Substring(equalSign + 1);
                        _passwords.Add(key, password);
                    }
                    else
                        break;
                }

            }
        }

        private static void SavePassword()
        {
            var sb = new StringBuilder();
            foreach (var word in _passwords)
            {
                sb.AppendLine($"{word.Key}={word.Value}");
            }
            File.WriteAllText("passwords.txt", sb.ToString());

        }

        private static void DeletePassword()
        {
            Console.Write("Enter App Name: ");
            string appName = Console.ReadLine().Trim();
            if (_passwords.ContainsKey(appName))
            {
                Console.WriteLine("Password Deleted.");
                _passwords.Remove(appName);
                SavePassword();
            }
            else
                Console.WriteLine("The App NOT FOUND!! ");
        }

        private static void GetPassword()
        {
            Console.Write("Enter App Name: ");
            string appName = Console.ReadLine().Trim();
            if (_passwords.ContainsKey(appName))
                Console.WriteLine($"- {appName} ==> password = {_passwords[appName],-10}");
            else
                Console.WriteLine("The App NOT FOUND!! ");
        }

        private static void AddChangePassword()
        {
            Console.Write("Enter App Name: ");
            var appName = Console.ReadLine().Trim();

            if (_passwords.ContainsKey(appName))
            {
                Console.WriteLine("The App you entered in the last.");
                Console.Write("Enter the new Password: ");
                string newPassword = Console.ReadLine();

                _passwords[appName] = newPassword;
                SavePassword();
            }
            else
            {
                Console.Write("Enter the Password: ");
                string newPassword = Console.ReadLine();
                _passwords.Add(appName, newPassword);
                SavePassword();
            }
        }

        private static void ListPasswords()
        {
            foreach (var password in _passwords)
            {
                Console.WriteLine($"- {password.Key,-10} ==> password = {password.Value,10}");
            }
        }
    }

}



