using System;

namespace FluentFTP;

[Flags]
public enum SslProtocolsEx
{
	None,
	Ssl2 = 12,
	Ssl3 = 48,
	Tls = 192,
	Tls11 = 768,
	Tls12 = 3072, //for .NET Framework 3.5
	Tls13 = 12288, //for .NET Framework 4.6.2+
	Default = Ssl3 | Tls
}
