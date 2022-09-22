using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabb.Score;

namespace Scrabb.Score.Test
{
	[TestClass]
	public class SScoreTests
	{
		[TestMethod]
		public void SScore_ReturnsCharacterScore_True()
		{
			SScore score = new SScore();
			Assert.AreEqual(1, score.SScoreTab("a"));
		}

    [TestMethod]
		public void SScore_ReturnsWordScore_True()
		{
			string word = "banana";
      SScore score = new SScore();
			Assert.AreEqual(8, score.SScoreTab("banana"));
		}
	}
}