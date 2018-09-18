using System;
using SimpleQuizApplication;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleQuizApp.Tests
{
    [TestClass]
    public class MultipleChoiceQuestionTests
    {

        [TestMethod()]
        public void getQuestion_NormalTest()
        {
            // Arrange
            String strQuestion = "Test 111";
            int intAnswer = 0;
            String[] strAnswers = {"Answer 111", "Answer 112", "Answer 113"};
            Question q = new MultipleChoiceQuestion(strQuestion, strAnswers, intAnswer);

            //Act
            String strResult = q.getQuestion();

            //Assert
            Assert.AreEqual(strQuestion, strResult);

        }
        [TestMethod()]
        public void getQuestion_EmptyStringTest()
        {
            // Arrange
            String strQuestion = "";
            int intAnswer = 0;
            String[] strAnswers = { "Answer 111", "Answer 112", "Answer 113" };
            Question q = new MultipleChoiceQuestion(strQuestion, strAnswers, intAnswer);

            //Act
            String strResult = q.getQuestion();

            //Assert
            Assert.AreEqual(strQuestion, strResult);

        }
        [TestMethod()]
        public void getQuestion_LongStringTest()
        {
            // Arrange
            String strQuestion = "123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890";
            int intAnswer = 0;
            String[] strAnswers = { "Answer 111", "Answer 112", "Answer 113" };
            Question q = new MultipleChoiceQuestion(strQuestion, strAnswers, intAnswer);

            //Act
            String strResult = q.getQuestion();

            //Assert
            Assert.AreEqual(strQuestion, strResult);

        }

        [TestMethod()]
        public void getAnswer_NormalTest()
        {
            // Arrange
            String strQuestion = "Test 111";
            int intAnswer = 0;
            String strAnswer = "Answer 111";
            String[] strAnswers = { "Answer 111", "Answer 112", "Answer 113" };
            Question q = new MultipleChoiceQuestion(strQuestion, strAnswers, intAnswer);

            //Act
            String strResult = q.getAnswer();

            //Assert
            Assert.AreEqual(strAnswer, strResult);
        }

        [TestMethod()]
        public void checkAnswer_NormalTest()
        {
            // Arrange
            String strQuestion = "Test 111";
            int intAnswer = 0;
            String strAnswer = "Answer 111";
            String[] strAnswers = { "Answer 111", "Answer 112", "Answer 113" };
            Question q = new MultipleChoiceQuestion(strQuestion, strAnswers, intAnswer);

            //Act

            //Assert
            Assert.IsTrue(q.checkAnswer(strAnswer));
        }

        [TestMethod()]
        public void checkAnswer_LowerCaseTest()
        {
            // Arrange
            String strQuestion = "Test 111";
            int intAnswer = 0;
            String strLowerCaseAnswer = "answer 111";
            String[] strAnswers = { "Answer 111", "Answer 112", "Answer 113" };
            Question q = new MultipleChoiceQuestion(strQuestion, strAnswers, intAnswer);

            //Act

            //Assert
            Assert.IsTrue(q.checkAnswer(strLowerCaseAnswer));
        }
        [TestMethod()]
        public void checkAnswer_UpperCaseTest()
        {
            // Arrange
            String strQuestion = "Test 111";
            int intAnswer = 0;
            String strUpperCaseAnswer = "ANSWER 111";
            String[] strAnswers = { "Answer 111", "Answer 112", "Answer 113" };
            Question q = new MultipleChoiceQuestion(strQuestion, strAnswers, intAnswer);

            //Act

            //Assert
            Assert.IsTrue(q.checkAnswer(strUpperCaseAnswer));
        }
        [TestMethod()]
        public void checkAnswer_ExtrasSpaceBeforeTest()
        {
            // Arrange
            String strQuestion = "Test 111";
            int intAnswer = 0;
            String strAnswer = "Answer 111";
            String strAnswerWithSpaceBefore = " Answer 111";
            String[] strAnswers = { "Answer 111", "Answer 112", "Answer 113" };
            Question q = new MultipleChoiceQuestion(strQuestion, strAnswers, intAnswer);

            //Act

            //Assert
            Assert.IsTrue(q.checkAnswer(strAnswerWithSpaceBefore));
        }

        [TestMethod()]
        public void checkAnswer_ExtrasSpaceAfterTest()
        {
            // Arrange
            String strQuestion = "Test 111";
            int intAnswer = 0;
            String strAnswer = "Answer 111";
            String strAnswerWithSpaceAfter = "Answer 111 ";
            String[] strAnswers = { "Answer 111", "Answer 112", "Answer 113" };
            Question q = new MultipleChoiceQuestion(strQuestion, strAnswers, intAnswer);

            //Act

            //Assert
            Assert.IsTrue(q.checkAnswer(strAnswerWithSpaceAfter));
        }

        [TestMethod()]
        public void checkAnswer_ExtrasSpaceInMiddleTest()
        {
            // Arrange
            String strQuestion = "Test 111";
            int intAnswer = 0;
            String strAnswer = "Answer 111";
            String strAnswerWithSpaceInMiddle = "Answer  111 ";
            String[] strAnswers = { "Answer 111", "Answer 112", "Answer 113" };
            Question q = new MultipleChoiceQuestion(strQuestion, strAnswers, intAnswer);

            //Act

            //Assert
            Assert.IsTrue(q.checkAnswer(strAnswerWithSpaceInMiddle));
        }

        [TestMethod()]
        public void checkAnswer_WrongAnswerTest()
        {
            // Arrange
            String strQuestion = "Test 111";
            int intAnswer = 0;
            String strWrongAnswer = "Wrong";
            String[] strAnswers = { "Answer 111", "Answer 112", "Answer 113" };
            Question q = new MultipleChoiceQuestion(strQuestion, strAnswers, intAnswer);

            //Act
            String strResult = q.getAnswer();

            //Assert
            Assert.IsFalse(q.checkAnswer(strWrongAnswer));
        }
    }
}