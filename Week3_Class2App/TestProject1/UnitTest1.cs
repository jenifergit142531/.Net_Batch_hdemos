using Week3_Class2App;



namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckResult()
        {

            //Arrange
            var num = new Numbers();

            //Act

            int result = num.Add(10, 40);

            //Assert

            Assert.AreEqual(50, result);


        }
    }
}