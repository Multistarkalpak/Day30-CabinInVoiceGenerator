namespace CabinInVoiceTestProject
{
    public class CabinInVoiceTest
    {
        CabinInVoiceTestProject CabinInVoiceTestProject
        [SetUp]
        public void Setup()
        {
            CabinInVoiceTestProject = new cabinInVoiceTestProject(RideType.NORMAL);
        }

        [Test]
        public void GivenDistanceAndTIme()
        {
            //Assert.
            int distance = 2;
            int time = 5;
            double expected = 25;
            CabinInVoiceTestProject = new cabinInVoiceTestProject(RideType.NORMAL);

            //act
            double actual = generator.CalculateTotalFair(distance, time);

        }
    }
}