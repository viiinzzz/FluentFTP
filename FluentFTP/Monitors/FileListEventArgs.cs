using System;
using System.Collections.Generic;

namespace FluentFTP.Monitors;

public class FileListEventArgs : EventArgs
{
	public List<string> items { get; set; }
}
