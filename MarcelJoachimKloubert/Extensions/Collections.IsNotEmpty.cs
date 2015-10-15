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

using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MarcelJoachimKloubert.Extensions
{
    // IsEmpty()
    static partial class MJKCoreExtensionMethods
    {
        #region Methods (2)

        /// <summary>
        /// Checks if a sequence is empty.
        /// </summary>
        /// <typeparam name="T">Type of the items.</typeparam>
        /// <param name="seq">The sequence to check.</param>
        /// <returns>
        /// Is NOT empty; otherwise <see langword="false" />. <see langword="null"/> indicates that <paramref name="seq"/>
        /// is <see langword="null" />.
        /// </returns>
        public static bool? IsNotEmpty<T>(this IEnumerable<T> seq)
        {
            if (seq == null)
            {
                return null;
            }

            var coll1 = seq as ICollection<T>;
            if (coll1 != null)
            {
                return coll1.Count > 0;
            }

            var coll2 = seq as ICollection;
            if (coll2 != null)
            {
                return coll2.Count > 0;
            }

            return seq.LongCount() > 0;
        }

        /// <summary>
        /// Checks if a sequence is NOT empty.
        /// </summary>
        /// <param name="seq">The sequence to check.</param>
        /// <returns>
        /// Is NOT empty; otherwise <see langword="false" />. <see langword="null"/> indicates that <paramref name="seq"/>
        /// is <see langword="null" />.
        /// </returns>
        public static bool? IsNotEmpty<T>(this IEnumerable seq)
        {
            if (seq == null)
            {
                return null;
            }

            return IsNotEmpty<object>(seq.Cast<object>());
        }

        #endregion Methods (2)
    }
}