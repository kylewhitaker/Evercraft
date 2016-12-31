using NUnit.Framework;
using Rhino.Mocks;
using Evercraft;
using System;

namespace EvercraftTests
{
	[TestFixture()]
	public class CharacterTests
	{
		Character _c;

		[TestFixtureSetUp()]
		public void Setup()
		{
			_c = new Character();
		}

		[Test()]
		public void GetSetName()
		{
			_c.Name = "Kyle";
			Assert.AreEqual("Kyle", _c.Name);
		}

		[Test()]
		public void GetSetAlignment()
		{
			_c.Alignment = Alignment.Good;
			Assert.AreEqual(Alignment.Good, _c.Alignment);
		}

		[Test()]
		public void DefaultArmorClass()
		{
			Assert.AreEqual(10, _c.ArmorClass);
		}

	}
}
