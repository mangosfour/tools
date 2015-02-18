/*
 * Copyright (C) 2015  MaNGOS project <http://getmangos.eu>
 * Copyright (C) 2012-2013 Arctium Emulation <http://arctium.org>
 *
 * This program is free software; you can redistribute it and/or modify it
 * under the terms of the GNU General Public License as published by the
 * Free Software Foundation; either version 2 of the License, or (at your
 * option) any later version.
 *
 * This program is distributed in the hope that it will be useful, but WITHOUT
 * ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or
 * FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License for
 * more details.
 *
 * You should have received a copy of the GNU General Public License along
 * with this program. If not, see <http://www.gnu.org/licenses/>.
 */

namespace MaNGOSPatcher.Constants
{
    enum BinaryTypes : uint
    {
        None   = 0000000000,
        Pe32   = 0x0000014C,
        Pe64   = 0x00008664,
        Mach32 = 0xFEEDFACE,
        Mach64 = 0xFEEDFACF
    }
}
