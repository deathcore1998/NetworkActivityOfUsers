using System.Collections.Generic;

namespace DmitrievaKursach
{
    internal class FileController
    {
        public string inputWebSitesFilePath = "InputFile.txt";
        public string corpoateWebSitesFilePath = "Services.txt";
        public FileController () { }

        public void addCorporateDataItem (string _url)
        {
            List<string> contentList = ImportFile(corpoateWebSitesFilePath);
            contentList.Add(_url);

            FileWriter fileWriter = new FileWriter(corpoateWebSitesFilePath);
            fileWriter.WriteFile(contentList, false);
        }

        public void deleteCorporateDataItem(int _index)
        {
            List<string> contentList = ImportFile(corpoateWebSitesFilePath);
            if (contentList.Count == 0) return;
            
            contentList.RemoveAt(_index);
            FileWriter fileWriter = new FileWriter(corpoateWebSitesFilePath);
            fileWriter.WriteFile(contentList, false);
        }

        public Dictionary<int, List<string>> GetInputData ()
        {
            List<string> contentList = ImportFile(inputWebSitesFilePath);
            if (contentList == null) return null;
            return TransformInputData(contentList);
        }

        public List<string> GetCorporateServicesData()
        {
            List<string> contentList = ImportFile(corpoateWebSitesFilePath);
            if (contentList == null) return null;
            return contentList;
        }

        private List<string> ImportFile(string _path)
        {
            FileReader fileReader = new FileReader(_path);
            if (!fileReader.isLoadSuccess()) return null;
            return fileReader.ContentList;
        }

        private Dictionary<int, List<string>> TransformInputData(List<string> _data)
        {
            List<string> userAdressList =   new List<string>();
            List<string> websiteTimeList =  new List<string>();
            List<string> websiteUrlList =   new List<string>();

            if (_data.Count == 0) return null;
            foreach (string line in _data)
            {
                string[] lineArray = line.Split(' ');
                if (lineArray.Length < 3) continue;

                userAdressList.Add(lineArray[0]);
                websiteTimeList.Add(lineArray[1]);
                websiteUrlList.Add(lineArray[2]);
            }

            return new Dictionary<int, List<string>>()
            {
                { Constants.USER_IP_ADRESS,   userAdressList},
                { Constants.WEB_SITE_TIME,    websiteTimeList},
                { Constants.WEB_SITE_URL,     websiteUrlList}
            };
        }
    }
}
