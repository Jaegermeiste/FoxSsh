﻿//   !!  // FoxSsh - https://github.com/FoxCouncil/FoxSsh
// *.-". // MIT License
//  | |  // Copyright 2021 The Fox Council

using System.Collections.Generic;

namespace FoxSsh.Common.Compression
{
    public abstract class CompressionAlgorithm
    {
        public abstract IEnumerable<byte> Compress(IEnumerable<byte> input);

        public abstract IEnumerable<byte> Decompress(IEnumerable<byte> input);
    }
}