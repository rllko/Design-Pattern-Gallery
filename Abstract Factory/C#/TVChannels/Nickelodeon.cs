namespace AbstractFactory.TvChannels
{
    internal class Nickelodeon : ITVChannel
    {
        public string getChannelName() => "Nickelodeon Portugal";
        public int getChannelNumber() => 41;
    }
}
