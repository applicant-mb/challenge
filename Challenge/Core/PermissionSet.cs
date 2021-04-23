using System;
using System.Collections.Generic;
using System.Linq;

namespace Challenge.Core
{
    public enum PermissionSet : byte
    {
        Perm1,
        Perm2,
        Perm3,
        Perm4,
        Perm5,
        Perm6,
        Perm7,
        Perm8,
        // ...
    }
    
    // placed here for simplicity
    public static class ByteEnumEx
    {
        public static IEnumerable<byte> Bytes<T>() where T: Enum
        {
            return Enum.GetValues(typeof(T)).Cast<byte>();
        }
    }
}
