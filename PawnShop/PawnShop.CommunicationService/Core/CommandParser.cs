﻿namespace PawnShop.CommunicationService.Core
{
    using System;
    using System.Collections.Generic;
    using Commands;
    using Interfaces;


    public class CommandParser : ICommandParser
    {
        private IDictionary<string, ICommand> commands;

        public CommandParser()
        {
            this.Initilize();
        }

        public ICommand ParseCommand(string[] data)
        {
            string commandString = data[0];

            try
            {
                return this.commands[commandString].Create(data);
            }
            catch (Exception)
            {
                throw new InvalidOperationException($"Command {commandString} not valid!");
            }

        }

        public void AddCommand(string command, ICommand newCommand)
        {
            this.commands.Add(command, newCommand);
        }

        private void Initilize()
        {
            this.commands = new Dictionary<string, ICommand>();
            
            //TODO: ADD COMMANDS
        }
    }
}
