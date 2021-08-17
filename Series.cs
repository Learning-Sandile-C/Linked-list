using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linked_list
{
    class Series : Television
    {
        int seasonNum, episodeNum;

        public Series(int seasonNum, int episodeNum, Television television) : base(television)
        {
            this.seasonNum = seasonNum;
            this.episodeNum = episodeNum;
        }

        public string getName()
        {
            return Name;
        }
        public double getRating()
        {
            return Rating;
        }
        public string getDetails()
        {
            return seasonNum.ToString() + episodeNum.ToString();
        }
    }
}
