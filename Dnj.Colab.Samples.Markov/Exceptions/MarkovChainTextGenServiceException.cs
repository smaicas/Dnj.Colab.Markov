﻿using System.Runtime.Serialization;

namespace Dnj.Colab.Samples.Markov.Exceptions;
public class MarkovChainTextGenServiceException : Exception
{
    /// <summary>
    /// Prevents a default instance of the <see cref="MarkovChainTextGenServiceException"/> class from being created.
    /// </summary>
    private MarkovChainTextGenServiceException()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="MarkovChainTextGenServiceException"/> class.
    /// </summary>
    /// <param name="message">The message that describes the error.</param>
    public MarkovChainTextGenServiceException(string? message) : base(message)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="MarkovChainTextGenServiceException"/> class.
    /// </summary>
    /// <param name="message">The error message that explains the reason for the exception.</param>
    /// <param name="innerException">The exception that is the cause of the current exception, or a null reference (<see langword="Nothing" /> in Visual Basic) if no inner exception is specified.</param>
    public MarkovChainTextGenServiceException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="MarkovChainTextGenServiceException"/> class.
    /// </summary>
    /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
    /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
    /// <exception cref="SerializationException">The class name is <see langword="null" /> or <see cref="P:System.Exception.HResult" /> is zero (0).</exception>
    /// <exception cref="ArgumentNullException"><paramref name="info" /> is <see langword="null" />.</exception>
    protected MarkovChainTextGenServiceException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}
