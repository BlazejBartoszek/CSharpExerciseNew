using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpExercise.Tests
{
    [TestClass]
    public class InputDataListTests
    {
        [TestMethod]
        public void CompareTo_ForLowerId_Return10()
        {
            // arange
            InputDataList inputDataList = new InputDataList();
            inputDataList.Id = 10.1f;
            inputDataList.Name = "Adam";
            inputDataList.Surname = "Kowalski";
            inputDataList.Company = "IBM";
            inputDataList.Position = "Junior Developer";

            InputDataList inputDataList2 = new InputDataList();
            inputDataList2.Id = 8.1f;
            inputDataList2.Name = "Adam";
            inputDataList2.Surname = "Kowalski";
            inputDataList2.Company = "IBM";
            inputDataList2.Position = "Junior Developer";

            // act            
            int compareToResult2 = inputDataList.CompareTo(inputDataList2);

            //assert
            Assert.AreEqual(10, compareToResult2);
        }

        [TestMethod]
        public void CompareTo_ForHigherId_ReturnMinus10()
        {
            // arange
            InputDataList inputDataList = new InputDataList();
            inputDataList.Id = 10.1f;
            inputDataList.Name = "Adam";
            inputDataList.Surname = "Kowalski";
            inputDataList.Company = "IBM";
            inputDataList.Position = "Junior Developer";

            InputDataList inputDataList2 = new InputDataList();
            inputDataList2.Id = 18.1f;
            inputDataList2.Name = "Adam";
            inputDataList2.Surname = "Kowalski";
            inputDataList2.Company = "IBM";
            inputDataList2.Position = "Junior Developer";

            // act            
            int compareToResult2 = inputDataList.CompareTo(inputDataList2);

            //assert
            Assert.AreEqual(-10, compareToResult2);
        }

        [TestMethod]
        public void CompareTo_ForEqualId_Return0()
        {
            // arange
            InputDataList inputDataList = new InputDataList();
            inputDataList.Id = 10.1f;
            inputDataList.Name = "Adam";
            inputDataList.Surname = "Kowalski";
            inputDataList.Company = "IBM";
            inputDataList.Position = "Junior Developer";

            InputDataList inputDataList2 = new InputDataList();
            inputDataList2.Id = 10.1f;
            inputDataList2.Name = "Adam";
            inputDataList2.Surname = "Kowalski";
            inputDataList2.Company = "IBM";
            inputDataList2.Position = "Junior Developer";

            // act            
            int compareToResult2 = inputDataList.CompareTo(inputDataList2);

            //assert
            Assert.AreEqual(0, compareToResult2);
        }

        [TestMethod]
        public void CompareTo_ForLowerLetterOfTheAlphabet_Return1()
        {
            // arange
            InputDataList inputDataList = new InputDataList();
            inputDataList.Id = 10.1f;
            inputDataList.Name = "Kris";
            inputDataList.Surname = "Kowalski";
            inputDataList.Company = "IBM";
            inputDataList.Position = "Junior Developer";

            InputDataList inputDataList2 = new InputDataList();
            inputDataList2.Id = 10.1f;
            inputDataList2.Name = "Adam";
            inputDataList2.Surname = "Kowalski";
            inputDataList2.Company = "IBM";
            inputDataList2.Position = "Junior Developer";

            // act            
            int compareToResult2 = inputDataList.CompareTo(inputDataList2);

            //assert
            Assert.AreEqual(1, compareToResult2);
        }

        [TestMethod]
        public void CompareTo_ForHigherLetterOfTheAlphabet_ReturnMinus1()
        {
            // arange
            InputDataList inputDataList = new InputDataList();
            inputDataList.Id = 10.1f;
            inputDataList.Name = "Adam";
            inputDataList.Surname = "Kowalski";
            inputDataList.Company = "IBM";
            inputDataList.Position = "Junior Developer";

            InputDataList inputDataList2 = new InputDataList();
            inputDataList2.Id = 10.1f;
            inputDataList2.Name = "Kris";
            inputDataList2.Surname = "Kowalski";
            inputDataList2.Company = "IBM";
            inputDataList2.Position = "Junior Developer";

            // act            
            int compareToResult2 = inputDataList.CompareTo(inputDataList2);

            //assert
            Assert.AreEqual(-1, compareToResult2);
        }

        [TestMethod]
        public void CompareTo_ForEqualLetterOfTheAlphabet_Return0()
        {
            // arange
            InputDataList inputDataList = new InputDataList();
            inputDataList.Id = 10.1f;
            inputDataList.Name = "Adam";
            inputDataList.Surname = "Kowalski";
            inputDataList.Company = "IBM";
            inputDataList.Position = "Junior Developer";

            InputDataList inputDataList2 = new InputDataList();
            inputDataList2.Id = 10.1f;
            inputDataList2.Name = "Adam";
            inputDataList2.Surname = "Kowalski";
            inputDataList2.Company = "IBM";
            inputDataList2.Position = "Junior Developer";

            // act            
            int compareToResult2 = inputDataList.CompareTo(inputDataList2);

            //assert
            Assert.AreEqual(0, compareToResult2);
        }

        [TestMethod]
        public void CompareTo_ForLowerLetterOfTheAlphabetAndLowerId_Return9()
        {
            // arange
            InputDataList inputDataList = new InputDataList();
            inputDataList.Id = 10.1f;
            inputDataList.Name = "Adam";
            inputDataList.Surname = "Kowalski";
            inputDataList.Company = "IBM";
            inputDataList.Position = "Junior Developer";

            InputDataList inputDataList2 = new InputDataList();
            inputDataList2.Id = 8.1f;
            inputDataList2.Name = "Kris";
            inputDataList2.Surname = "Kowalski";
            inputDataList2.Company = "IBM";
            inputDataList2.Position = "Junior Developer";

            // act            
            int compareToResult2 = inputDataList.CompareTo(inputDataList2);

            //assert
            Assert.AreEqual(9, compareToResult2);
        }

        [TestMethod]
        public void CompareTo_ForLowerLetterOfTheAlphabetAndHigherId_ReturnMinus11()
        {
            // arange
            InputDataList inputDataList = new InputDataList();
            inputDataList.Id = 10.1f;
            inputDataList.Name = "Adam";
            inputDataList.Surname = "Kowalski";
            inputDataList.Company = "IBM";
            inputDataList.Position = "Junior Developer";

            InputDataList inputDataList2 = new InputDataList();
            inputDataList2.Id = 18.1f;
            inputDataList2.Name = "Kris";
            inputDataList2.Surname = "Kowalski";
            inputDataList2.Company = "IBM";
            inputDataList2.Position = "Junior Developer";

            // act            
            int compareToResult2 = inputDataList.CompareTo(inputDataList2);

            //assert
            Assert.AreEqual(-11, compareToResult2);
        }

        [TestMethod]
        public void CompareTo_ForHigherLetterOfTheAlphabetAndHigherId_ReturnMinus9()
        {
            // arange
            InputDataList inputDataList = new InputDataList();
            inputDataList.Id = 10.1f;
            inputDataList.Name = "Kris";
            inputDataList.Surname = "Kowalski";
            inputDataList.Company = "IBM";
            inputDataList.Position = "Junior Developer";

            InputDataList inputDataList2 = new InputDataList();
            inputDataList2.Id = 18.1f;
            inputDataList2.Name = "Adam";
            inputDataList2.Surname = "Kowalski";
            inputDataList2.Company = "IBM";
            inputDataList2.Position = "Junior Developer";

            // act            
            int compareToResult2 = inputDataList.CompareTo(inputDataList2);

            //assert
            Assert.AreEqual(-9, compareToResult2);
        }

        
    }
}
