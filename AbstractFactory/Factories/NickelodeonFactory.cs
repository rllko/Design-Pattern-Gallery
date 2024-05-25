using AbstractFactory.TvChannels;
using AbstractFactory.TVShows;

namespace AbstractFactory.Factories
{
    internal class NickelodeonFactory : ITvChannelFactory
    {
        public ITVChannel CreateChannel() => new Nickelodeon();

        public ITVShow CreateShow() => new Spongebob();
    }
}
