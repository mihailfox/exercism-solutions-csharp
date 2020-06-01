using System;

public class MaximumNumberOfRobotsReachedException : Exception
{
    public MaximumNumberOfRobotsReachedException()
    {
    }

    public MaximumNumberOfRobotsReachedException(string message) : base(message)
    {
    }

    public MaximumNumberOfRobotsReachedException(string message, Exception innerException) : base(message, innerException)
    {
    }

    public MaximumNumberOfRobotsReachedException(string message, string lastRobotName) : this(message)
    {
    }
}