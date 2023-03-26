using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmod6_1302213002
{
    public class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            Contract.Requires(title != null);
            Contract.Requires(title.Length <= 100);

            Random rand = new Random();
            id = rand.Next(10000, 99999);
            this.title = title;
            playCount = 0;
        }

        public void IncreasePlayCount_1302213002(int count)
        {
            Contract.Requires(count <= 10000000);
            try
            {
                checked
                {
                    this.playCount += count;
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Error : {0} ", ex.Message);
            }
        }

        public void PrintVideoDetails_1302213002()
        {
            Console.WriteLine("Video ID : {0} ", id);
            Console.WriteLine("Title : {0} ", title);
            Console.WriteLine("Play Count : {0} ", playCount);
        }
    }
}
