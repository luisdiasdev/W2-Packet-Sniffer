using System;

namespace W2.PacketSniffer.Core
{
    public static class GeneralExtensions
    {
        /// <summary>
        /// Helper method for firing events.
        /// </summary>
        /// <typeparam name="T">The event args type.</typeparam>
        /// <param name="handler">The event handler.</param>
        /// <param name="sender">The sender object.</param>
        /// <param name="args">The event args object.</param>
        public static void Raise<T>(this EventHandler<T> handler, object sender, T args) where T : EventArgs
        {
            if (handler != null)
                handler(sender, args);
        }
    }
}
