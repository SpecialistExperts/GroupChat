﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GroupChat.ClientCore.Interfaces
{
    public interface IRpcServiceProvider
    {
        Task<IUsersService> GetUserServiceAsync();
    }
}
