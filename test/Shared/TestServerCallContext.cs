﻿#region Copyright notice and license

// Copyright 2019 The gRPC Authors
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

#endregion

using Grpc.Core;

namespace Grpc.Tests.Shared
{
    public class TestServerCallContext : ServerCallContext
    {
        public TestServerCallContext(DateTime deadline, CancellationToken cancellationToken)
        {
            DeadlineCore = deadline;
            CancellationTokenCore = cancellationToken;
        }

        protected override string? MethodCore { get; }
        protected override string? HostCore { get; }
        protected override string? PeerCore { get; }
        protected override DateTime DeadlineCore { get; }
        protected override Metadata? RequestHeadersCore { get; }
        protected override CancellationToken CancellationTokenCore { get; }
        protected override Metadata? ResponseTrailersCore { get; }
        protected override Status StatusCore { get; set; }
        protected override WriteOptions? WriteOptionsCore { get; set; }
        protected override AuthContext? AuthContextCore { get; }

        protected override ContextPropagationToken CreatePropagationTokenCore(ContextPropagationOptions options)
        {
            throw new NotImplementedException();
        }

        protected override Task WriteResponseHeadersAsyncCore(Metadata responseHeaders)
        {
            throw new NotImplementedException();
        }
    }
}
