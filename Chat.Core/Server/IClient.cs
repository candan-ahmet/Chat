﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Core.Server
{
    public interface IClient
    {
        long ClientId { get; }
        string Nick { get; }
        bool HasConnection { get; }
        bool SendMessage(string mesaj);
        void CloseConnection();
    }
}