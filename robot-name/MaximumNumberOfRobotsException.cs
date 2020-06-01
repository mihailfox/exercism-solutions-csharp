using System;

public class MaximumNumberOfRobotsException : Exception
{
    public MaximumNumberOfRobotsException()
    {
    }

    public MaximumNumberOfRobotsException(string message) : base(message)
    {
    }

    public MaximumNumberOfRobotsException(string message, Exception innerException) : base(message, innerException)
    {
    }

    public MaximumNumberOfRobotsException(string message, string lastRobotName) : this(message)
    {
    }
}