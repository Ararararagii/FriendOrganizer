﻿using FriendOrganizer.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FriendOrganizerUI.Data
{
    public interface IFriendDataService
    {
        Task<Friend> GetByIdAsync(int friendID);
        Task SaveAsync(Friend friend);
    }
}