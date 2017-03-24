﻿using System.Threading.Tasks;

namespace Serilog.Sinks.Graylog.Transport
{
    /// <summary>
    /// The Transport client interface
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ITransportClient<in T>
    {
        /// <summary>
        /// Sends the specified payload.
        /// </summary>
        /// <param name="payload">The payload.</param>
        Task Send(T payload);
    }
}