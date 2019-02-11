using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            Directories();
            Console.ReadLine();
        }

        public static void Directories()
        {
            try
            {
                //accepting path from the user
                Console.WriteLine("enter directory path:");
                string path = Console.ReadLine();
                int count=0;
                //retriving details from c: drive
                DirectoryInfo info = new DirectoryInfo(@"c:\" + path);
                if (info.Exists)
                {

                DirectoryInfo[] directories = info.GetDirectories("*", SearchOption.TopDirectoryOnly);
                foreach (DirectoryInfo directory in directories)
                {
                    //retriving the files from the current directory
                    FileInfo[] files = directory.GetFiles();

                    foreach (FileInfo fileInfo in files)
                    {
                        //retriving the extension of the file
                        string extension = Path.GetExtension(fileInfo.FullName);
                        //Checking for .cs extension

                        Console.WriteLine("{0}=>{1}", directory.Name, fileInfo.Name);
                            count++;

                    }
                }
                    Console.WriteLine("no.of files :"+ count);
                }
                else
                {
                    Console.WriteLine("directory not found");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
    
}
