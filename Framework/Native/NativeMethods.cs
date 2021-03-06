﻿/*
 * Copyright (C) 2012-2013 Arctium <http://arctium.org>
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

using System;
using System.Runtime.InteropServices;

namespace Framework.Native
{
    public class NativeMethods
    {
        [DllImport("libeay32.dll")]
        internal static extern int BN_add(IntPtr r, IntPtr a, IntPtr b);

        [DllImport("libeay32.dll", EntryPoint = "BN_bin2bn")]
        internal static extern IntPtr BN_Bin2BN(byte[] ByteArrayIn, int length, IntPtr to);

        [DllImport("libeay32.dll")]
        internal static extern int BN_bn2bin(IntPtr a, byte[] to);

        [DllImport("libeay32.dll", EntryPoint = "BN_CTX_free")]
        internal static extern int BN_ctx_free(IntPtr a);

        [DllImport("libeay32.dll", EntryPoint = "BN_CTX_new")]
        internal static extern IntPtr BN_ctx_new();

        [DllImport("libeay32.dll")]
        internal static extern int BN_div(IntPtr dv, IntPtr r, IntPtr a, IntPtr b, IntPtr ctx);

        [DllImport("libeay32.dll", EntryPoint = "BN_free")]
        internal static extern void BN_Free(IntPtr r);

        [DllImport("libeay32.dll")]
        internal static extern IntPtr BN_mod_exp(IntPtr res, IntPtr a, IntPtr p, IntPtr m, IntPtr ctx);

        [DllImport("libeay32.dll")]
        internal static extern int BN_mul(IntPtr r, IntPtr a, IntPtr b, IntPtr ctx);

        [DllImport("libeay32.dll", EntryPoint = "BN_new")]
        internal static extern IntPtr BN_New();

        [DllImport("libeay32.dll")]
        public static extern int RAND_bytes(byte[] buf, int num);
    }
}
