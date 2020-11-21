using System;
using System.Runtime.Serialization;

namespace Entidades
{
    [Serializable]
    public  class ErrorStatsException : Exception
    {
        public ErrorStatsException() : base("Error de stats.")
        {
        }

        public ErrorStatsException(Exception innerException) : base("Error de Stats", innerException)
        {
        }

    }
}