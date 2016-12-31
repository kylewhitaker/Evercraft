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

		[Test()]
		public void DefaultHitPoints()
		{
			Assert.AreEqual(5, _c.HitPoints);
		}

		[Test()]
		public void Attack_RollDie()
		{
			int n = 15;
			var die = MockRepository.GenerateStub<IRollDice>();
			die.Stub(x => x.Roll()).Return(n);
			Assert.AreEqual(n, _c.Attack(die));
		}

	}
}
