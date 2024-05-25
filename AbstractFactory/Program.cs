//The abstract factory pattern is a design pattern that provides a way to create families of related objects without imposing their concrete classes,
// by encapsulating a group of individual factories that have a common theme without specifying their concrete classes.

// this example is rather silly but i had fun doing it

using AbstractFactory;
using AbstractFactory.TvChannels;
using AbstractFactory.TVShows;

//ITvChannelFactory NickelodeonFactory = new NickelodeonFactory();
//ITVChannel Channel = NickelodeonFactory.CreateChannel();
//ITVShow FavoriteShow = NickelodeonFactory.CreateShow();
Channel Channel = Channel.CartoonNetwork;

ITVChannel FavoriteChannel = AmazingShowProvider.CreateChannel(Channel);
ITVShow FavoriteShow = AmazingShowProvider.CreateShow(Channel);

Console.WriteLine($"My favorite show on {FavoriteChannel.getChannelName()} is {FavoriteShow.getFavoriteShowName()} that plays at");

FavoriteShow.ListShowScheduleDaily()
    .Select(item => item.ToString())
    .ToList()
    .ForEach(Console.WriteLine);