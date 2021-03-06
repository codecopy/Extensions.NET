﻿/**********************************************************************************************************************
 * Extensions.NET (https://github.com/mkloubert/Extensions.NET)                                                       *
 *                                                                                                                    *
 * Copyright (c) 2015, Marcel Joachim Kloubert <marcel.kloubert@gmx.net>                                              *
 * All rights reserved.                                                                                               *
 *                                                                                                                    *
 * Redistribution and use in source and binary forms, with or without modification, are permitted provided that the   *
 * following conditions are met:                                                                                      *
 *                                                                                                                    *
 * 1. Redistributions of source code must retain the above copyright notice, this list of conditions and the          *
 *    following disclaimer.                                                                                           *
 *                                                                                                                    *
 * 2. Redistributions in binary form must reproduce the above copyright notice, this list of conditions and the       *
 *    following disclaimer in the documentation and/or other materials provided with the distribution.                *
 *                                                                                                                    *
 * 3. Neither the name of the copyright holder nor the names of its contributors may be used to endorse or promote    *
 *    products derived from this software without specific prior written permission.                                  *
 *                                                                                                                    *
 *                                                                                                                    *
 * THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, *
 * INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE  *
 * DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, *
 * SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR    *
 * SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY,  *
 * WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE   *
 * USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.                                           *
 *                                                                                                                    *
 **********************************************************************************************************************/

using System;

namespace MarcelJoachimKloubert.Extensions
{
    // ChangeType()
    static partial class MJKCoreExtensionMethods
    {
        #region Methods (3)

        /// <summary>
        /// Converts an object.
        /// </summary>
        /// <typeparam name="TTarget">The target type.</typeparam>
        /// <param name="obj">The object to convert.</param>
        /// <param name="provider">The custom format provider to use.</param>
        /// <returns>The converted object.</returns>
        public static TTarget ChangeType<TTarget>(this object obj, IFormatProvider provider = null)
        {
            return (TTarget)ChangeType(obj: obj,
                                       targetType: typeof(TTarget),
                                       provider: provider);
        }

        /// <summary>
        /// Converts an object.
        /// </summary>
        /// <param name="obj">The object to convert.</param>
        /// <param name="typeCode">The code of the target type.</param>
        /// <param name="provider">The custom format provider to use.</param>
        /// <returns>The converted object.</returns>
        public static object ChangeType(this object obj, TypeCode typeCode, IFormatProvider provider = null)
        {
            if (provider == null)
            {
                return Convert.ChangeType(obj, typeCode);
            }

            return Convert.ChangeType(obj, typeCode, provider);
        }

        /// <summary>
        /// Converts an object.
        /// </summary>
        /// <param name="obj">The object to convert.</param>
        /// <param name="targetType">The target type.</param>
        /// <param name="provider">The custom format provider to use.</param>
        /// <returns>The converted object.</returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="targetType" /> is <see langword="null" />.
        /// </exception>
        public static object ChangeType(this object obj, Type targetType, IFormatProvider provider = null)
        {
            if (provider == null)
            {
                return Convert.ChangeType(obj, targetType);
            }

            return Convert.ChangeType(obj, targetType, provider);
        }

        #endregion Methods (3)
    }
}