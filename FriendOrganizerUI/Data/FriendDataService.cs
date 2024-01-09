using FriendOrganizer.Model;
using System.Collections.Generic;

namespace FriendOrganizerUI.Data
{
    public class FriendDataService : IFriendDataService
    {
        public IEnumerable<Friend> GetAll()
        {
            //TODO: Load real data from real database
            yield return new Friend { FirstName = "Kamil", LastName = "G" };
            yield return new Friend { FirstName = "Michał", LastName = "Różycki" };
            yield return new Friend { FirstName = "Tomek", LastName = "Chodak" };
            yield return new Friend { FirstName = "Marek", LastName = "Bernatowicz" };
        }
    }
}
