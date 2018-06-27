using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text;
using System.Threading;
using System.Xml;
using System.Xml.Linq;

namespace ModuleEditor
{
	class Module
	{
		private XDocument data;
		private Properties meta;

		// Creates a new module using the module data
		public Module(XDocument data, Properties meta)
		{
			this.data = data;
			this.meta = meta;
		}

		public string Name
		{
			get
			{
				return data.Element("PlatformModule400").Element("name").Value;
			}
			set
			{
				data.Element("PlatformModule400").Element("name").Value = value;
				meta.Set("name", value);
			}
		}

		public string Description
		{
			get
			{
				return data.Element("PlatformModule400").Element("description").Value;
			}
			set
			{
				data.Element("PlatformModule400").Element("description").Value = value;
			}
		}
	}
}
