namespace AbstractFactory.TVShows
{
    internal class Spongebob : ITVShow
    {
        public string getFavoriteShowName() => "Spongebob Squarepants!";
        public List<TimeSpan> ListShowScheduleDaily() => new List<TimeSpan> { new(3, 30, 00), new(4, 30, 00) };
    }
}
