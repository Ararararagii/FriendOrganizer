﻿using System.Threading.Tasks;

namespace FriendOrganizerUI.ViewModel
{
    public interface IFriendDetailViewModel
    {
        Task LoadAsync(int firendId);
    }
}