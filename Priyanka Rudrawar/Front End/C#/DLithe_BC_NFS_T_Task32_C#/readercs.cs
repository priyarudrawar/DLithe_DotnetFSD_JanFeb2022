using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.IO;

namespace DLithe_BC_NFS_T_Task32
{
    internal class StreamReader
    {
        private FileStream fs;

        public StreamReader(FileStream fs)
        {
            this.fs = fs;
        }

        public object BaseStream { get; private set; }

        class Program
        {
            class FileRead
            {
                public void ReadData()
                {
                    FileStream fs = new FileStream("F:\\Dlithe\\.net\\DLithe_BC_NFS_T_Task32\\details.txt", FileMode.Open, FileAccess.Read);
                    StreamReader sr = new StreamReader(fs);
                    Console.WriteLine("Program to show content of test file");
                    //   object p = sr.BaseStream.Seek(0, SeekOrigin.Begin);
                    string str = sr.ReadLine();
                    while (str != null)
                    {
                        Console.WriteLine(str);
                        str = sr.ReadLine();
                    }
                    Console.ReadLine();
                    // sr.Close();
                    fs.Close();
                }
            }
            static void Main(string[] args)
            {
                FileRead wr = new FileRead();
                wr.ReadData();
            }
        }

        private string ReadLine()
        {
            throw new NotImplementedException();
        }
    }
}
