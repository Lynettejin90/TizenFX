/*
 * Copyright (c) 2016 Samsung Electronics Co., Ltd All Rights Reserved
 *
 * Licensed under the Apache License, Version 2.0 (the License);
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an AS IS BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;

namespace ElmSharp
{
    /// <summary>
    /// Iterm class of FlipSelector
    /// </summary>
    public class FlipSelectorItem : ItemObject
    {
        /// <summary>
        /// Sets or gets the Text of FlipSelectorItem
        /// </summary>
        public string Text { get; private set; }

        /// <summary>
        /// Selected will be triggered when Selected
        /// </summary>
        public event EventHandler Selected;

        /// <summary>
        /// Creates and initializes a new instance of the FlipSelectorItem.
        /// </summary>
        /// <param name="text">FlipSelectorItem's text</param>
        public FlipSelectorItem(string text) : base(IntPtr.Zero)
        {
            Text = text;
        }

        internal void SendSelected()
        {
            Selected?.Invoke(this, EventArgs.Empty);
        }
    }
}