using NUnit.Framework;
using Rhino.Mocks;
using Evercraft;
using System;

namespace EvercraftTests
{
	[TestFixture()]
	public class CharacterTests
	{
		[Test()]
		public void Name()
		{
			Character c = new Character();
			c.Name = "Kyle";
			Assert.AreEqual("Kyle", c.Name);
		}
	}
}
