﻿/*
 * Author: Rodolfo Finochietti
 * Email: rfinochi@shockbyte.net
 * Web: http://shockbyte.net
 *
 * This work is licensed under the Creative Commons Attribution License. 
 * To view a copy of this license, visit http://creativecommons.org/licenses/by/2.0
 * or send a letter to Creative Commons, 559 Nathan Abbott Way, Stanford, California 94305, USA.
 * 
 * No warranties expressed or implied, use at your own risk.
 */
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

using Pop3;

[assembly: AssemblyTitle( "Pop3.NET" )]
[assembly: AssemblyProduct( "Pop3.NET" )]
[assembly: AssemblyDescription( "Small and simple library for retrieving messages from Post Office Protocol version 3 (POP3) servers." )]

[assembly: Guid( "431ce83b-0fa5-41a5-ad9d-69ae3032462f" )]

[assembly: InternalsVisibleTo( "Pop3.Tests, PublicKey=" + Constants.PublicKey )]