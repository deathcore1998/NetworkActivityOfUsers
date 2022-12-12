using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DmitrievaKursach
{
    internal class AnalyzeController
    {
        Dictionary<int, List<string>> inputData;
        List<string> corporateData;
        public AnalyzeController(Dictionary<int, List<string>> _inputData, List<string> _corporateData)
        {
            this.inputData = _inputData;
            this.corporateData = _corporateData;
        }

        public List<Statistic> Analyze()
        {
            List<Statistic> userStatisticInfo = new List<Statistic>();
            List<Statistic> resultList = new List<Statistic>();

            for (int i = 0; i < this.inputData[Constants.WEB_SITE_URL].Count; i++)
            {
                userStatisticInfo.Add(new Statistic(    this.inputData[Constants.USER_IP_ADRESS][i],
                                                        this.inputData[Constants.WEB_SITE_URL][i],
                                                        isCorporateWebSiteCheck(this.inputData[Constants.WEB_SITE_URL][i]),
                                                        0));
            }

            for (int i = 0; i < userStatisticInfo.Count; i++)
            {
                int counter = 0;
                for (int j = 0; j < userStatisticInfo.Count; j++) 
                    if (userStatisticInfo[i].UserIp.Equals(userStatisticInfo[j].UserIp) &&
                        userStatisticInfo[i].WebSite.Equals(userStatisticInfo[j].WebSite)) counter++;

                userStatisticInfo[i].Counter = counter;
            }


            foreach (var userStatistic in userStatisticInfo)
            {
                if (resultList.Count > 0)
                {
                    if (!resultList.Any(x => x.UserIp == userStatistic.UserIp && x.WebSite == userStatistic.WebSite)) resultList.Add(userStatistic);
                }
                else resultList.Add(userStatistic);
            }

            return resultList;
        }

        private bool isCorporateWebSiteCheck (string url)
        {
            foreach (string element in corporateData)
            {
                Console.WriteLine(element + " - " + url + " - " + element.Equals(url).ToString());
                if (element == url) return true;
            }
            return false;
        }
    }

    public class Statistic
    {
        public string UserIp           { get; set; }
        public string WebSite          { get; set; }
        public bool IsCorporateWebSite { get; set; }
        public int Counter             { get; set; }

        public Statistic (string _userIp, string _webSite, bool _isCorporateWebSite, int _count)
        {
            this.UserIp = _userIp; 
            this.WebSite = _webSite;
            this.IsCorporateWebSite = _isCorporateWebSite;
            this.Counter = _count;
        }
    }

}
