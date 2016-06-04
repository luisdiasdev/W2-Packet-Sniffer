using System;
using System.Runtime.InteropServices;

namespace W2.PacketSniffer.Core
{
    public static class W2MarshalHelper
    {
        public unsafe static T GetStructure<T>(byte[] buffer, int start)
        {
            fixed(byte* pBuffer = &buffer[start])
                return Marshal.PtrToStructure<T>(new IntPtr(pBuffer));
        }

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
