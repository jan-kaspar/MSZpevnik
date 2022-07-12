using MSZpevnik;

namespace CoreTest
{
	[TestFixture]
	public class SongDataTests
	{
		SongData sut;

		[SetUp]
		public void Setup()
		{
			sut = new SongData("number", "title", "file.ext");
		}

		[Test]
		public void TestGetters()
		{
			Assert.AreEqual("number", sut.GetNumber());
			Assert.AreEqual("title", sut.GetTitle());
			Assert.AreEqual("file.ext", sut.GetFileName());
		}
	}
}