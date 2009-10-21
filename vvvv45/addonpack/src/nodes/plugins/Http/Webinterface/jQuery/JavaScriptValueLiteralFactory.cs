using System;
using System.Collections.Generic;
using System.Text;

namespace VVVV.Nodes.jQuery
{
	class JavaScriptValueLiteralFactory
	{
		public static JavaScriptValueLiteral<T> Create<T>(T value)
		{
			return new JavaScriptValueLiteral<T>(value);
		}
	}
}
