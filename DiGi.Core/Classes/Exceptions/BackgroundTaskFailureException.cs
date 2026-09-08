using System;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// Represents the deliberate failure of a background task: a refusal the task decided on itself, such as a
    /// duplicate email or a cancelled dialog, rather than an unexpected exception thrown while it was running.
    /// <para>It exists so a consumer of <see cref="Interfaces.IBackgroundTask.Exception"/> can tell a designed
    /// refusal from a crash by type: the message alone would leave a reader guessing whether the run broke or
    /// declined. A task throwing it is refusing; anything else in <c>Exception</c> is a fault.</para>
    /// <para><see cref="BackgroundTask"/> also assigns it as a fallback when a task reports failure by returning
    /// false without an exception and without being cancelled, so such a run still carries a message the task
    /// row can show on hover and the clipboard can copy.</para>
    /// </summary>
    public class BackgroundTaskFailureException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BackgroundTaskFailureException"/> class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes why the task refused to do what it was asked for.</param>
        public BackgroundTaskFailureException(string? message) : base(message)
        {
        }
    }
}
