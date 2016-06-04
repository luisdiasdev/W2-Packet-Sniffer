namespace W2.PacketSniffer.Security
{
    /// <summary>
    /// Represents a packet encoding.
    /// Can decrypt
    /// </summary>
    public interface IPacketEncoding
    {
        /// <summary>
        /// Minimum version supported by this encoding (inclusive).
        /// </summary>
        int MinimumVersion { get; }

        /// <summary>
        /// Maxmimum version supported by this encoding (exclusive).
        /// </summary>
        int MaximumVersion { get; }

        /// <summary>
        /// The encoding keys used to decrypt/decode a packet.
        /// </summary>
        byte[] Keys { get; }

        /// <summary>
        /// Decrypts/Decode a packet.
        /// </summary>
        /// <param name="buffer">The pointer to the start of the packet.</param>
        /// <param name="length">The packet length, in bytes.</param>
        /// <param name="offset">The starting offset, if the pointer is not pointing to it.</param>
        /// <returns>Returns true if the decryption was successful, false otherwise.</returns>
        bool Decrypt(byte[] buffer, int offset, int length);
    }
}
