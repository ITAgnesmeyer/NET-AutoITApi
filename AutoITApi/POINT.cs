using System.Runtime.InteropServices;
// ReSharper disable MemberCanBePrivate.Global

namespace AutoITApi
{
    /// <inheritdoc />
    [StructLayout(LayoutKind.Sequential)]
    public struct Point
    {
        /// LONG->int
        public int x;

        /// LONG->int
        public int y;
    }
}