/*
 * MIT License
 * 
 * Copyright (c) 2021 EoflaOE and its companies
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */

using System;

namespace ShoutStats.Core
{
    /// <summary>
    /// Happens when the error in the server has occurred
    /// </summary>
    public class ShoutcastServerException : Exception
    {
        /// <summary>
        /// Throws the server exception
        /// </summary>
        public ShoutcastServerException() { }
        /// <summary>
        /// Throws the server exception
        /// </summary>
        public ShoutcastServerException(string message) : base(message) { }
        /// <summary>
        /// Throws the server exception
        /// </summary>
        public ShoutcastServerException(string message, Exception inner) : base(message, inner) { }
        /// <summary>
        /// Throws the server exception
        /// </summary>
        protected ShoutcastServerException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
