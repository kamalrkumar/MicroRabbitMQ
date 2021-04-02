﻿using MicfroRannit.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicfroRannit.Domain.Core.Commands
{
    public abstract class Command : Message
    {
        public DateTime Timestamp { get; protected set; }

        protected Command()
        {
            Timestamp = DateTime.Now;
        }

    }
}
