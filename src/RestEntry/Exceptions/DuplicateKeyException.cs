﻿using System;
using System.Runtime.Serialization;

namespace RestEntry.Exceptions
{
    [Serializable]
    internal class DuplicateKeyException : Exception
    {
        public DuplicateKeyException()
            : this("Duplicate key")
        {
        }

        public DuplicateKeyException(string message) : base(message)
        {
        }

        public DuplicateKeyException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DuplicateKeyException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}