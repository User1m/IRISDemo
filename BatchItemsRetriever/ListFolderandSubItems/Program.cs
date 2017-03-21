using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ListFolderandSubItems
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //specify directory in arg0 and type of file in arg1, will return a list of files with direct path 
            string[] allfiles = Directory.GetFiles(args[0], "*."+args[1], SearchOption.AllDirectories);
            Console.WriteLine("Directory : "+ args[0]);
            Console.WriteLine("File Type : *." + args[1]);
            Console.WriteLine("----------------------------");
            foreach (string file in allfiles)
                System.Console.WriteLine(file);
                */

            //fileList is the outPut
            List<string> fileList = new List<string>();

            //specify directory in arg0 and type of file in arg1 eg. 'jpg'
            //and max number of file you want from each dir in arg2, will return a list of files with direct path 
            string[] alldirectories = Directory.GetDirectories(""+ args[0]);

            

            foreach (string dir in alldirectories)
            {
                fileList.AddRange(GetListOfFileByNumber(dir,"*."+args[1],Int32.Parse(args[2]))); // or just change arg2 with a number in the code
            }

        }


        static private string[] GetListOfFileByNumber(string directory,string type, int number)
        {
            string[] allfiles = Directory.GetFiles(directory, type, SearchOption.TopDirectoryOnly);
            if (allfiles.Count() <= number) return allfiles;
            {
                string[] result = new string[number];
                Array.Copy(allfiles, 0, result, 0, number);
                return result;
            }
        }
        

    }
}
