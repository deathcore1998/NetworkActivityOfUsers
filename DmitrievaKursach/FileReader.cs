using System.Collections.Generic;
using System.IO;

namespace DmitrievaKursach
{
    internal class FileReader
    {
        public string Path { get; set; }
        public List<string> ContentList;

        public FileReader(string _path) {
            this.Path = _path;
            this.LoadFile();
        }

        private void LoadFile ()
        {
            try
            {
                this.ContentList = new List<string>();

                StreamReader f = new StreamReader(this.Path);
                while (!f.EndOfStream)
                {
                    string textLine = f.ReadLine();
                    ContentList.Add(textLine);
                }
                f.Close();
            }
            catch
            {
                this.ContentList = null;
            }
        }

        public bool isLoadSuccess ()
        {
            return this.ContentList != null;
        }
    }
}
