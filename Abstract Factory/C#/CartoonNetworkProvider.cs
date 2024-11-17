using AbstractFactory.TvChannels;
using AbstractFactory.TVShows;

namespace AbstractFactory
{
    internal class CartoonNetworkProvider : IAmazingShowProvider
    {
        public ITVChannel CreateChannel() => new CartoonNetwork();

        public ITVShow CreateShow() => new AmazingWorldOfGumball();
    }
}
