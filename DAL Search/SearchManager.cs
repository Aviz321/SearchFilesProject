using System;
using System.Collections.Generic;
using System.IO;
using DbManager;



namespace DAL_Search
{

    public delegate void FileFoundHandler(string Path);

    public class SearchManager
    {

        public string FileName { get; set; }
        public string Path { get; set; }

        List<string> SearchResult = new List<string>();


        public event FileFoundHandler OnFileFound;

        public List<string> Recursion(string Filename, string Path = "c:\\") //function that search the files in the computer
        {

            try
            {
                string[] DirectoryPath = Directory.GetDirectories(Path);
                string[] AllFiles = Directory.GetFiles(Path, $"*{Filename}*");

                foreach (string i in AllFiles)
                {
                    SearchResult.Add(i);
                    Console.WriteLine(i);
                    FileFound(i);

                }
                foreach (string i in DirectoryPath)
                {
                    Recursion(Filename, i);
                }
            }


            catch (Exception error)
            {
                if (error is UnauthorizedAccessException) //skip the inaccessible files and folders
                {

                }


            }
           
            return SearchResult;
        }


        public string FileFound(string FullPath) //raising the event
        {

            OnFileFound?.Invoke(FullPath);
            DbTableManager.SaveResultsApp(FullPath);

            return FullPath;
        }

    }

}
