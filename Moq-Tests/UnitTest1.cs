using Moq;

namespace Moq_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var mockMinhaInterface = new Mock<IGerarHorario>();
            mockMinhaInterface.Setup(m => m.ReturnVolta()).Returns(false);
            var minhaClasse = new GerarHorario(mockMinhaInterface.Object);

            // Act
            bool resultado = minhaClasse.ReturnVolta();

            // Assert
            Assert.IsFalse(resultado);


        }
    }
}