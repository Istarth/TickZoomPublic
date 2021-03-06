// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="Daniel Grunwald" email="daniel@danielgrunwald.de"/>
//     <version>$Revision: 3863 $</version>
// </file>

using System;
using System.IO;
using ICSharpCode.SharpDevelop.Internal.Templates;
using ICSharpCode.SharpDevelop.Project;
using ICSharpCode.SharpDevelop.Dom;

namespace ICSharpCode.ILAsmBinding
{
	public class ILAsmProject : CompilableProject
	{
		public ILAsmProject(IMSBuildEngineProvider provider, string fileName, string projectName)
			: base(provider)
		{
			this.Name = projectName;
			LoadProject(fileName);
		}
		
		public ILAsmProject(ProjectCreateInformation info)
			: base(info.Solution)
		{
			Create(info);
			this.AddImport(@"$(SharpDevelopBinPath)\SharpDevelop.Build.MSIL.Targets", null);
		}
		
		public override string Language {
			get { return ILAsmLanguageBinding.LanguageName; }
		}
		
		public override LanguageProperties LanguageProperties {
			get { return LanguageProperties.None; }
		}
		
		public override ItemType GetDefaultItemType(string fileName)
		{
			if (string.Equals(".il", Path.GetExtension(fileName), StringComparison.OrdinalIgnoreCase))
				return ItemType.Compile;
			else
				return base.GetDefaultItemType(fileName);
		}
	}
}
