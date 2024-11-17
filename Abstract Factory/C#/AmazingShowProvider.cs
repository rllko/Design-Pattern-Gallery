namespace AbstractFactory
{
    abstract class AmazingShowProvider
    {
        public static IAmazingShowProvider CreateTVChannel(string channel) =>
            channel switch
            {
                "cartoon network" => new CartoonNetworkProvider(),
                "nickelodeon" => new NickelodeonShowProvider(),
                _ => throw new InvalidOperationException("Not a valid channel, pick a good one!")
            };
    }
}
