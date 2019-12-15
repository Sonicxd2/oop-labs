﻿using System;
using System.Runtime.Serialization;

namespace Lab1.exception
{
    public class IllegalStateException : Exception
    {
        public IllegalStateException()
        {
        }

        protected IllegalStateException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public IllegalStateException(string message) : base(message)
        {
        }

        public IllegalStateException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}