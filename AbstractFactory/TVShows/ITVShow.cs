namespace AbstractFactory.TVShows
{
    internal interface ITVShow
    {
        public string getFavoriteShowName();
        public List<TimeSpan> ListShowScheduleDaily();

    }
}
