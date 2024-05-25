using AbstractFactory.TvChannels;
using AbstractFactory.TVShows;

namespace AbstractFactory
{
    internal class AmazingShowProvider
    {
        public static ITVChannel CreateChannel(Channel channel) => channel switch
        {
            Channel.CartoonNetwork => new CartoonNetwork(),
            Channel.Nickelodeon => new Nickelodeon(),
            _ => throw new NotImplementedException()
        };
        public static ITVShow CreateShow(Channel channel) => channel switch
        {
            Channel.CartoonNetwork => new AmazingWorldOfGumball(),
            Channel.Nickelodeon => new Spongebob(),
            _ => throw new NotImplementedException()
        };
    }
}
