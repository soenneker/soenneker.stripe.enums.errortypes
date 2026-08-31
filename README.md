[![](https://img.shields.io/nuget/v/soenneker.stripe.enums.errortypes.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.stripe.enums.errortypes/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.stripe.enums.errortypes/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.stripe.enums.errortypes/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.stripe.enums.errortypes.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.stripe.enums.errortypes/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.stripe.enums.errortypes/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.stripe.enums.errortypes/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Stripe.Enums.ErrorTypes

Provides strongly typed values for Stripe's broad API failure categories, including card, authentication, permission, rate-limit, idempotency, request, and server errors.

## Installation

```bash
dotnet add package Soenneker.Stripe.Enums.ErrorTypes
```

## Usage

```csharp
using Soenneker.Stripe.Enums.ErrorTypes;

if (StripeErrorType.TryFromValue(stripeError.Type, out StripeErrorType? type))
{
    if (type == StripeErrorType.RateLimitError)
    {
        // Retry according to the application's backoff policy.
    }
}
```

Error types are coarse categories. Use the accompanying Stripe error code and decline code for more specific handling, and retain an unknown-value path so newer Stripe responses do not break error processing.
