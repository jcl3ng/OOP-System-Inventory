﻿//Author: Joshua Ng
//File Name: Buisness_Software.cs
//Project Name: Buisness Software
//Creation Date: October 1, 2019
//Description: This file is a replicated system inventory.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Software
{
    // This class extends from Exception.
    class ItemDataException : Exception
    {
        // This overloaded constructor will prompt and catch the exception.
        public ItemDataException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        // This overloaded constructor will prompt a message.
        public ItemDataException(string message)
            : base(message)
        {
        }
    }
}
