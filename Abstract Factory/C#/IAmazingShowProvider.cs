using AbstractFactory.TvChannels;
using AbstractFactory.TVShows;

namespace AbstractFactory
{
    internal interface IAmazingShowProvider
    {
        ITVChannel CreateChannel();
        ITVShow CreateShow();
    }
}