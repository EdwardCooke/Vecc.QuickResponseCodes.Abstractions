namespace Vecc.QuickResponseCodes.Abstractions
{
    /// <summary>
    /// Error tolerances
    /// </summary>
    public enum ErrorTolleranceLevel
    {
        /// <summary>
        /// Allows 7% data loss.
        /// </summary>
        VeryLow,

        /// <summary>
        /// Allows 15% data loss.
        /// </summary>
        Low,

        /// <summary>
        /// Allows 25% data loss.
        /// </summary>
        Medium,

        /// <summary>
        /// Allows 30% data loss.
        /// </summary>
        High
    }
}
