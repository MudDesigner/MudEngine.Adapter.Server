﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MudDesigner.MudEngine.Actors;
using MudDesigner.MudEngine.Commanding;

namespace MudDesigner.MudEngine.Networking
{
    public class LoginCommand : IActorCommand
    {
        public Task<bool> CanProcessCommand(IPlayer source, string command, params string[] arguments)
        {
            throw new NotImplementedException();
        }

        public Task<CommandResult> ProcessCommand(IPlayer source, string command, params string[] arguments)
        {
            throw new NotImplementedException();
        }
    }
}
