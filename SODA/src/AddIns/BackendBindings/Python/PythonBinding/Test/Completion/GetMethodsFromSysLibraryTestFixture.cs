﻿// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="Matthew Ward" email="mrward@users.sourceforge.net"/>
//     <version>$Revision: 5392 $</version>
// </file>

using System;
using System.Collections.Generic;
using ICSharpCode.PythonBinding;
using ICSharpCode.SharpDevelop.Dom;
using IronPython.Modules;
using NUnit.Framework;
using PythonBinding.Tests.Utils;

namespace PythonBinding.Tests.Completion
{
	[TestFixture]
	public class GetMethodsFromSysLibraryTestFixture
	{
		SysModuleCompletionItems completionItems;
		MethodGroup exitMethodGroup;
		MethodGroup displayHookMethodGroup;
		
		[SetUp]
		public void Init()
		{
			PythonStandardModuleType moduleType = new PythonStandardModuleType(typeof(SysModule), "sys");
			completionItems = new SysModuleCompletionItems(moduleType);
			exitMethodGroup = completionItems.GetMethods("exit");
			displayHookMethodGroup = completionItems.GetMethods("displayhook");
		}
		
		[Test]
		public void TwoExitMethodsReturnedFromGetMethods()
		{
			Assert.AreEqual(2, exitMethodGroup.Count);
		}
		
		[Test]
		public void FirstMethodNameIsExit()
		{
			Assert.AreEqual("exit", exitMethodGroup[0].Name);
		}
		
		[Test]
		public void SecondMethodNameIsExit()
		{
			Assert.AreEqual("exit", exitMethodGroup[1].Name);
		}
		
		[Test]
		public void FirstMethodHasReturnType()
		{
			Assert.IsNotNull(exitMethodGroup[0].ReturnType);
		}
		
		[Test]
		public void SecondMethodHasReturnType()
		{
			Assert.IsNotNull(exitMethodGroup[1].ReturnType);
		}
		
		[Test]
		public void ExitMethodReturnsVoid()
		{
			IMethod method = displayHookMethodGroup[0];
			Assert.AreEqual("Void", method.ReturnType.Name);
		}
		
		[Test]
		public void DisplayHookMethodDoesNotHaveCodeContextParameter()
		{
			IMethod method = displayHookMethodGroup[0];
			IParameter parameter = method.Parameters[0];
			Assert.AreEqual("value", parameter.Name);
		}
		
		[Test]
		public void DisplayHookMethodReturnsVoid()
		{
			IMethod method = displayHookMethodGroup[0];
			Assert.AreEqual("Void", method.ReturnType.Name);
		}
		
		[Test]
		public void GetDefaultEncodingMethodReturnsString()
		{
			MethodGroup methodGroup = completionItems.GetMethods("getdefaultencoding");
			IMethod method = methodGroup[0];
			Assert.AreEqual("String", method.ReturnType.Name);
		}
	}
}
