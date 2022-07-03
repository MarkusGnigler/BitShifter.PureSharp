﻿using System;
using BitShifter.PureSharp.RoP;

namespace BitShifter.PureSharp.Tests.RoP.Fixtures
{
    internal static class ResultBuilder
    {

        public const string FAILURE_USER_NAME = "Test UserName";

        public static Result<User, Exception> GetSuccess()
            => new User(FAILURE_USER_NAME).Succeeded<User, Exception>();


        public const string FAILURE_EXCEPTION_MESSAGE = "Test MapFailure";

        public static Result<User, Exception> GetFailed()
            => new Exception(FAILURE_EXCEPTION_MESSAGE).Failed<User, Exception>();
    }

}
