namespace TrackerDog
{
    /// <summary>
    /// Defines possible change-tracked object states
    /// </summary>
    public enum ChangeTrackableObjectState
    {
        /// <summary>
        /// Trackable object is being built
        /// </summary>
        Constructing,

        /// <summary>
        /// Trackable object is ready to track changes
        /// </summary>
        Ready
    }
}