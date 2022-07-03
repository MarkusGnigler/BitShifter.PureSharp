using Xunit;
using System;
using FluentAssertions;
using BitShifter.PureSharp.RoP;
using BitShifter.PureSharp.Tests.RoP.Fixtures;

namespace BitShifter.PureSharp.Tests.RoP
{
    public class ResultTest
    {

        #region [ Creation ]

        [Fact]
        public void Create_Success_Result()
        {
            //Arrange
            var EXPECTED = typeof(Result<User, Exception>.Success);

            Result<User, Exception> result
                = ResultBuilder.GetSuccess();

            //Act

            //Assert
            result.Should()
                .BeOfType(EXPECTED);
        }

        [Fact]
        public void Create_Success_Throws_NullException()
        {
            //Arrange
            string EXPECTED = "Value cannot be null. (Parameter 'success')";

            Func<Result<User, string[]>> createResultAction =
                () => ((User)null).Succeeded<User, string[]>();

            //Act

            //Assert
            createResultAction
                .Should()
                .Throw<ArgumentNullException>()
                .WithMessage(EXPECTED);
        }

        [Fact]
        public void Create_Failure_Result()
        {
            //Arrange
            var EXPECTED = typeof(Result<User, string[]>.Failure);

            Result<User, string[]> result
                = new[] { string.Empty }.Failed<User, string[]>();

            //Act

            //Assert
            result.Should()
                .BeOfType(EXPECTED);
        }

        [Fact]
        public void Create_Failure_Throws_NullException()
        {
            //Arrange
            string EXPECTED = "Value cannot be null. (Parameter 'failure')";

            Func<Result<User, string[]>> createResultAction =
                () => (null as string[]).Failed<User, string[]>();

            //Act

            //Assert
            createResultAction
                .Should()
                .Throw<ArgumentNullException>()
                .WithMessage(EXPECTED);
        }

        #endregion

        #region [ Casting / As operator ]

        [Fact]
        public void Cast_Success_Result_ToRight_Type()
        {
            //Arrange
            var EXPECTED = typeof(Result<User, string[]>.Success);

            Result<User, string[]> result
                = new User(string.Empty).Succeeded<User, string[]>();

            //Act

            //Assert
            //result.AsSuccees()
            result
                .Should()
                .BeOfType(EXPECTED);
        }

        [Fact]
        public void Cast_Failure_Result_ToRight_Type()
        {
            //Arrange
            var EXPECTED = typeof(Result<User, string[]>.Failure);

            Result<User, string[]> result
                = new[] { string.Empty }.Failed<User, string[]>();

            //Act

            //Assert
            //result.AsFailure()
            result
                .Should()
                .BeOfType(EXPECTED);
        }

        #endregion

        #region [ Querying / Is operator ]

        //[Fact]
        //public void Test_If_Result_IsSuccess_Is_True()
        //{
        //    //Arrange
        //    Result<User, Exception> result
        //        = ResultBuilder.GetSuccess();

        //    //Act

        //    //Assert
        //    result.IsSuccess
        //        .Should()
        //        .BeTrue();
        //}

        //[Fact]
        //public void Test_If_Result_IsSuccess_Is_False()
        //{
        //    //Arrange
        //    Result<User, Exception> result
        //        = ResultBuilder.GetFailed();

        //    //Act

        //    //Assert
        //    result.IsSuccess
        //        .Should()
        //        .BeFalse();
        //}

        //[Fact]
        //public void Test_If_Result_IsFailure_Is_True()
        //{
        //    //Arrange
        //    Result<User, Exception> result
        //        = ResultBuilder.GetFailed();

        //    //Act

        //    //Assert
        //    result.IsFailure
        //        .Should()
        //        .BeTrue();
        //}

        //[Fact]
        //public void Test_If_Result_IsFailure_Is_False()
        //{
        //    //Arrange
        //    Result<User, Exception> result
        //        = ResultBuilder.GetSuccess();

        //    //Act

        //    //Assert
        //    result.IsFailure
        //        .Should()
        //        .BeFalse();
        //}

        #endregion

    }
}
