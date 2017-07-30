namespace Vecc.QuickResponseCodes.Abstractions
{
    /// <summary>
    ///     Error tolerances
    /// </summary>
    public enum ErrorToleranceLevel
    {
        /// <summary>
        ///     Allows 7% data loss. (L)
        /// </summary>
        VeryLow,

        /// <summary>
        ///     Allows 15% data loss. (M)
        /// </summary>
        Low,

        /// <summary>
        ///     Allows 25% data loss. (Q)
        /// </summary>
        Medium,

        /// <summary>
        ///     Allows 30% data loss. (H)
        /// </summary>
        High
    }
}
