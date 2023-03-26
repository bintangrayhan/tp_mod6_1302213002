using tpmod6_1302213002;

class Program
{
    static void Main(String[] args)
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design by Contract - [Bintang rayhan wijaya_PRAKTIKAN]");

        

        for (int i = 0; i < 1000000000; i += 10000000)
        {
            video.IncreasePlayCount_1302213002(10000000);
        }
        video.PrintVideoDetails_1302213002();
    }
}