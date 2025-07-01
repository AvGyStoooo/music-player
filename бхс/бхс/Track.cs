using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace бхс
{
	internal class Track
	{
		public string Name { get; set; }
		public string Path { get; set; }
		public Track(string name, string path)
		{
			Name = name;
			Path = path;
		}
		public string GetInfo()
		{
			return Name+"|"+Path;
		}
	}
}
