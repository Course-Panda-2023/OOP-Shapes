namespace Shapes
{
    /// <summary>
    /// interface of shape
    /// </summary>
    internal interface Shape
    {
        /// <summary>
        /// draw using # a certain shape
        /// </summary>
        void Draw();

        /// <summary>
        /// set the property is filled
        /// </summary>
        /// <param name="isFilled">is a filled shape</param>
        void SetIsFilled(bool isFilled);

        /// <summary>
        /// gets the attribute of whether or not is true or false
        /// </summary>
        /// <returns>is filled</returns>
        bool GetIsFilled();
    }
}
