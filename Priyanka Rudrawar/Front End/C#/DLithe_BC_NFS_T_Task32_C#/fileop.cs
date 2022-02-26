using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;
using System.IO;


namespace DLithe_BC_NFS_T_Task32
{
    internal class FilesOperations
    {


        class FileWrite
        {
            public void WriteData()
            {
                FileStream fs = new FileStream("F:\\Dlithe\\.net\\DLithe_BC_NFS_T_Task32\\details.txt", FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                Console.WriteLine("Enter the text which you want to write to the file");
                string str = Console.ReadLine();
                sw.WriteLine(str);
                sw.Flush();
                sw.Close();
                fs.Close();
            }
        }
        static void Main(string[] args)
        {
            FileWrite wr = new FileWrite();
            wr.WriteData();
        }
    }
}

