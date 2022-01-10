﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbuyGetir.Core.Events
{
    public interface IDomainEventDispatcher
    {
        void Dispatch(IDomainEvent devent);

    }
}