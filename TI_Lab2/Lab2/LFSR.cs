using System;
using System.Linq;

namespace LabLFSR
{
    public class LFSR
    {
        private const int RegisterSize = 26;

        private readonly int[] _tapIndices = { 0, 18, 19, 25 };

        private int[] _state;

        public LFSR(string seed)
        {
            if (seed.Length != RegisterSize)
                throw new ArgumentException($"Seed must be {RegisterSize} bits long.");

            if (!seed.Any(c => c == '1'))
                throw new ArgumentException("Seed must not be all zeros.");

            _state = seed.Select(c =>
            {
                if (c != '0' && c != '1')
                    throw new ArgumentException("Seed must contain only 0 or 1.");
                return c == '1' ? 1 : 0;
            }).ToArray();
        }

        public byte NextBit()
        {
            int outputBit = _state[0];

            int feedback = 0;
            foreach (int tap in _tapIndices)
            {
                feedback ^= _state[tap];
            }

            for (int i = 0; i < RegisterSize - 1; i++)
            {
                _state[i] = _state[i + 1];
            }

            _state[RegisterSize - 1] = feedback;

            return (byte)outputBit;
        }

        public byte NextByte()
        {
            int result = 0;

            for (int i = 0; i < 8; i++)
            {
                result = (result << 1) | NextBit();
            }

            return (byte)result;
        }

    }
}