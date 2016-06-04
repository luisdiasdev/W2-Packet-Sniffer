using System;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace W2.PacketSniffer.Core
{
    public static class SocketExtensions
    {
        public static Task<int> ReceiveTaskAsync(
            this Socket socket, byte[] buffer, int offset, int size,
            SocketFlags flags)
        {
            var tcs = new TaskCompletionSource<int>(socket);
            socket.BeginReceive(buffer, offset, size, flags, iar =>
            {
                var t = (TaskCompletionSource<int>)iar.AsyncState;
                var s = (Socket)t.Task.AsyncState;
                try { t.TrySetResult(s.EndReceive(iar)); }
                catch (Exception ex) { t.TrySetException(ex); }
            }, tcs);
            return tcs.Task;
        }
    }
}
