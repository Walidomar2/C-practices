using System.Runtime.ExceptionServices;

namespace fileSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write(">> ");
                string input = Console.ReadLine().Trim();
                int firstWhiteSpace = input.IndexOf(' ');   
                string command = input.Substring(0, firstWhiteSpace).ToLower();
                string path = input.Substring(firstWhiteSpace + 1).Trim();
                //Console.WriteLine(command);
                //Console.WriteLine(path);

                if(command == "list")
                {
                    foreach(var dir in Directory.GetDirectories(path))
                        Console.WriteLine($" [Dir]: {dir}");

                    foreach (var file in Directory.GetFiles(path))
                        Console.WriteLine($" [File]: {file}");
                }
                else if(command == "info")
                {
                    if(Directory.Exists(path))
                    {
                        var dirInfo = new DirectoryInfo(path);
                        Console.WriteLine("Type: Directory");
                        Console.WriteLine($"Created At: {dirInfo.CreationTime}");
                        Console.WriteLine($"Last Modified At: {dirInfo.LastWriteTime}");
                    }
                    else if(File.Exists(path))
                    {
                        var fileInfo = new FileInfo(path);
                        Console.WriteLine("Type: File");
                        Console.WriteLine($"Created At: {fileInfo.CreationTime}");
                        Console.WriteLine($"Last Modified At: {fileInfo.LastWriteTime}");
                        Console.WriteLine($"File Extension: {fileInfo.Extension}");
                        Console.WriteLine($"File Size in Bytes {fileInfo.Length}");
                    }
                    else
                    {
                        Console.WriteLine("File Not found !!");
                    }
                     
                }
                else if(command == "mkdir")
                {
                    Directory.CreateDirectory(path);
                }
                else if(command == "remove")
                {

                    if(Directory.Exists(path))
                        Directory.Delete(path);

                    if(File.Exists(path))
                        File.Delete(path);

                }
                else if(command == "print")
                {
                    if(File.Exists(path))
                    {
                        var content = File.ReadAllText(path);
                        Console.WriteLine(content);
                    }
                }
                else if(command == "exit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Command");
                }

            }
        }
    }
}
