﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.ServiceHub.Framework;
using Microsoft.VisualStudio.Shell.ServiceBroker;

namespace Microsoft.CodeAnalysis.LanguageServer.BrokeredServices.Services.HelloWorld;

[ExportBrokeredService(MonikerName, MonikerVersion, Audience = ServiceAudience.AllClientsIncludingGuests | ServiceAudience.Local)]
internal class HelloWorldService : IHelloWorld, IExportedBrokeredService
{
    internal const string MonikerName = "Microsoft.CodeAnalysis.LanguageServer.IHelloWorld";
    internal const string MonikerVersion = "0.1";

    public ServiceRpcDescriptor Descriptor => Descriptors.LocalHelloWorldService;

    public Task InitializeAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }

    public Task<string> SayHelloAsync(string name, CancellationToken cancellationToken)
    {
        return Task.FromResult($"Greetings {name}, welcome to the blue party :)");
    }

    public Task<string> CallMeAsync(ServiceMoniker serviceMoniker, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
