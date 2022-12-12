using System.Collections.Generic;
using System.IO;

namespace DmitrievaKursach
{
    internal class FileWriter
    {
        public string Path { get; set; }

        public FileWriter(string _path)
        {
            this.Path = _path;
        }

        public void WriteFile (List<string> _contentList, bool _isAppend = true)
        {
            FileReader fileReader = new FileReader(this.Path);
            if (!fileReader.isLoadSuccess()) return;

            try
            {
                using (StreamWriter file = new StreamWriter(this.Path, _isAppend))
                {
                    foreach (string line in _contentList)
                        file.WriteLine(line);
                }
            }
            catch
            {
                using (StreamWriter file = new StreamWriter(this.Path, false))
                {
                    foreach (string line in fileReader.ContentList)
                        file.WriteLine(line);
                }
            }
        }
    }
}
