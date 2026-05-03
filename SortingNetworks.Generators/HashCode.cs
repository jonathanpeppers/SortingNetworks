// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

// Minimal polyfill of System.HashCode for netstandard2.0.
// Based on the xxHash32 implementation from dotnet/runtime:
// https://github.com/dotnet/runtime/blob/main/src/libraries/System.Private.CoreLib/src/System/HashCode.cs
//
// Original xxHash code by Yann Collet, BSD 2-Clause License.

using System.Runtime.CompilerServices;

namespace SortingNetworks.Generators
{
    internal struct HashCode
    {
        private const uint Prime1 = 2654435761U;
        private const uint Prime2 = 2246822519U;
        private const uint Prime3 = 3266489917U;
        private const uint Prime4 = 668265263U;
        private const uint Prime5 = 374761393U;

        // Fixed seed — randomization is unnecessary for incremental generator caching.
        private const uint Seed = 0;

        private uint _v1, _v2, _v3, _v4;
        private uint _queue1, _queue2, _queue3;
        private uint _length;

        public static int Combine<T1, T2, T3, T4>(T1 value1, T2 value2, T3 value3, T4 value4)
        {
            unchecked
            {
                uint hc1 = (uint)(value1?.GetHashCode() ?? 0);
                uint hc2 = (uint)(value2?.GetHashCode() ?? 0);
                uint hc3 = (uint)(value3?.GetHashCode() ?? 0);
                uint hc4 = (uint)(value4?.GetHashCode() ?? 0);

                Initialize(out uint v1, out uint v2, out uint v3, out uint v4);

                v1 = Round(v1, hc1);
                v2 = Round(v2, hc2);
                v3 = Round(v3, hc3);
                v4 = Round(v4, hc4);

                uint hash = MixState(v1, v2, v3, v4);
                hash += 16;

                hash = MixFinal(hash);
                return (int)hash;
            }
        }

        public void Add<T>(T value)
        {
            Add(value?.GetHashCode() ?? 0);
        }

        public int ToHashCode()
        {
            unchecked
            {
                uint length = _length;
                uint position = length % 4;

                uint hash = length < 4 ? MixEmptyState() : MixState(_v1, _v2, _v3, _v4);
                hash += length * 4;

                if (position > 0)
                {
                    hash = QueueRound(hash, _queue1);
                    if (position > 1)
                    {
                        hash = QueueRound(hash, _queue2);
                        if (position > 2)
                            hash = QueueRound(hash, _queue3);
                    }
                }

                hash = MixFinal(hash);
                return (int)hash;
            }
        }

        private void Add(int value)
        {
            unchecked
            {
                uint val = (uint)value;
                uint previousLength = _length++;
                uint position = previousLength % 4;

                if (position == 0)
                    _queue1 = val;
                else if (position == 1)
                    _queue2 = val;
                else if (position == 2)
                    _queue3 = val;
                else
                {
                    if (previousLength == 3)
                        Initialize(out _v1, out _v2, out _v3, out _v4);

                    _v1 = Round(_v1, _queue1);
                    _v2 = Round(_v2, _queue2);
                    _v3 = Round(_v3, _queue3);
                    _v4 = Round(_v4, val);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void Initialize(out uint v1, out uint v2, out uint v3, out uint v4)
        {
            unchecked
            {
                v1 = Seed + Prime1 + Prime2;
                v2 = Seed + Prime2;
                v3 = Seed;
                v4 = Seed - Prime1;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static uint Round(uint hash, uint input)
        {
            unchecked { return RotateLeft(hash + input * Prime2, 13) * Prime1; }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static uint QueueRound(uint hash, uint queuedValue)
        {
            unchecked { return RotateLeft(hash + queuedValue * Prime3, 17) * Prime4; }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static uint MixState(uint v1, uint v2, uint v3, uint v4)
        {
            unchecked { return RotateLeft(v1, 1) + RotateLeft(v2, 7) + RotateLeft(v3, 12) + RotateLeft(v4, 18); }
        }

        private static uint MixEmptyState()
        {
            unchecked { return Seed + Prime5; }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static uint MixFinal(uint hash)
        {
            unchecked
            {
                hash ^= hash >> 15;
                hash *= Prime2;
                hash ^= hash >> 13;
                hash *= Prime3;
                hash ^= hash >> 16;
                return hash;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static uint RotateLeft(uint value, int offset)
        {
            return (value << offset) | (value >> (32 - offset));
        }
    }
}
