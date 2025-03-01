using System;
using System.IO;
using System.Windows.Forms;

namespace Cosy
{
	public partial class Program
	{
		[STAThread]
		public static void Main(string[] args)
		{
			ApplicationConfiguration.Initialize();
			Application.Run(DoWork(args));
		}
		private static Form DoWork(string[] args)
		{
			if (args.Length > 0)
			{
				if (File.Exists(args[0]))
				{
					bool mode = !args[0].EndsWith(".cosy");
					string[] files = { args[0] };
					return new Security(files, mode);
				}
			}
			return new Home();
		}
	}
}