using AbstractFactory.TvChannels;
using AbstractFactory.TVShows;

namespace AbstractFactory.Factories
{
    internal interface ITvChannelFactory
    {
        ITVChannel CreateChannel();
        ITVShow CreateShow();
    }
}
