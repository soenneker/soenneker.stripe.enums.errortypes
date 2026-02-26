using Soenneker.Gen.EnumValues;

namespace Soenneker.Stripe.Enums.ErrorTypes;

/// <summary>
/// A strongly-typed list of Stripe error types, representing broad categories of failure returned by the Stripe API.
/// </summary>
[EnumValue<string>]
public partial class StripeErrorType
{
    /// <summary>
    /// An error occurred on Stripe's servers or during request processing.
    /// </summary>
    public static readonly StripeErrorType ApiError = new("api_error");

    /// <summary>
    /// A card-related error (e.g. declined, incorrect CVC, etc).
    /// </summary>
    public static readonly StripeErrorType CardError = new("card_error");

    /// <summary>
    /// The request was invalid due to incorrect parameters or data.
    /// </summary>
    public static readonly StripeErrorType InvalidRequestError = new("invalid_request_error");

    /// <summary>
    /// The request could not be completed because of authentication or permission issues.
    /// </summary>
    public static readonly StripeErrorType AuthenticationError = new("authentication_error");

    /// <summary>
    /// The request was blocked due to rate limiting.
    /// </summary>
    public static readonly StripeErrorType RateLimitError = new("rate_limit_error");

    /// <summary>
    /// A webhook-specific error occurred.
    /// </summary>
    public static readonly StripeErrorType IdempotencyError = new("idempotency_error");

    /// <summary>
    /// The request was rejected due to insufficient permissions or access issues.
    /// </summary>
    public static readonly StripeErrorType PermissionError = new("permission_error");
}