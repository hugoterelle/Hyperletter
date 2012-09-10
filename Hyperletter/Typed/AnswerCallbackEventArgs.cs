using System;

namespace Hyperletter.Typed {
    public class AnswerCallbackEventArgs<TRequest, TReply> : EventArgs {
        public AnswerCallbackEventArgs(IAnswerable<TReply> answer, TRequest answerFor) {
            Answer = answer;
            AnswerFor = answerFor;
        }

        public AnswerCallbackEventArgs(TRequest answerFor, IAnswerable<TReply> answer, Exception exception) {
            AnswerFor = answerFor;
            Answer = answer;
            Exception = exception;
        }

        public TRequest AnswerFor { get; private set; }
        public IAnswerable<TReply> Answer { get; private set; }
        public Exception Exception { get; private set; }

        public bool Success {
            get { return Exception == null; }
        }
    }
}