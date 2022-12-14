// Copyright © 2010-2017 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.

using CefSharp;

namespace ArkBot.Browser.EventArgs
{
    public class OnOpenUrlFromTabEventArgs : BaseRequestEventArgs
    {
        public OnOpenUrlFromTabEventArgs(IWebBrowser browserControl, IBrowser browser, IFrame frame, string targetUrl, WindowOpenDisposition targetDisposition, bool userGesture)
            : base(browserControl, browser)
        {
            Frame = frame;
            TargetUrl = targetUrl;
            TargetDisposition = targetDisposition;
            UserGesture = userGesture;

            CancelNavigation = false; // default
        }

        public IFrame Frame { get; private set; }
        public string TargetUrl { get; private set; }
        public WindowOpenDisposition TargetDisposition { get; private set; }
        public bool UserGesture { get; private set; }

        /// <summary>
        ///     Set to true to cancel the navigation or false to allow the navigation to proceed.
        /// </summary>
        public bool CancelNavigation { get; set; }
    }
}
