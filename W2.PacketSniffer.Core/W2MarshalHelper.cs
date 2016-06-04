using System;
using System.Runtime.InteropServices;

namespace W2.PacketSniffer.Core
{
    public static class W2MarshalHelper
    {
        /// <summary>
        /// Copies a given number of bytes from the source buffer at the specified offset to the
        /// destination buffer at the specified offset.
        /// </summary>
        /// <param name="source">The source buffer.</param>
        /// <param name="sourceOffset">The source offset.</param>
        /// <param name="dest">The dest buffer.</param>
        /// <param name="destOffset">The dest offset.</param>
        /// <param name="count">The number of bytes to copy.</param>
        public unsafe static void BufferCopy(byte[] source, int sourceOffset, byte[] dest, int destOffset, int count)
        {
            fixed (byte* pSrc = source, pDst = dest)
            {
                byte* currentSrc = pSrc + sourceOffset;
                byte* currentDst = pDst + destOffset;

                for (int i = 0; i < count; i++)
                {
                    *currentDst = *currentSrc;
                    currentSrc++;
                    currentDst++;
                }
            }
        }
    }
}
