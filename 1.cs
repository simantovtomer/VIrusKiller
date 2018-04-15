using System;

namespace VirusKiller2
{
    class Program
    {
        static void Main(string[] args)
        {
     
            while (true)
            {

                DeleteFiles("*.exe");
                DeleteFiles("*.vbs");
                DeleteFiles("*.mp3");
                DeleteFiles("*.bat");

                System.Threading.Thread.Sleep(200);

            }

        }

        static void DeleteFiles(string searchPattern)
        {

            string[] files = System.IO.Directory.GetFiles("C:\\ProgramData", searchPattern);

            System.IO.FileInfo fi;

            foreach (string file in files)
            {

                fi = new System.IO.FileInfo(file);

                try
                {
                    Console.WriteLine(DateTime.Now.ToString() + " Delete file..." + fi.Name);
                    System.IO.File.Delete(file);
                    Console.WriteLine(DateTime.Now.ToString() + " Deleted.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(DateTime.Now.ToString() + " " + ex.ToString());
                }

            }

        }


    }
}
