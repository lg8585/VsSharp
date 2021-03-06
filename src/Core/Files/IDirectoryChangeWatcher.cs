﻿// Copyright 2013 The Chromium Authors. All rights reserved.
// Use of this source code is governed by a BSD-style license that can be
// found in the LICENSE file.

using System;
using System.Collections.Generic;

namespace VsChromium.Core.Files {
  public interface IDirectoryChangeWatcher {
    void WatchDirectories(IEnumerable<FullPath> directories);

    event Action<IList<PathChangeEntry>> PathsChanged;
  }
}
