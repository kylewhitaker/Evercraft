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
		public void GetSetName()
		{
			Character c = new Character();
			c.Name = "Kyle";
			Assert.AreEqual("Kyle", c.Name);
		}

		[Test()]
		public void GetSetAlignment()
		{
			Character c = new Character();
			c.Alignment = Alignment.Good;
			Assert.AreEqual(Alignment.Good, c.Alignment);
		}

	}
}
