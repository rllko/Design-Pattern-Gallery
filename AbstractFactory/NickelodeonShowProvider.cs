using AbstractFactory.TvChannels;
using AbstractFactory.TVShows;

namespace AbstractFactory
{
    internal class NickelodeonShowProvider : IAmazingShowProvider
    {
        public ITVChannel CreateChannel()
        {
            return new Nickelodeon();
        }


        public ITVShow CreateShow()
        {
            return new Spongebob();
        }
    }
}
