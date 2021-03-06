﻿using ByteSizeLib;
using Maxstupo.YdlUi.ArgumentBuilder;

namespace Maxstupo.YdlUi.YoutubeDL {

    public class YdlArgumentSerializer : ArgumentSerializer {

        public YdlArgumentSerializer() : base() {

            // Register translator for the ByteSize struct, outputs the total bytes.
            ValueTranslators.Add(typeof(ByteSize), (a, t, v) => {
                double bytes = ((ByteSize)v).Bytes;
                return bytes == 0 ? "0" : bytes.ToString("#.#");
            });
        }

    }
}
