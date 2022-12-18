using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_IO_Opeerations
{
    public class Operations
    {
        public void FileExists()
        {
            Console.WriteLine("\n============ File Exists Operations ============ \n");
            string filePath = @"C:\Bridgelabz\File_IO_Operations\File_IO_Operations\File_IO_Opeerations\File_IO_Opeerations\WorldFile1.txt";
            if (File.Exists(filePath))
            {
                Console.WriteLine("\nFile Exists");
            }
            else
            {
                Console.WriteLine("\nFile Not Found");
            }
        }

        public void ReadAllLines()
        {
            Console.WriteLine("\n**********Read All Lines**********\n");
            string filePath = @"C:\Bridgelabz\File_IO_Operations\File_IO_Operations\File_IO_Opeerations\File_IO_Opeerations\WorldFile1.txt";
            string[] lines;
            lines = File.ReadAllLines(filePath);
            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);
        }

        public void ReadAllText()
        {
            Console.WriteLine("\n**********Read All Text**********\n");
            string filePath = @"C:\Bridgelabz\File_IO_Operations\File_IO_Operations\File_IO_Opeerations\File_IO_Opeerations\WorldFile1.txt";
            string text;
            text = File.ReadAllText(filePath);
            Console.WriteLine(text);
        }
    }
}
