﻿using RepositoryPattern.Model;
using System.Collections.Generic;

namespace RepositoryPattern
{
    internal interface IPeopleRepository : IRepository<Person>
    {
        Person? GetYoungestPerson();
        IEnumerable<Person> GetTopYoungest(int limit);
    }
}
