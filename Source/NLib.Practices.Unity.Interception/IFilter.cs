namespace NLib.Practices.Unity.Interception
{
    using Microsoft.Practices.Unity.InterceptionExtension;

    /// <summary>
    /// Defines the methods that are used in an interception filter.
    /// </summary>
    public interface IFilter
    {
        /// <summary>
        /// Called when the execution is canceled.
        /// </summary>
        /// <param name="context">The cancel context.</param>
        /// <returns>Null to continue or an instance that implement <see cref="IMethodReturn"/>.</returns>
        IMethodReturn OnCancel(FilterCancelContext context);

        /// <summary>
        /// Called when an error occurred during the execution.
        /// </summary>
        /// <param name="context">The error context.</param>
        /// <returns>Null to continue or an instance that implement <see cref="IMethodReturn"/>.</returns>
        IMethodReturn OnError(FilterErrorContext context);

        /// <summary>
        /// Called after the execution.
        /// </summary>
        /// <param name="context">The executed context.</param>
        /// <returns>Null to continue or an instance that implement <see cref="IMethodReturn"/>.</returns>
        IMethodReturn OnExecuted(FilterExecutedContext context);

        /// <summary>
        /// Called before the execution.
        /// </summary>
        /// <param name="context">The executing context.</param>
        /// <returns>Null to continue or an instance that implement <see cref="IMethodReturn"/>.</returns>
        IMethodReturn OnExecuting(FilterExecutingContext context);
    }
}