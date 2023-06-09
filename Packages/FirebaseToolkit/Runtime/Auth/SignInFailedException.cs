using System;

namespace FirebaseToolkit.Auth
{
    public enum SignInFailReason
    {
        NotSupportProvider,
        PlatformCredentialFailed,
        PlatformCredentialCanceled
    }

    public class SignInFailedException : Exception
    {
        public readonly SignInFailReason Reason;
        public readonly string ProviderId;

        public SignInFailedException(SignInFailReason reason, string providerId)
            : base($"{providerId} signin process failed: {reason.ToString()}")
        {
            Reason = reason;
            ProviderId = providerId;
        }
    }
}