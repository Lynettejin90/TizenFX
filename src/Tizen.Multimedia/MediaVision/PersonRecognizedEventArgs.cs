﻿/*
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
using System.Collections.Generic;

namespace Tizen.Multimedia
{
    /// <summary>
    /// This class is an event arguments of the PersonRecognized event.
    /// </summary>
    public class PersonRecognizedEventArgs : EventArgs
    {
        internal PersonRecognizedEventArgs()
        {
        }

        /// <summary>
        /// The identifier of the video source where event has been detected
        /// </summary>
        public int VideoStreamId { get; internal set; }

        /// <summary>
        /// Gets a set of information that correspond to the recognized persons
        /// </summary>
        public List<PersonRecognitionResult> Result { get; internal set; }
    }
}
