using AbstractFactory.TvChannels;
using AbstractFactory.TVShows;

namespace AbstractFactory.Factories
{
    internal class CartoonNetworkFactory : ITvChannelFactory
    {
        public ITVChannel CreateChannel() => new CartoonNetwork();

        public ITVShow CreateShow() => new AmazingWorldOfGumball();
    }
}
