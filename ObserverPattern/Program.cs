using ObserverPattern.Observer;
using ObserverPattern.Subject;

var youtubeChannel = new YoutubeChannelSubject();

IObserver subscriber = new SubscriberObserver(){Name = "john" };
IObserver subscriber1 = new SubscriberObserver(){Name = "mary" };

youtubeChannel.RegisterObserver(subscriber);
youtubeChannel.RegisterObserver(subscriber1);

youtubeChannel.NotifyObservers();
