﻿using System;
using Cosmos.Business.Extensions.SMS.Exceptions;

namespace Cosmos.Business.Extensions.SMS.Luosimao.Exceptions {
    public class LuosimaoException : Exception, ISmsException {

        public long SerialVersionUID { get; protected set; }

        public int ErrorCode { get; protected set; }

        public LuosimaoException(string message, long serialVersionUid, int errorCode) : base(message) {
            SerialVersionUID = serialVersionUid;
            ErrorCode = errorCode;
        }

        public override string ToString() => $"code:{ErrorCode},message:{Message}";
    }
}