﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace System.Windows.Forms;

public abstract partial class AxHost
{
    internal enum StorageType
    {
        Unknown,
        Stream,
        StreamInit,
        Storage,
        PropertyBag
    }
}
