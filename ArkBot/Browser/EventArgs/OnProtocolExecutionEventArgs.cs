// Copyright © 2010-2017 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.

using CefSharp;

namespace ArkBot.Browser.EventArgs
{
    public class OnProtocolExecutionEventArgs : BaseRequestEventArgs
    {
        public OnProtocolExecutionEventArgs(IWebBrowser browserControl, IBrowser browser, string url) : base(browserControl, browser)
        {
            Url = url;

            AttemptExecution = false; // default
        }

        public string Url { get; private set; }

        /// <summary>
        ///     Set to true to attempt execution via the registered OS protocol handler, if any. Otherwise set to false.
        /// </summary>
        public bool AttemptExecution { get; set; }
    }
}
