﻿using NUnit.Framework;
using Rhino.Mocks;

[TestFixture]
public class CharacterTests
{
	Character _c;

	[SetUp]
	public void Setup()
	{
		_c = new Character();
	}

	[Test]
	public void GetSetName()
	{
		_c.Name = "Kyle";
		Assert.AreEqual("Kyle", _c.Name);
	}

	[Test]
	public void GetSetAlignment()
	{
		_c.Alignment = Alignment.Good;
		Assert.AreEqual(Alignment.Good, _c.Alignment);
	}

	[Test]
	public void DefaultArmorClass()
	{
		Assert.AreEqual(10, _c.ArmorClass);
	}

	[Test]
	public void DefaultHitPoints()
	{
		Assert.AreEqual(5, _c.HitPoints);
	}

	[Test]
	public void Attack_RollDie()
	{
		var die = MockRepository.GenerateStub<IRollDice>();
		die.Stub(x => x.Roll()).Return(15);
		Assert.AreEqual(15, _c.Attack(die));
	}

	[Test]
	public void IsDead()
	{
		_c.HitPoints = 0;
		Assert.IsTrue(_c.IsDead());
	}

	[Test]
	public void IsNotDead()
	{
		_c.HitPoints = 1;
		Assert.IsFalse(_c.IsDead());
	}

}
