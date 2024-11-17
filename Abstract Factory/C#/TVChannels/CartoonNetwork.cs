namespace AbstractFactory.TvChannels
{
    internal class CartoonNetwork : ITVChannel
    {
        public string getChannelName() => "Cartoon Network Portugal";
        public int getChannelNumber() => 45;
    }
}
