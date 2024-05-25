namespace AbstractFactory.TVShows
{
    internal class AmazingWorldOfGumball : ITVShow
    {
        public string getFavoriteShowName() => "The Amazing world of gumbal!";

        public List<TimeSpan> ListShowScheduleDaily() => new List<TimeSpan> { new(3, 45, 00), new(4, 00, 00), new(4, 15, 00), new(4, 30, 00), new(4, 45, 00) };

    }
}
