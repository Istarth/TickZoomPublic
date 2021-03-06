﻿// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="Matthew Ward" email="mrward@users.sourceforge.net"/>
//     <version>$Revision: 5392 $</version>
// </file>

using System;
using System.Collections;
using ICSharpCode.SharpDevelop.Dom;

namespace ICSharpCode.PythonBinding
{
	public class SysModuleCompletionItems : PythonModuleCompletionItems
	{
		public SysModuleCompletionItems(PythonStandardModuleType moduleType)
			: base(moduleType)
		{
			AddCompletionItems();
		}
		
		void AddCompletionItems()
		{
			AddField("__stderr__");
			AddField("__stdin__");
			AddField("__stdout__");
			AddField("argv");
			AddField("builtin_module_names");
			AddField("dont_write_byte_code");
			AddField("executable");
			AddField("exec_prefix");
			AddField("flags");
			AddField("hexversion");
			AddField("last_type");
			AddField("last_value");
			AddField("last_traceback");
			AddField("meta_path");
			AddField("modules");
			AddField("path");
			AddField("path_hooks");
			AddField("path_importer_cache");
			AddField("ps1");
			AddField("ps2");
			AddField("py3kwarning");
			AddField("stderr");
			AddField("stdin");
			AddField("stdout");
			AddField("version");
			AddField("version_info");
			AddField("warnoptions");
		}
	}
}
