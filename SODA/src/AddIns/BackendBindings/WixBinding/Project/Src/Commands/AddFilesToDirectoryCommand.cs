// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="Matthew Ward" email="mrward@users.sourceforge.net"/>
//     <version>$Revision: 3218 $</version>
// </file>

using System;
using ICSharpCode.Core;

namespace ICSharpCode.WixBinding
{
	public class AddFilesToDirectoryCommand : AbstractMenuCommand
	{
		public override void Run()
		{
			PackageFilesView.ActiveView.AddFiles();
		}
	}
}

