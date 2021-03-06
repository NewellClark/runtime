// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Xunit;

namespace System.Text.Tests
{
    public class UTF8EncodingGetEncoder
    {
        [Fact]
        public void GetEncoder()
        {
            Encoder encoder = new UTF8Encoding().GetEncoder();
            Assert.NotNull(encoder);
        }
    }
}
