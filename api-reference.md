# Reference

> Source: [SquareConnectApiClient](SquareConnectApiClient.cs)

## ApplePay

> Source: [ApplePay](Api/ApplePay.cs)

<details>
<summary><code>Task&lt;RegisterDomainResponse&gt; RegisterDomain(RegisterDomainRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Activates a domain for use with Apple Pay on the Web and Square. A validation
is performed on this domain by Apple to ensure that it is properly set up as
an Apple Pay enabled domain.

This endpoint provides an easy way for platform developers to bulk activate
Apple Pay on the Web with Square for merchants using their platform.

To learn more about Web Apple Pay, see
[Add the Apple Pay on the Web Button](https://developer.squareup.com/docs/payment-form/add-digital-wallets/apple-pay).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ApplePay.RegisterDomain(body);
    // TODO: Handle 'response' of type RegisterDomainResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[RegisterDomainRequest](Models/RegisterDomainRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RegisterDomainResponse](Models/RegisterDomainResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## BankAccounts

> Source: [BankAccounts](Api/BankAccounts.cs)

<details>
<summary><code>Task&lt;GetBankAccountResponse&gt; GetBankAccount(string bankAccountId, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns details of a [BankAccount](https://developer.squareup.com/reference/square_2021-08-18/objects/BankAccount)
linked to a Square account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BankAccounts.GetBankAccount(bankAccountId);
    // TODO: Handle 'response' of type GetBankAccountResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>bankAccountId</code> | <code>string</code> | Square-issued ID of the desired `BankAccount`. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetBankAccountResponse](Models/GetBankAccountResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetBankAccountByV1IdResponse&gt; GetBankAccountByV1Id(string v1BankAccountId, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns details of a [BankAccount](https://developer.squareup.com/reference/square_2021-08-18/objects/BankAccount) identified by V1 bank account ID.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BankAccounts.GetBankAccountByV1Id(v1BankAccountId);
    // TODO: Handle 'response' of type GetBankAccountByV1IdResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>v1BankAccountId</code> | <code>string</code> | Connect V1 ID of the desired `BankAccount`. For more information, see <br>[Retrieve a bank account by using an ID issued by V1 Bank Accounts API](https://developer.squareup.com/docs/bank-accounts-api#retrieve-a-bank-account-by-using-an-id-issued-by-v1-bank-accounts-api). |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetBankAccountByV1IdResponse](Models/GetBankAccountByV1IdResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListBankAccountsResponse&gt; ListBankAccounts(string? cursor, int? limit, string? locationId, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of [BankAccount](https://developer.squareup.com/reference/square_2021-08-18/objects/BankAccount) objects linked to a Square account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BankAccounts.ListBankAccounts(cursor, limit, locationId);
    // TODO: Handle 'response' of type ListBankAccountsResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>cursor</code> | <code>string?</code> | The pagination cursor returned by a previous call to this endpoint.<br>Use it in the next `ListBankAccounts` request to retrieve the next set <br>of results.<br><br>See the [Pagination](https://developer.squareup.com/docs/working-with-apis/pagination) guide for more information. |
| <code>limit</code> | <code>int?</code> | Upper limit on the number of bank accounts to return in the response. <br>Currently, 1000 is the largest supported limit. You can specify a limit <br>of up to 1000 bank accounts. This is also the default limit. |
| <code>locationId</code> | <code>string?</code> | Location ID. You can specify this optional filter <br>to retrieve only the linked bank accounts belonging to a specific location. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListBankAccountsResponse](Models/ListBankAccountsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Bookings

> Source: [Bookings](Api/Bookings.cs)

<details>
<summary><code>Task&lt;CancelBookingResponse&gt; CancelBooking(string bookingId, CancelBookingRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Cancels an existing booking.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Bookings.CancelBooking(bookingId, body);
    // TODO: Handle 'response' of type CancelBookingResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>bookingId</code> | <code>string</code> | The ID of the [Booking](https://developer.squareup.com/reference/square_2021-08-18/objects/Booking) object representing the to-be-cancelled booking. |
| <code>body</code> | <code>[CancelBookingRequest](Models/CancelBookingRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CancelBookingResponse](Models/CancelBookingResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreateBookingResponse&gt; CreateBooking(CreateBookingRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a booking.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Bookings.CreateBooking(body);
    // TODO: Handle 'response' of type CreateBookingResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[CreateBookingRequest](Models/CreateBookingRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateBookingResponse](Models/CreateBookingResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListTeamMemberBookingProfilesResponse&gt; ListTeamMemberBookingProfiles(bool? bookableOnly, int? limit, string? cursor, string? locationId, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists booking profiles for team members.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Bookings.ListTeamMemberBookingProfiles(bookableOnly, limit, cursor, locationId);
    // TODO: Handle 'response' of type ListTeamMemberBookingProfilesResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>bookableOnly</code> | <code>bool?</code> | Indicates whether to include only bookable team members in the returned result (`true`) or not (`false`). |
| <code>limit</code> | <code>int?</code> | The maximum number of results to return. |
| <code>cursor</code> | <code>string?</code> | The cursor for paginating through the results. |
| <code>locationId</code> | <code>string?</code> | Indicates whether to include only team members enabled at the given location in the returned result. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListTeamMemberBookingProfilesResponse](Models/ListTeamMemberBookingProfilesResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveBookingResponse&gt; RetrieveBooking(string bookingId, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a booking.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Bookings.RetrieveBooking(bookingId);
    // TODO: Handle 'response' of type RetrieveBookingResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>bookingId</code> | <code>string</code> | The ID of the [Booking](https://developer.squareup.com/reference/square_2021-08-18/objects/Booking) object representing the to-be-retrieved booking. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveBookingResponse](Models/RetrieveBookingResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveBusinessBookingProfileResponse&gt; RetrieveBusinessBookingProfile(CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a seller's booking profile.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Bookings.RetrieveBusinessBookingProfile();
    // TODO: Handle 'response' of type RetrieveBusinessBookingProfileResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveBusinessBookingProfileResponse](Models/RetrieveBusinessBookingProfileResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveTeamMemberBookingProfileResponse&gt; RetrieveTeamMemberBookingProfile(string teamMemberId, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a team member's booking profile.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Bookings.RetrieveTeamMemberBookingProfile(teamMemberId);
    // TODO: Handle 'response' of type RetrieveTeamMemberBookingProfileResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>teamMemberId</code> | <code>string</code> | The ID of the team member to retrieve. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveTeamMemberBookingProfileResponse](Models/RetrieveTeamMemberBookingProfileResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SearchAvailabilityResponse&gt; SearchAvailability(SearchAvailabilityRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Searches for availabilities for booking.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Bookings.SearchAvailability(body);
    // TODO: Handle 'response' of type SearchAvailabilityResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[SearchAvailabilityRequest](Models/SearchAvailabilityRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SearchAvailabilityResponse](Models/SearchAvailabilityResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpdateBookingResponse&gt; UpdateBooking(string bookingId, UpdateBookingRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates a booking.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Bookings.UpdateBooking(bookingId, body);
    // TODO: Handle 'response' of type UpdateBookingResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>bookingId</code> | <code>string</code> | The ID of the [Booking](https://developer.squareup.com/reference/square_2021-08-18/objects/Booking) object representing the to-be-updated booking. |
| <code>body</code> | <code>[UpdateBookingRequest](Models/UpdateBookingRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpdateBookingResponse](Models/UpdateBookingResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Cards

> Source: [Cards](Api/Cards.cs)

<details>
<summary><code>Task&lt;CreateCardResponse&gt; CreateCard(CreateCardRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Adds a card on file to an existing merchant.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Cards.CreateCard(body);
    // TODO: Handle 'response' of type CreateCardResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[CreateCardRequest](Models/CreateCardRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateCardResponse](Models/CreateCardResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DisableCardResponse&gt; DisableCard(string cardId, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Disables the card, preventing any further updates or charges.
Disabling an already disabled card is allowed but has no effect.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Cards.DisableCard(cardId);
    // TODO: Handle 'response' of type DisableCardResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>cardId</code> | <code>string</code> | Unique ID for the desired Card. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DisableCardResponse](Models/DisableCardResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListCardsResponse&gt; ListCards(string? cursor, string? customerId, bool? includeDisabled, string? referenceId, string? sortOrder, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a list of cards owned by the account making the request.
A max of 25 cards will be returned.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Cards.ListCards(cursor, customerId, includeDisabled, referenceId, sortOrder);
    // TODO: Handle 'response' of type ListCardsResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>cursor</code> | <code>string?</code> | A pagination cursor returned by a previous call to this endpoint.<br>Provide this to retrieve the next set of results for your original query.<br><br>See [Pagination](https://developer.squareup.com/docs/basics/api101/pagination) for more information. |
| <code>customerId</code> | <code>string?</code> | Limit results to cards associated with the customer supplied.<br>By default, all cards owned by the merchant are returned. |
| <code>includeDisabled</code> | <code>bool?</code> | Includes disabled cards.<br>By default, all enabled cards owned by the merchant are returned. |
| <code>referenceId</code> | <code>string?</code> | Limit results to cards associated with the reference_id supplied. |
| <code>sortOrder</code> | <code>string?</code> | Sorts the returned list by when the card was created with the specified order.<br>This field defaults to ASC. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListCardsResponse](Models/ListCardsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveCardResponse&gt; RetrieveCard(string cardId, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves details for a specific Card.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Cards.RetrieveCard(cardId);
    // TODO: Handle 'response' of type RetrieveCardResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>cardId</code> | <code>string</code> | Unique ID for the desired Card. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveCardResponse](Models/RetrieveCardResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## CashDrawers

> Source: [CashDrawers](Api/CashDrawers.cs)

<details>
<summary><code>Task&lt;ListCashDrawerShiftEventsResponse&gt; ListCashDrawerShiftEvents(string shiftId, string locationId, int? limit, string? cursor, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Provides a paginated list of events for a single cash drawer shift.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CashDrawers.ListCashDrawerShiftEvents(shiftId, locationId, limit, cursor);
    // TODO: Handle 'response' of type ListCashDrawerShiftEventsResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>shiftId</code> | <code>string</code> | The shift ID. |
| <code>locationId</code> | <code>string</code> | The ID of the location to list cash drawer shifts for. |
| <code>limit</code> | <code>int?</code> | Number of resources to be returned in a page of results (200 by<br>default, 1000 max). |
| <code>cursor</code> | <code>string?</code> | Opaque cursor for fetching the next page of results. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListCashDrawerShiftEventsResponse](Models/ListCashDrawerShiftEventsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListCashDrawerShiftsResponse&gt; ListCashDrawerShifts(string locationId, string? sortOrder, string? beginTime, string? endTime, int? limit, string? cursor, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Provides the details for all of the cash drawer shifts for a location
in a date range.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CashDrawers.ListCashDrawerShifts(locationId,
        sortOrder,
        beginTime,
        endTime,
        limit,
        cursor);
    // TODO: Handle 'response' of type ListCashDrawerShiftsResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>locationId</code> | <code>string</code> | The ID of the location to query for a list of cash drawer shifts. |
| <code>sortOrder</code> | <code>string?</code> | The order in which cash drawer shifts are listed in the response,<br>based on their opened_at field. Default value: ASC |
| <code>beginTime</code> | <code>string?</code> | The inclusive start time of the query on opened_at, in ISO 8601 format. |
| <code>endTime</code> | <code>string?</code> | The exclusive end date of the query on opened_at, in ISO 8601 format. |
| <code>limit</code> | <code>int?</code> | Number of cash drawer shift events in a page of results (200 by<br>default, 1000 max). |
| <code>cursor</code> | <code>string?</code> | Opaque cursor for fetching the next page of results. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListCashDrawerShiftsResponse](Models/ListCashDrawerShiftsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveCashDrawerShiftResponse&gt; RetrieveCashDrawerShift(string shiftId, string locationId, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Provides the summary details for a single cash drawer shift. See
[ListCashDrawerShiftEvents](https://developer.squareup.com/reference/square_2021-08-18/cash-drawers-api/list-cash-drawer-shift-events) for a list of cash drawer shift events.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CashDrawers.RetrieveCashDrawerShift(shiftId, locationId);
    // TODO: Handle 'response' of type RetrieveCashDrawerShiftResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>shiftId</code> | <code>string</code> | The shift ID. |
| <code>locationId</code> | <code>string</code> | The ID of the location to retrieve cash drawer shifts from. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveCashDrawerShiftResponse](Models/RetrieveCashDrawerShiftResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Catalog

> Source: [Catalog](Api/Catalog.cs)

<details>
<summary><code>Task&lt;BatchDeleteCatalogObjectsResponse&gt; BatchDeleteCatalogObjects(BatchDeleteCatalogObjectsRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes a set of [CatalogItem](https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogItem)s based on the
provided list of target IDs and returns a set of successfully deleted IDs in
the response. Deletion is a cascading event such that all children of the
targeted object are also deleted. For example, deleting a CatalogItem will
also delete all of its [CatalogItemVariation](https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogItemVariation)
children.

`BatchDeleteCatalogObjects` succeeds even if only a portion of the targeted
IDs can be deleted. The response will only include IDs that were
actually deleted.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Catalog.BatchDeleteCatalogObjects(body);
    // TODO: Handle 'response' of type BatchDeleteCatalogObjectsResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[BatchDeleteCatalogObjectsRequest](Models/BatchDeleteCatalogObjectsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BatchDeleteCatalogObjectsResponse](Models/BatchDeleteCatalogObjectsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BatchRetrieveCatalogObjectsResponse&gt; BatchRetrieveCatalogObjects(BatchRetrieveCatalogObjectsRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a set of objects based on the provided ID.
Each [CatalogItem](https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogItem) returned in the set includes all of its
child information including: all of its
[CatalogItemVariation](https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogItemVariation) objects, references to
its [CatalogModifierList](https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogModifierList) objects, and the ids of
any [CatalogTax](https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogTax) objects that apply to it.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Catalog.BatchRetrieveCatalogObjects(body);
    // TODO: Handle 'response' of type BatchRetrieveCatalogObjectsResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[BatchRetrieveCatalogObjectsRequest](Models/BatchRetrieveCatalogObjectsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BatchRetrieveCatalogObjectsResponse](Models/BatchRetrieveCatalogObjectsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BatchUpsertCatalogObjectsResponse&gt; BatchUpsertCatalogObjects(BatchUpsertCatalogObjectsRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates or updates up to 10,000 target objects based on the provided
list of objects. The target objects are grouped into batches and each batch is
inserted/updated in an all-or-nothing manner. If an object within a batch is
malformed in some way, or violates a database constraint, the entire batch
containing that item will be disregarded. However, other batches in the same
request may still succeed. Each batch may contain up to 1,000 objects, and
batches will be processed in order as long as the total object count for the
request (items, variations, modifier lists, discounts, and taxes) is no more
than 10,000.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Catalog.BatchUpsertCatalogObjects(body);
    // TODO: Handle 'response' of type BatchUpsertCatalogObjectsResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[BatchUpsertCatalogObjectsRequest](Models/BatchUpsertCatalogObjectsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BatchUpsertCatalogObjectsResponse](Models/BatchUpsertCatalogObjectsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CatalogInfoResponse&gt; CatalogInfo(CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves information about the Square Catalog API, such as batch size
limits that can be used by the `BatchUpsertCatalogObjects` endpoint.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Catalog.CatalogInfo();
    // TODO: Handle 'response' of type CatalogInfoResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CatalogInfoResponse](Models/CatalogInfoResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeleteCatalogObjectResponse&gt; DeleteCatalogObject(string objectId, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes a single [CatalogObject](https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogObject) based on the
provided ID and returns the set of successfully deleted IDs in the response.
Deletion is a cascading event such that all children of the targeted object
are also deleted. For example, deleting a [CatalogItem](https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogItem)
will also delete all of its
[CatalogItemVariation](https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogItemVariation) children.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Catalog.DeleteCatalogObject(objectId);
    // TODO: Handle 'response' of type DeleteCatalogObjectResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>objectId</code> | <code>string</code> | The ID of the catalog object to be deleted. When an object is deleted, other<br>objects in the graph that depend on that object will be deleted as well (for example, deleting a<br>catalog item will delete its catalog item variations). |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeleteCatalogObjectResponse](Models/DeleteCatalogObjectResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListCatalogResponse&gt; ListCatalog(string? cursor, string? types, long? catalogVersion, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of [CatalogObject](https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogObject)s that includes
all objects of a set of desired types (for example, all [CatalogItem](https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogItem)
and [CatalogTax](https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogTax) objects) in the catalog. The `types` parameter
is specified as a comma-separated list of valid [CatalogObject](https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogObject) types:
`ITEM`, `ITEM_VARIATION`, `MODIFIER`, `MODIFIER_LIST`, `CATEGORY`, `DISCOUNT`, `TAX`, `IMAGE`.

__Important:__ ListCatalog does not return deleted catalog items. To retrieve
deleted catalog items, use [SearchCatalogObjects](https://developer.squareup.com/reference/square_2021-08-18/catalog-api/search-catalog-objects)
and set the `include_deleted_objects` attribute value to `true`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Catalog.ListCatalog(cursor, types, catalogVersion);
    // TODO: Handle 'response' of type ListCatalogResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>cursor</code> | <code>string?</code> | The pagination cursor returned in the previous response. Leave unset for an initial request.<br>The page size is currently set to be 100.<br>See [Pagination](https://developer.squareup.com/docs/basics/api101/pagination) for more information. |
| <code>types</code> | <code>string?</code> | An optional case-insensitive, comma-separated list of object types to retrieve.<br><br>The valid values are defined in the [CatalogObjectType](https://developer.squareup.com/reference/square_2021-08-18/enums/CatalogObjectType) enum, including<br>`ITEM`, `ITEM_VARIATION`, `CATEGORY`, `DISCOUNT`, `TAX`,<br>`MODIFIER`, `MODIFIER_LIST`, or `IMAGE`.<br><br>If this is unspecified, the operation returns objects of all the types at the version of the Square API used to make the request. |
| <code>catalogVersion</code> | <code>long?</code> | The specific version of the catalog objects to be included in the response. <br>This allows you to retrieve historical<br>versions of objects. The specified version value is matched against<br>the [CatalogObject](https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogObject)s' `version` attribute. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListCatalogResponse](Models/ListCatalogResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveCatalogObjectResponse&gt; RetrieveCatalogObject(string objectId, bool? includeRelatedObjects, long? catalogVersion, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a single [CatalogItem](https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogItem) as a
[CatalogObject](https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogObject) based on the provided ID. The returned
object includes all of the relevant [CatalogItem](https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogItem)
information including: [CatalogItemVariation](https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogItemVariation)
children, references to its
[CatalogModifierList](https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogModifierList) objects, and the ids of
any [CatalogTax](https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogTax) objects that apply to it.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Catalog.RetrieveCatalogObject(objectId, includeRelatedObjects, catalogVersion);
    // TODO: Handle 'response' of type RetrieveCatalogObjectResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>objectId</code> | <code>string</code> | The object ID of any type of catalog objects to be retrieved. |
| <code>includeRelatedObjects</code> | <code>bool?</code> | If `true`, the response will include additional objects that are related to the<br>requested object, as follows:<br><br>If the `object` field of the response contains a `CatalogItem`, its associated<br>`CatalogCategory`, `CatalogTax`, `CatalogImage` and `CatalogModifierList` objects will<br>be returned in the `related_objects` field of the response. If the `object` field of<br>the response contains a `CatalogItemVariation`, its parent `CatalogItem` will be returned<br>in the `related_objects` field of the response.<br><br>Default value: `false` |
| <code>catalogVersion</code> | <code>long?</code> | Requests objects as of a specific version of the catalog. This allows you to retrieve historical<br>versions of objects. The value to retrieve a specific version of an object can be found<br>in the version field of [CatalogObject](https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogObject)s. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveCatalogObjectResponse](Models/RetrieveCatalogObjectResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SearchCatalogItemsResponse&gt; SearchCatalogItems(SearchCatalogItemsRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Searches for catalog items or item variations by matching supported search attribute values, including
custom attribute values, against one or more of the specified query expressions.

This (`SearchCatalogItems`) endpoint differs from the [SearchCatalogObjects](https://developer.squareup.com/reference/square_2021-08-18/catalog-api/search-catalog-objects)
endpoint in the following aspects:

- `SearchCatalogItems` can only search for items or item variations, whereas `SearchCatalogObjects` can search for any type of catalog objects.
- `SearchCatalogItems` supports the custom attribute query filters to return items or item variations that contain custom attribute values, where `SearchCatalogObjects` does not.
- `SearchCatalogItems` does not support the `include_deleted_objects` filter to search for deleted items or item variations, whereas `SearchCatalogObjects` does.
- The both endpoints use different call conventions, including the query filter formats.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Catalog.SearchCatalogItems(body);
    // TODO: Handle 'response' of type SearchCatalogItemsResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[SearchCatalogItemsRequest](Models/SearchCatalogItemsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SearchCatalogItemsResponse](Models/SearchCatalogItemsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SearchCatalogObjectsResponse&gt; SearchCatalogObjects(SearchCatalogObjectsRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Searches for [CatalogObject](https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogObject) of any type by matching supported search attribute values,
excluding custom attribute values on items or item variations, against one or more of the specified query expressions.

This (`SearchCatalogObjects`) endpoint differs from the [SearchCatalogItems](https://developer.squareup.com/reference/square_2021-08-18/catalog-api/search-catalog-items)
endpoint in the following aspects:

- `SearchCatalogItems` can only search for items or item variations, whereas `SearchCatalogObjects` can search for any type of catalog objects.
- `SearchCatalogItems` supports the custom attribute query filters to return items or item variations that contain custom attribute values, where `SearchCatalogObjects` does not.
- `SearchCatalogItems` does not support the `include_deleted_objects` filter to search for deleted items or item variations, whereas `SearchCatalogObjects` does.
- The both endpoints have different call conventions, including the query filter formats.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Catalog.SearchCatalogObjects(body);
    // TODO: Handle 'response' of type SearchCatalogObjectsResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[SearchCatalogObjectsRequest](Models/SearchCatalogObjectsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SearchCatalogObjectsResponse](Models/SearchCatalogObjectsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpdateItemModifierListsResponse&gt; UpdateItemModifierLists(UpdateItemModifierListsRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates the [CatalogModifierList](https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogModifierList) objects
that apply to the targeted [CatalogItem](https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogItem) without having
to perform an upsert on the entire item.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Catalog.UpdateItemModifierLists(body);
    // TODO: Handle 'response' of type UpdateItemModifierListsResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[UpdateItemModifierListsRequest](Models/UpdateItemModifierListsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpdateItemModifierListsResponse](Models/UpdateItemModifierListsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpdateItemTaxesResponse&gt; UpdateItemTaxes(UpdateItemTaxesRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates the [CatalogTax](https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogTax) objects that apply to the
targeted [CatalogItem](https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogItem) without having to perform an
upsert on the entire item.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Catalog.UpdateItemTaxes(body);
    // TODO: Handle 'response' of type UpdateItemTaxesResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[UpdateItemTaxesRequest](Models/UpdateItemTaxesRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpdateItemTaxesResponse](Models/UpdateItemTaxesResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpsertCatalogObjectResponse&gt; UpsertCatalogObject(UpsertCatalogObjectRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates or updates the target [CatalogObject](https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogObject).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Catalog.UpsertCatalogObject(body);
    // TODO: Handle 'response' of type UpsertCatalogObjectResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[UpsertCatalogObjectRequest](Models/UpsertCatalogObjectRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpsertCatalogObjectResponse](Models/UpsertCatalogObjectResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## CheckoutModel

> Source: [CheckoutModel](Api/CheckoutModel.cs)

<details>
<summary><code>Task&lt;CreateCheckoutResponse&gt; CreateCheckout(string locationId, CreateCheckoutRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Links a `checkoutId` to a `checkout_page_url` that customers are
directed to in order to provide their payment information using a
payment processing workflow hosted on connect.squareup.com.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CheckoutModel.CreateCheckout(locationId, body);
    // TODO: Handle 'response' of type CreateCheckoutResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>locationId</code> | <code>string</code> | The ID of the business location to associate the checkout with. |
| <code>body</code> | <code>[CreateCheckoutRequest](Models/CreateCheckoutRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateCheckoutResponse](Models/CreateCheckoutResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## CustomerGroups

> Source: [CustomerGroups](Api/CustomerGroups.cs)

<details>
<summary><code>Task&lt;CreateCustomerGroupResponse&gt; CreateCustomerGroup(CreateCustomerGroupRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a new customer group for a business.

The request must include the `name` value of the group.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CustomerGroups.CreateCustomerGroup(body);
    // TODO: Handle 'response' of type CreateCustomerGroupResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[CreateCustomerGroupRequest](Models/CreateCustomerGroupRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateCustomerGroupResponse](Models/CreateCustomerGroupResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeleteCustomerGroupResponse&gt; DeleteCustomerGroup(string groupId, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes a customer group as identified by the `group_id` value.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CustomerGroups.DeleteCustomerGroup(groupId);
    // TODO: Handle 'response' of type DeleteCustomerGroupResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>groupId</code> | <code>string</code> | The ID of the customer group to delete. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeleteCustomerGroupResponse](Models/DeleteCustomerGroupResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListCustomerGroupsResponse&gt; ListCustomerGroups(string? cursor, int? limit, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves the list of customer groups of a business.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CustomerGroups.ListCustomerGroups(cursor, limit);
    // TODO: Handle 'response' of type ListCustomerGroupsResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>cursor</code> | <code>string?</code> | A pagination cursor returned by a previous call to this endpoint.<br>Provide this cursor to retrieve the next set of results for your original query.<br><br>For more information, see [Pagination](https://developer.squareup.com/docs/working-with-apis/pagination). |
| <code>limit</code> | <code>int?</code> | The maximum number of results to return in a single page. This limit is advisory. The response might contain more or fewer results. <br>The limit is ignored if it is less than 1 or greater than 50. The default value is 50.<br><br>For more information, see [Pagination](https://developer.squareup.com/docs/working-with-apis/pagination). |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListCustomerGroupsResponse](Models/ListCustomerGroupsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveCustomerGroupResponse&gt; RetrieveCustomerGroup(string groupId, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a specific customer group as identified by the `group_id` value.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CustomerGroups.RetrieveCustomerGroup(groupId);
    // TODO: Handle 'response' of type RetrieveCustomerGroupResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>groupId</code> | <code>string</code> | The ID of the customer group to retrieve. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveCustomerGroupResponse](Models/RetrieveCustomerGroupResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpdateCustomerGroupResponse&gt; UpdateCustomerGroup(string groupId, UpdateCustomerGroupRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates a customer group as identified by the `group_id` value.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CustomerGroups.UpdateCustomerGroup(groupId, body);
    // TODO: Handle 'response' of type UpdateCustomerGroupResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>groupId</code> | <code>string</code> | The ID of the customer group to update. |
| <code>body</code> | <code>[UpdateCustomerGroupRequest](Models/UpdateCustomerGroupRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpdateCustomerGroupResponse](Models/UpdateCustomerGroupResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## CustomerSegments

> Source: [CustomerSegments](Api/CustomerSegments.cs)

<details>
<summary><code>Task&lt;ListCustomerSegmentsResponse&gt; ListCustomerSegments(string? cursor, int? limit, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves the list of customer segments of a business.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CustomerSegments.ListCustomerSegments(cursor, limit);
    // TODO: Handle 'response' of type ListCustomerSegmentsResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>cursor</code> | <code>string?</code> | A pagination cursor returned by previous calls to `ListCustomerSegments`.<br>This cursor is used to retrieve the next set of query results.<br><br>For more information, see [Pagination](https://developer.squareup.com/docs/working-with-apis/pagination). |
| <code>limit</code> | <code>int?</code> | The maximum number of results to return in a single page. This limit is advisory. The response might contain more or fewer results. <br>The limit is ignored if it is less than 1 or greater than 50. The default value is 50.<br><br>For more information, see [Pagination](https://developer.squareup.com/docs/working-with-apis/pagination). |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListCustomerSegmentsResponse](Models/ListCustomerSegmentsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveCustomerSegmentResponse&gt; RetrieveCustomerSegment(string segmentId, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a specific customer segment as identified by the `segment_id` value.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CustomerSegments.RetrieveCustomerSegment(segmentId);
    // TODO: Handle 'response' of type RetrieveCustomerSegmentResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>segmentId</code> | <code>string</code> | The Square-issued ID of the customer segment. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveCustomerSegmentResponse](Models/RetrieveCustomerSegmentResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Customers

> Source: [Customers](Api/Customers.cs)

<details>
<summary><code>Task&lt;AddGroupToCustomerResponse&gt; AddGroupToCustomer(string customerId, string groupId, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Adds a group membership to a customer.

The customer is identified by the `customer_id` value
and the customer group is identified by the `group_id` value.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Customers.AddGroupToCustomer(customerId, groupId);
    // TODO: Handle 'response' of type AddGroupToCustomerResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>customerId</code> | <code>string</code> | The ID of the customer to add to a group. |
| <code>groupId</code> | <code>string</code> | The ID of the customer group to add the customer to. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AddGroupToCustomerResponse](Models/AddGroupToCustomerResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreateCustomerResponse&gt; CreateCustomer(CreateCustomerRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a new customer for a business.

You must provide at least one of the following values in your request to this
endpoint:

- `given_name`
- `family_name`
- `company_name`
- `email_address`
- `phone_number`

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Customers.CreateCustomer(body);
    // TODO: Handle 'response' of type CreateCustomerResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[CreateCustomerRequest](Models/CreateCustomerRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateCustomerResponse](Models/CreateCustomerResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreateCustomerCardResponse&gt; CreateCustomerCard(string customerId, CreateCustomerCardRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Adds a card on file to an existing customer.

As with charges, calls to `CreateCustomerCard` are idempotent. Multiple
calls with the same card nonce return the same card record that was created
with the provided nonce during the _first_ call.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Customers.CreateCustomerCard(customerId, body);
    // TODO: Handle 'response' of type CreateCustomerCardResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>customerId</code> | <code>string</code> | The Square ID of the customer profile the card is linked to. |
| <code>body</code> | <code>[CreateCustomerCardRequest](Models/CreateCustomerCardRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateCustomerCardResponse](Models/CreateCustomerCardResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeleteCustomerResponse&gt; DeleteCustomer(string customerId, long? version, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes a customer profile from a business. This operation also unlinks any associated cards on file. 

As a best practice, you should include the `version` field in the request to enable [optimistic concurrency](https://developer.squareup.com/docs/working-with-apis/optimistic-concurrency) control. The value must be set to the current version of the customer profile. 

To delete a customer profile that was created by merging existing profiles, you must use the ID of the newly created profile.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Customers.DeleteCustomer(customerId, version);
    // TODO: Handle 'response' of type DeleteCustomerResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>customerId</code> | <code>string</code> | The ID of the customer to delete. |
| <code>version</code> | <code>long?</code> | The current version of the customer profile.<br><br>As a best practice, you should include this parameter to enable [optimistic concurrency](https://developer.squareup.com/docs/working-with-apis/optimistic-concurrency) control.  For more information, see [Delete a customer profile](https://developer.squareup.com/docs/customers-api/use-the-api/keep-records#delete-customer-profile). |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeleteCustomerResponse](Models/DeleteCustomerResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeleteCustomerCardResponse&gt; DeleteCustomerCard(string customerId, string cardId, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Removes a card on file from a customer.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Customers.DeleteCustomerCard(customerId, cardId);
    // TODO: Handle 'response' of type DeleteCustomerCardResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>customerId</code> | <code>string</code> | The ID of the customer that the card on file belongs to. |
| <code>cardId</code> | <code>string</code> | The ID of the card on file to delete. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeleteCustomerCardResponse](Models/DeleteCustomerCardResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListCustomersResponse&gt; ListCustomers(string? cursor, int? limit, string? sortField, string? sortOrder, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists customer profiles associated with a Square account.

Under normal operating conditions, newly created or updated customer profiles become available
for the listing operation in well under 30 seconds. Occasionally, propagation of the new or updated
profiles can take closer to one minute or longer, especially during network incidents and outages.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Customers.ListCustomers(cursor, limit, sortField, sortOrder);
    // TODO: Handle 'response' of type ListCustomersResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>cursor</code> | <code>string?</code> | A pagination cursor returned by a previous call to this endpoint.<br>Provide this cursor to retrieve the next set of results for your original query.<br><br>For more information, see [Pagination](https://developer.squareup.com/docs/working-with-apis/pagination). |
| <code>limit</code> | <code>int?</code> | The maximum number of results to return in a single page. This limit is advisory. The response might contain more or fewer results. <br>The limit is ignored if it is less than 1 or greater than 100. The default value is 100.<br><br>For more information, see [Pagination](https://developer.squareup.com/docs/working-with-apis/pagination). |
| <code>sortField</code> | <code>string?</code> | Indicates how customers should be sorted.<br><br>The default value is `DEFAULT`. |
| <code>sortOrder</code> | <code>string?</code> | Indicates whether customers should be sorted in ascending (`ASC`) or<br>descending (`DESC`) order.<br><br>The default value is `ASC`. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListCustomersResponse](Models/ListCustomersResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RemoveGroupFromCustomerResponse&gt; RemoveGroupFromCustomer(string customerId, string groupId, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Removes a group membership from a customer.

The customer is identified by the `customer_id` value
and the customer group is identified by the `group_id` value.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Customers.RemoveGroupFromCustomer(customerId, groupId);
    // TODO: Handle 'response' of type RemoveGroupFromCustomerResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>customerId</code> | <code>string</code> | The ID of the customer to remove from the group. |
| <code>groupId</code> | <code>string</code> | The ID of the customer group to remove the customer from. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RemoveGroupFromCustomerResponse](Models/RemoveGroupFromCustomerResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveCustomerResponse&gt; RetrieveCustomer(string customerId, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns details for a single customer.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Customers.RetrieveCustomer(customerId);
    // TODO: Handle 'response' of type RetrieveCustomerResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>customerId</code> | <code>string</code> | The ID of the customer to retrieve. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveCustomerResponse](Models/RetrieveCustomerResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SearchCustomersResponse&gt; SearchCustomers(SearchCustomersRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Searches the customer profiles associated with a Square account using a supported query filter.

Calling `SearchCustomers` without any explicit query filter returns all
customer profiles ordered alphabetically based on `given_name` and
`family_name`.

Under normal operating conditions, newly created or updated customer profiles become available
for the search operation in well under 30 seconds. Occasionally, propagation of the new or updated
profiles can take closer to one minute or longer, especially during network incidents and outages.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Customers.SearchCustomers(body);
    // TODO: Handle 'response' of type SearchCustomersResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[SearchCustomersRequest](Models/SearchCustomersRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SearchCustomersResponse](Models/SearchCustomersResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpdateCustomerResponse&gt; UpdateCustomer(string customerId, UpdateCustomerRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates a customer profile. To change an attribute, specify the new value. To remove an attribute, specify the value as an empty string or empty object.

As a best practice, you should include the `version` field in the request to enable [optimistic concurrency](https://developer.squareup.com/docs/working-with-apis/optimistic-concurrency) control. The value must be set to the current version of the customer profile.

To update a customer profile that was created by merging existing profiles, you must use the ID of the newly created profile.

You cannot use this endpoint to change cards on file. To make changes, use the [Cards API](https://developer.squareup.com/reference/square_2021-08-18/cards-api) or [Gift Cards API](https://developer.squareup.com/reference/square_2021-08-18/gift-cards-api).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Customers.UpdateCustomer(customerId, body);
    // TODO: Handle 'response' of type UpdateCustomerResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>customerId</code> | <code>string</code> | The ID of the customer to update. |
| <code>body</code> | <code>[UpdateCustomerRequest](Models/UpdateCustomerRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpdateCustomerResponse](Models/UpdateCustomerResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Devices

> Source: [Devices](Api/Devices.cs)

<details>
<summary><code>Task&lt;CreateDeviceCodeResponse&gt; CreateDeviceCode(CreateDeviceCodeRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a DeviceCode that can be used to login to a Square Terminal device to enter the connected
terminal mode.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Devices.CreateDeviceCode(body);
    // TODO: Handle 'response' of type CreateDeviceCodeResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[CreateDeviceCodeRequest](Models/CreateDeviceCodeRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateDeviceCodeResponse](Models/CreateDeviceCodeResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetDeviceCodeResponse&gt; GetDeviceCode(string id, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves DeviceCode with the associated ID.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Devices.GetDeviceCode(id);
    // TODO: Handle 'response' of type GetDeviceCodeResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The unique identifier for the device code. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetDeviceCodeResponse](Models/GetDeviceCodeResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListDeviceCodesResponse&gt; ListDeviceCodes(string? cursor, string? locationId, string? productType, string? status, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists all DeviceCodes associated with the merchant.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Devices.ListDeviceCodes(cursor, locationId, productType, status);
    // TODO: Handle 'response' of type ListDeviceCodesResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>cursor</code> | <code>string?</code> | A pagination cursor returned by a previous call to this endpoint.<br>Provide this to retrieve the next set of results for your original query.<br><br>See [Paginating results](https://developer.squareup.com/docs/working-with-apis/pagination) for more information. |
| <code>locationId</code> | <code>string?</code> | If specified, only returns DeviceCodes of the specified location.<br>Returns DeviceCodes of all locations if empty. |
| <code>productType</code> | <code>string?</code> | If specified, only returns DeviceCodes targeting the specified product type.<br>Returns DeviceCodes of all product types if empty. |
| <code>status</code> | <code>string?</code> | If specified, returns DeviceCodes with the specified statuses.<br>Returns DeviceCodes of status `PAIRED` and `UNPAIRED` if empty. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListDeviceCodesResponse](Models/ListDeviceCodesResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Disputes

> Source: [Disputes](Api/Disputes.cs)

<details>
<summary><code>Task&lt;AcceptDisputeResponse&gt; AcceptDispute(string disputeId, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Accepts the loss on a dispute. Square returns the disputed amount to the cardholder and
updates the dispute state to ACCEPTED.

Square debits the disputed amount from the seller’s Square account. If the Square account
does not have sufficient funds, Square debits the associated bank account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Disputes.AcceptDispute(disputeId);
    // TODO: Handle 'response' of type AcceptDisputeResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>disputeId</code> | <code>string</code> | The ID of the dispute you want to accept. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AcceptDisputeResponse](Models/AcceptDisputeResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreateDisputeEvidenceTextResponse&gt; CreateDisputeEvidenceText(string disputeId, CreateDisputeEvidenceTextRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Uploads text to use as evidence for a dispute challenge.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Disputes.CreateDisputeEvidenceText(disputeId, body);
    // TODO: Handle 'response' of type CreateDisputeEvidenceTextResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>disputeId</code> | <code>string</code> | The ID of the dispute you want to upload evidence for. |
| <code>body</code> | <code>[CreateDisputeEvidenceTextRequest](Models/CreateDisputeEvidenceTextRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateDisputeEvidenceTextResponse](Models/CreateDisputeEvidenceTextResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeleteDisputeEvidenceResponse&gt; DeleteDisputeEvidence(string disputeId, string evidenceId, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Removes specified evidence from a dispute.

Square does not send the bank any evidence that is removed. Also, you cannot remove evidence after
submitting it to the bank using [SubmitEvidence](https://developer.squareup.com/reference/square_2021-08-18/disputes-api/submit-evidence).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Disputes.DeleteDisputeEvidence(disputeId, evidenceId);
    // TODO: Handle 'response' of type DeleteDisputeEvidenceResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>disputeId</code> | <code>string</code> | The ID of the dispute you want to remove evidence from. |
| <code>evidenceId</code> | <code>string</code> | The ID of the evidence you want to remove. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeleteDisputeEvidenceResponse](Models/DeleteDisputeEvidenceResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListDisputeEvidenceResponse&gt; ListDisputeEvidence(string disputeId, string? cursor, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of evidence associated with a dispute.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Disputes.ListDisputeEvidence(disputeId, cursor);
    // TODO: Handle 'response' of type ListDisputeEvidenceResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>disputeId</code> | <code>string</code> | The ID of the dispute. |
| <code>cursor</code> | <code>string?</code> | A pagination cursor returned by a previous call to this endpoint.<br>Provide this cursor to retrieve the next set of results for the original query.<br>For more information, see [Pagination](https://developer.squareup.com/docs/basics/api101/pagination). |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListDisputeEvidenceResponse](Models/ListDisputeEvidenceResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListDisputesResponse&gt; ListDisputes(string? cursor, string? states, string? locationId, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of disputes associated with a particular account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Disputes.ListDisputes(cursor, states, locationId);
    // TODO: Handle 'response' of type ListDisputesResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>cursor</code> | <code>string?</code> | A pagination cursor returned by a previous call to this endpoint.<br>Provide this cursor to retrieve the next set of results for the original query.<br>For more information, see [Pagination](https://developer.squareup.com/docs/basics/api101/pagination). |
| <code>states</code> | <code>string?</code> | The dispute states to filter the result.<br>If not specified, the endpoint returns all open disputes (the dispute status is not `INQUIRY_CLOSED`, `WON`,<br>or `LOST`). |
| <code>locationId</code> | <code>string?</code> | The ID of the location for which to return a list of disputes. If not specified, the endpoint returns<br>all open disputes (the dispute status is not `INQUIRY_CLOSED`, `WON`, or `LOST`) associated with all locations. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListDisputesResponse](Models/ListDisputesResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveDisputeResponse&gt; RetrieveDispute(string disputeId, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns details about a specific dispute.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Disputes.RetrieveDispute(disputeId);
    // TODO: Handle 'response' of type RetrieveDisputeResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>disputeId</code> | <code>string</code> | The ID of the dispute you want more details about. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveDisputeResponse](Models/RetrieveDisputeResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveDisputeEvidenceResponse&gt; RetrieveDisputeEvidence(string disputeId, string evidenceId, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the evidence metadata specified by the evidence ID in the request URL path

You must maintain a copy of the evidence you upload if you want to reference it later. You cannot
download the evidence after you upload it.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Disputes.RetrieveDisputeEvidence(disputeId, evidenceId);
    // TODO: Handle 'response' of type RetrieveDisputeEvidenceResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>disputeId</code> | <code>string</code> | The ID of the dispute that you want to retrieve evidence from. |
| <code>evidenceId</code> | <code>string</code> | The ID of the evidence to retrieve. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveDisputeEvidenceResponse](Models/RetrieveDisputeEvidenceResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SubmitEvidenceResponse&gt; SubmitEvidence(string disputeId, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Submits evidence to the cardholder's bank.

Before submitting evidence, Square compiles all available evidence. This includes evidence uploaded
using the [CreateDisputeEvidenceFile](https://developer.squareup.com/reference/square_2021-08-18/disputes-api/create-dispute-evidence-file) and
[CreateDisputeEvidenceText](https://developer.squareup.com/reference/square_2021-08-18/disputes-api/create-dispute-evidence-text) endpoints and
evidence automatically provided by Square, when available.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Disputes.SubmitEvidence(disputeId);
    // TODO: Handle 'response' of type SubmitEvidenceResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>disputeId</code> | <code>string</code> | The ID of the dispute that you want to submit evidence for. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SubmitEvidenceResponse](Models/SubmitEvidenceResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Employees

> Source: [Employees](Api/Employees.cs)

<details>
<summary><code>Task&lt;ListEmployeesResponse&gt; ListEmployees(string? locationId, string? status, int? limit, string? cursor, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Employees.ListEmployees(locationId, status, limit, cursor);
    // TODO: Handle 'response' of type ListEmployeesResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>locationId</code> | <code>string?</code> | - |
| <code>status</code> | <code>string?</code> | Specifies the EmployeeStatus to filter the employee by. |
| <code>limit</code> | <code>int?</code> | The number of employees to be returned on each page. |
| <code>cursor</code> | <code>string?</code> | The token required to retrieve the specified page of results. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListEmployeesResponse](Models/ListEmployeesResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveEmployeeResponse&gt; RetrieveEmployee(string id, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Employees.RetrieveEmployee(id);
    // TODO: Handle 'response' of type RetrieveEmployeeResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | UUID for the employee that was requested. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveEmployeeResponse](Models/RetrieveEmployeeResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## GiftCardActivities

> Source: [GiftCardActivities](Api/GiftCardActivities.cs)

<details>
<summary><code>Task&lt;CreateGiftCardActivityResponse&gt; CreateGiftCardActivity(CreateGiftCardActivityRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a gift card activity. For more information, see 
[GiftCardActivity](https://developer.squareup.com/docs/gift-cards/using-gift-cards-api#giftcardactivity) and 
[Using activated gift cards](https://developer.squareup.com/docs/gift-cards/using-gift-cards-api#using-activated-gift-cards).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GiftCardActivities.CreateGiftCardActivity(body);
    // TODO: Handle 'response' of type CreateGiftCardActivityResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[CreateGiftCardActivityRequest](Models/CreateGiftCardActivityRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateGiftCardActivityResponse](Models/CreateGiftCardActivityResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListGiftCardActivitiesResponse&gt; ListGiftCardActivities(string? giftCardId, string? type, string? locationId, string? beginTime, string? endTime, int? limit, string? cursor, string? sortOrder, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists gift card activities. By default, you get gift card activities for all
gift cards in the seller's account. You can optionally specify query parameters to
filter the list. For example, you can get a list of gift card activities for a gift card,
for all gift cards in a specific region, or for activities within a time window.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GiftCardActivities.ListGiftCardActivities(giftCardId,
        type,
        locationId,
        beginTime,
        endTime,
        limit,
        cursor,
        sortOrder);
    // TODO: Handle 'response' of type ListGiftCardActivitiesResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>giftCardId</code> | <code>string?</code> | If you provide a gift card ID, the endpoint returns activities that belong <br>to the specified gift card. Otherwise, the endpoint returns all gift card activities for <br>the seller. |
| <code>type</code> | <code>string?</code> | If you provide a type, the endpoint returns gift card activities of this type. <br>Otherwise, the endpoint returns all types of gift card activities. |
| <code>locationId</code> | <code>string?</code> | If you provide a location ID, the endpoint returns gift card activities for that location. <br>Otherwise, the endpoint returns gift card activities for all locations. |
| <code>beginTime</code> | <code>string?</code> | The timestamp for the beginning of the reporting period, in RFC 3339 format.<br>Inclusive. Default: The current time minus one year. |
| <code>endTime</code> | <code>string?</code> | The timestamp for the end of the reporting period, in RFC 3339 format.<br>Inclusive. Default: The current time. |
| <code>limit</code> | <code>int?</code> | If you provide a limit value, the endpoint returns the specified number <br>of results (or less) per page. A maximum value is 100. The default value is 50. |
| <code>cursor</code> | <code>string?</code> | A pagination cursor returned by a previous call to this endpoint.<br>Provide this cursor to retrieve the next set of results for the original query.<br>If you do not provide the cursor, the call returns the first page of the results. |
| <code>sortOrder</code> | <code>string?</code> | The order in which the endpoint returns the activities, based on `created_at`.<br>- `ASC` - Oldest to newest.<br>- `DESC` - Newest to oldest (default). |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListGiftCardActivitiesResponse](Models/ListGiftCardActivitiesResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## GiftCards

> Source: [GiftCards](Api/GiftCards.cs)

<details>
<summary><code>Task&lt;CreateGiftCardResponse&gt; CreateGiftCard(CreateGiftCardRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a digital gift card or registers a physical (plastic) gift card. You must activate the gift card before 
it can be used for payment. For more information, see 
[Selling gift cards](https://developer.squareup.com/docs/gift-cards/using-gift-cards-api#selling-square-gift-cards).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GiftCards.CreateGiftCard(body);
    // TODO: Handle 'response' of type CreateGiftCardResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[CreateGiftCardRequest](Models/CreateGiftCardRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateGiftCardResponse](Models/CreateGiftCardResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;LinkCustomerToGiftCardResponse&gt; LinkCustomerToGiftCard(string giftCardId, LinkCustomerToGiftCardRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Links a customer to a gift card

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GiftCards.LinkCustomerToGiftCard(giftCardId, body);
    // TODO: Handle 'response' of type LinkCustomerToGiftCardResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>giftCardId</code> | <code>string</code> | The ID of the gift card to link. |
| <code>body</code> | <code>[LinkCustomerToGiftCardRequest](Models/LinkCustomerToGiftCardRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[LinkCustomerToGiftCardResponse](Models/LinkCustomerToGiftCardResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListGiftCardsResponse&gt; ListGiftCards(string? type, string? state, int? limit, string? cursor, string? customerId, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists all gift cards. You can specify optional filters to retrieve 
a subset of the gift cards.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GiftCards.ListGiftCards(type, state, limit, cursor, customerId);
    // TODO: Handle 'response' of type ListGiftCardsResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>type</code> | <code>string?</code> | If a type is provided, gift cards of this type are returned <br>(see [GiftCardType](https://developer.squareup.com/reference/square_2021-08-18/enums/GiftCardType)).<br>If no type is provided, it returns gift cards of all types. |
| <code>state</code> | <code>string?</code> | If the state is provided, it returns the gift cards in the specified state <br>(see [GiftCardStatus](https://developer.squareup.com/reference/square_2021-08-18/enums/GiftCardStatus)).<br>Otherwise, it returns the gift cards of all states. |
| <code>limit</code> | <code>int?</code> | If a value is provided, it returns only that number of results per page.<br>The maximum number of results allowed per page is 50. The default value is 30. |
| <code>cursor</code> | <code>string?</code> | A pagination cursor returned by a previous call to this endpoint.<br>Provide this cursor to retrieve the next set of results for the original query.<br>If a cursor is not provided, it returns the first page of the results. <br>For more information, see [Pagination](https://developer.squareup.com/docs/docs/working-with-apis/pagination). |
| <code>customerId</code> | <code>string?</code> | If a value is provided, returns only the gift cards linked to the specified customer |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListGiftCardsResponse](Models/ListGiftCardsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveGiftCardResponse&gt; RetrieveGiftCard(string id, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a gift card using its ID.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GiftCards.RetrieveGiftCard(id);
    // TODO: Handle 'response' of type RetrieveGiftCardResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The ID of the gift card to retrieve. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveGiftCardResponse](Models/RetrieveGiftCardResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveGiftCardFromGanresponse&gt; RetrieveGiftCardFromGan(RetrieveGiftCardFromGanrequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a gift card using the gift card account number (GAN).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GiftCards.RetrieveGiftCardFromGan(body);
    // TODO: Handle 'response' of type RetrieveGiftCardFromGanresponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[RetrieveGiftCardFromGanrequest](Models/RetrieveGiftCardFromGanrequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveGiftCardFromGanresponse](Models/RetrieveGiftCardFromGanresponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveGiftCardFromNonceResponse&gt; RetrieveGiftCardFromNonce(RetrieveGiftCardFromNonceRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a gift card using a nonce (a secure token) that represents the gift card.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GiftCards.RetrieveGiftCardFromNonce(body);
    // TODO: Handle 'response' of type RetrieveGiftCardFromNonceResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[RetrieveGiftCardFromNonceRequest](Models/RetrieveGiftCardFromNonceRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveGiftCardFromNonceResponse](Models/RetrieveGiftCardFromNonceResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UnlinkCustomerFromGiftCardResponse&gt; UnlinkCustomerFromGiftCard(string giftCardId, UnlinkCustomerFromGiftCardRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Unlinks a customer from a gift card

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GiftCards.UnlinkCustomerFromGiftCard(giftCardId, body);
    // TODO: Handle 'response' of type UnlinkCustomerFromGiftCardResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>giftCardId</code> | <code>string</code> | - |
| <code>body</code> | <code>[UnlinkCustomerFromGiftCardRequest](Models/UnlinkCustomerFromGiftCardRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UnlinkCustomerFromGiftCardResponse](Models/UnlinkCustomerFromGiftCardResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Inventory

> Source: [Inventory](Api/Inventory.cs)

<details>
<summary><code>Task&lt;BatchChangeInventoryResponse&gt; BatchChangeInventory(BatchChangeInventoryRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Applies adjustments and counts to the provided item quantities.

On success: returns the current calculated counts for all objects
referenced in the request.
On failure: returns a list of related errors.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Inventory.BatchChangeInventory(body);
    // TODO: Handle 'response' of type BatchChangeInventoryResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[BatchChangeInventoryRequest](Models/BatchChangeInventoryRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BatchChangeInventoryResponse](Models/BatchChangeInventoryResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BatchRetrieveInventoryChangesResponse&gt; BatchRetrieveInventoryChanges(BatchRetrieveInventoryChangesRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns historical physical counts and adjustments based on the
provided filter criteria.

Results are paginated and sorted in ascending order according their
`occurred_at` timestamp (oldest first).

BatchRetrieveInventoryChanges is a catch-all query endpoint for queries
that cannot be handled by other, simpler endpoints.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Inventory.BatchRetrieveInventoryChanges(body);
    // TODO: Handle 'response' of type BatchRetrieveInventoryChangesResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[BatchRetrieveInventoryChangesRequest](Models/BatchRetrieveInventoryChangesRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BatchRetrieveInventoryChangesResponse](Models/BatchRetrieveInventoryChangesResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BatchRetrieveInventoryCountsResponse&gt; BatchRetrieveInventoryCounts(BatchRetrieveInventoryCountsRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns current counts for the provided
[CatalogObject](https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogObject)s at the requested
[Location](https://developer.squareup.com/reference/square_2021-08-18/objects/Location)s.

Results are paginated and sorted in descending order according to their
`calculated_at` timestamp (newest first).

When `updated_after` is specified, only counts that have changed since that
time (based on the server timestamp for the most recent change) are
returned. This allows clients to perform a "sync" operation, for example
in response to receiving a Webhook notification.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Inventory.BatchRetrieveInventoryCounts(body);
    // TODO: Handle 'response' of type BatchRetrieveInventoryCountsResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[BatchRetrieveInventoryCountsRequest](Models/BatchRetrieveInventoryCountsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BatchRetrieveInventoryCountsResponse](Models/BatchRetrieveInventoryCountsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BatchChangeInventoryResponse&gt; DeprecatedBatchChangeInventory(BatchChangeInventoryRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deprecated version of [BatchChangeInventory](https://developer.squareup.com/reference/square_2021-08-18/inventory-api/batch-change-inventory) after the endpoint URL 
is updated to conform to the standard convention.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Inventory.DeprecatedBatchChangeInventory(body);
    // TODO: Handle 'response' of type BatchChangeInventoryResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[BatchChangeInventoryRequest](Models/BatchChangeInventoryRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BatchChangeInventoryResponse](Models/BatchChangeInventoryResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BatchRetrieveInventoryChangesResponse&gt; DeprecatedBatchRetrieveInventoryChanges(BatchRetrieveInventoryChangesRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deprecated version of [BatchRetrieveInventoryChanges](https://developer.squareup.com/reference/square_2021-08-18/inventory-api/batch-retrieve-inventory-changes) after the endpoint URL 
is updated to conform to the standard convention.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Inventory.DeprecatedBatchRetrieveInventoryChanges(body);
    // TODO: Handle 'response' of type BatchRetrieveInventoryChangesResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[BatchRetrieveInventoryChangesRequest](Models/BatchRetrieveInventoryChangesRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BatchRetrieveInventoryChangesResponse](Models/BatchRetrieveInventoryChangesResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BatchRetrieveInventoryCountsResponse&gt; DeprecatedBatchRetrieveInventoryCounts(BatchRetrieveInventoryCountsRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deprecated version of [BatchRetrieveInventoryCounts](https://developer.squareup.com/reference/square_2021-08-18/inventory-api/batch-retrieve-inventory-counts) after the endpoint URL 
is updated to conform to the standard convention.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Inventory.DeprecatedBatchRetrieveInventoryCounts(body);
    // TODO: Handle 'response' of type BatchRetrieveInventoryCountsResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[BatchRetrieveInventoryCountsRequest](Models/BatchRetrieveInventoryCountsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BatchRetrieveInventoryCountsResponse](Models/BatchRetrieveInventoryCountsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveInventoryAdjustmentResponse&gt; DeprecatedRetrieveInventoryAdjustment(string adjustmentId, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deprecated version of [RetrieveInventoryAdjustment](https://developer.squareup.com/reference/square_2021-08-18/inventory-api/retrieve-inventory-adjustment) after the endpoint URL 
is updated to conform to the standard convention.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Inventory.DeprecatedRetrieveInventoryAdjustment(adjustmentId);
    // TODO: Handle 'response' of type RetrieveInventoryAdjustmentResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>adjustmentId</code> | <code>string</code> | ID of the [InventoryAdjustment](https://developer.squareup.com/reference/square_2021-08-18/objects/InventoryAdjustment) to retrieve. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveInventoryAdjustmentResponse](Models/RetrieveInventoryAdjustmentResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveInventoryPhysicalCountResponse&gt; DeprecatedRetrieveInventoryPhysicalCount(string physicalCountId, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deprecated version of [RetrieveInventoryPhysicalCount](https://developer.squareup.com/reference/square_2021-08-18/inventory-api/retrieve-inventory-physical-count) after the endpoint URL 
is updated to conform to the standard convention.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Inventory.DeprecatedRetrieveInventoryPhysicalCount(physicalCountId);
    // TODO: Handle 'response' of type RetrieveInventoryPhysicalCountResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>physicalCountId</code> | <code>string</code> | ID of the<br>[InventoryPhysicalCount](https://developer.squareup.com/reference/square_2021-08-18/objects/InventoryPhysicalCount) to retrieve. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveInventoryPhysicalCountResponse](Models/RetrieveInventoryPhysicalCountResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveInventoryAdjustmentResponse&gt; RetrieveInventoryAdjustment(string adjustmentId, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the [InventoryAdjustment](https://developer.squareup.com/reference/square_2021-08-18/objects/InventoryAdjustment) object
with the provided `adjustment_id`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Inventory.RetrieveInventoryAdjustment(adjustmentId);
    // TODO: Handle 'response' of type RetrieveInventoryAdjustmentResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>adjustmentId</code> | <code>string</code> | ID of the [InventoryAdjustment](https://developer.squareup.com/reference/square_2021-08-18/objects/InventoryAdjustment) to retrieve. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveInventoryAdjustmentResponse](Models/RetrieveInventoryAdjustmentResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveInventoryChangesResponse&gt; RetrieveInventoryChanges(string catalogObjectId, string? locationIds, string? cursor, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a set of physical counts and inventory adjustments for the
provided [CatalogObject](https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogObject) at the requested
[Location](https://developer.squareup.com/reference/square_2021-08-18/objects/Location)s. 

You can achieve the same result by calling [BatchRetrieveInventoryChanges](https://developer.squareup.com/reference/square_2021-08-18/inventory-api/batch-retrieve-inventory-changes) 
and having the `catalog_object_ids` list contain a single element of the `CatalogObject` ID.

Results are paginated and sorted in descending order according to their
`occurred_at` timestamp (newest first).

There are no limits on how far back the caller can page. This endpoint can be 
used to display recent changes for a specific item. For more
sophisticated queries, use a batch endpoint.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Inventory.RetrieveInventoryChanges(catalogObjectId, locationIds, cursor);
    // TODO: Handle 'response' of type RetrieveInventoryChangesResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>catalogObjectId</code> | <code>string</code> | ID of the [CatalogObject](https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogObject) to retrieve. |
| <code>locationIds</code> | <code>string?</code> | The [Location](https://developer.squareup.com/reference/square_2021-08-18/objects/Location) IDs to look up as a comma-separated<br>list. An empty list queries all locations. |
| <code>cursor</code> | <code>string?</code> | A pagination cursor returned by a previous call to this endpoint.<br>Provide this to retrieve the next set of results for the original query.<br><br>See the [Pagination](https://developer.squareup.com/docs/working-with-apis/pagination) guide for more information. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveInventoryChangesResponse](Models/RetrieveInventoryChangesResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveInventoryCountResponse&gt; RetrieveInventoryCount(string catalogObjectId, string? locationIds, string? cursor, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves the current calculated stock count for a given
[CatalogObject](https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogObject) at a given set of
[Location](https://developer.squareup.com/reference/square_2021-08-18/objects/Location)s. Responses are paginated and unsorted.
For more sophisticated queries, use a batch endpoint.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Inventory.RetrieveInventoryCount(catalogObjectId, locationIds, cursor);
    // TODO: Handle 'response' of type RetrieveInventoryCountResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>catalogObjectId</code> | <code>string</code> | ID of the [CatalogObject](https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogObject) to retrieve. |
| <code>locationIds</code> | <code>string?</code> | The [Location](https://developer.squareup.com/reference/square_2021-08-18/objects/Location) IDs to look up as a comma-separated<br>list. An empty list queries all locations. |
| <code>cursor</code> | <code>string?</code> | A pagination cursor returned by a previous call to this endpoint.<br>Provide this to retrieve the next set of results for the original query.<br><br>See the [Pagination](https://developer.squareup.com/docs/working-with-apis/pagination) guide for more information. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveInventoryCountResponse](Models/RetrieveInventoryCountResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveInventoryPhysicalCountResponse&gt; RetrieveInventoryPhysicalCount(string physicalCountId, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the [InventoryPhysicalCount](https://developer.squareup.com/reference/square_2021-08-18/objects/InventoryPhysicalCount)
object with the provided `physical_count_id`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Inventory.RetrieveInventoryPhysicalCount(physicalCountId);
    // TODO: Handle 'response' of type RetrieveInventoryPhysicalCountResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>physicalCountId</code> | <code>string</code> | ID of the<br>[InventoryPhysicalCount](https://developer.squareup.com/reference/square_2021-08-18/objects/InventoryPhysicalCount) to retrieve. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveInventoryPhysicalCountResponse](Models/RetrieveInventoryPhysicalCountResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveInventoryTransferResponse&gt; RetrieveInventoryTransfer(string transferId, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the [InventoryTransfer](https://developer.squareup.com/reference/square_2021-08-18/objects/InventoryTransfer) object
with the provided `transfer_id`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Inventory.RetrieveInventoryTransfer(transferId);
    // TODO: Handle 'response' of type RetrieveInventoryTransferResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>transferId</code> | <code>string</code> | ID of the [InventoryTransfer](https://developer.squareup.com/reference/square_2021-08-18/objects/InventoryTransfer) to retrieve. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveInventoryTransferResponse](Models/RetrieveInventoryTransferResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Invoices

> Source: [Invoices](Api/Invoices.cs)

<details>
<summary><code>Task&lt;CancelInvoiceResponse&gt; CancelInvoice(string invoiceId, CancelInvoiceRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Cancels an invoice. The seller cannot collect payments for 
the canceled invoice.

You cannot cancel an invoice in the `DRAFT` state or in a terminal state: `PAID`, `REFUNDED`, `CANCELED`, or `FAILED`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Invoices.CancelInvoice(invoiceId, body);
    // TODO: Handle 'response' of type CancelInvoiceResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>invoiceId</code> | <code>string</code> | The ID of the [invoice](https://developer.squareup.com/reference/square_2021-08-18/objects/Invoice) to cancel. |
| <code>body</code> | <code>[CancelInvoiceRequest](Models/CancelInvoiceRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CancelInvoiceResponse](Models/CancelInvoiceResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreateInvoiceResponse&gt; CreateInvoice(CreateInvoiceRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a draft [invoice](https://developer.squareup.com/reference/square_2021-08-18/objects/Invoice) 
for an order created using the Orders API.

A draft invoice remains in your account and no action is taken. 
You must publish the invoice before Square can process it (send it to the customer's email address or charge the customer’s card on file).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Invoices.CreateInvoice(body);
    // TODO: Handle 'response' of type CreateInvoiceResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[CreateInvoiceRequest](Models/CreateInvoiceRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateInvoiceResponse](Models/CreateInvoiceResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeleteInvoiceResponse&gt; DeleteInvoice(string invoiceId, int? version, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes the specified invoice. When an invoice is deleted, the 
associated order status changes to CANCELED. You can only delete a draft 
invoice (you cannot delete a published invoice, including one that is scheduled for processing).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Invoices.DeleteInvoice(invoiceId, version);
    // TODO: Handle 'response' of type DeleteInvoiceResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>invoiceId</code> | <code>string</code> | The ID of the invoice to delete. |
| <code>version</code> | <code>int?</code> | The version of the [invoice](https://developer.squareup.com/reference/square_2021-08-18/objects/Invoice) to delete.<br>If you do not know the version, you can call [GetInvoice](https://developer.squareup.com/reference/square_2021-08-18/invoices-api/get-invoice) or <br>[ListInvoices](https://developer.squareup.com/reference/square_2021-08-18/invoices-api/list-invoices). |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeleteInvoiceResponse](Models/DeleteInvoiceResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetInvoiceResponse&gt; GetInvoice(string invoiceId, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves an invoice by invoice ID.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Invoices.GetInvoice(invoiceId);
    // TODO: Handle 'response' of type GetInvoiceResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>invoiceId</code> | <code>string</code> | The ID of the invoice to retrieve. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetInvoiceResponse](Models/GetInvoiceResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListInvoicesResponse&gt; ListInvoices(string locationId, string? cursor, int? limit, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of invoices for a given location. The response 
is paginated. If truncated, the response includes a `cursor` that you    
use in a subsequent request to retrieve the next set of invoices.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Invoices.ListInvoices(locationId, cursor, limit);
    // TODO: Handle 'response' of type ListInvoicesResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>locationId</code> | <code>string</code> | The ID of the location for which to list invoices. |
| <code>cursor</code> | <code>string?</code> | A pagination cursor returned by a previous call to this endpoint. <br>Provide this cursor to retrieve the next set of results for your original query.<br><br>For more information, see [Pagination](https://developer.squareup.com/docs/working-with-apis/pagination). |
| <code>limit</code> | <code>int?</code> | The maximum number of invoices to return (200 is the maximum `limit`). <br>If not provided, the server uses a default limit of 100 invoices. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListInvoicesResponse](Models/ListInvoicesResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PublishInvoiceResponse&gt; PublishInvoice(string invoiceId, PublishInvoiceRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Publishes the specified draft invoice. 

After an invoice is published, Square 
follows up based on the invoice configuration. For example, Square 
sends the invoice to the customer's email address, charges the customer's card on file, or does 
nothing. Square also makes the invoice available on a Square-hosted invoice page. 

The invoice `status` also changes from `DRAFT` to a status 
based on the invoice configuration. For example, the status changes to `UNPAID` if 
Square emails the invoice or `PARTIALLY_PAID` if Square charge a card on file for a portion of the 
invoice amount.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Invoices.PublishInvoice(invoiceId, body);
    // TODO: Handle 'response' of type PublishInvoiceResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>invoiceId</code> | <code>string</code> | The ID of the invoice to publish. |
| <code>body</code> | <code>[PublishInvoiceRequest](Models/PublishInvoiceRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PublishInvoiceResponse](Models/PublishInvoiceResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SearchInvoicesResponse&gt; SearchInvoices(SearchInvoicesRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Searches for invoices from a location specified in 
the filter. You can optionally specify customers in the filter for whom to 
retrieve invoices. In the current implementation, you can only specify one location and 
optionally one customer.

The response is paginated. If truncated, the response includes a `cursor` 
that you use in a subsequent request to retrieve the next set of invoices.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Invoices.SearchInvoices(body);
    // TODO: Handle 'response' of type SearchInvoicesResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[SearchInvoicesRequest](Models/SearchInvoicesRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SearchInvoicesResponse](Models/SearchInvoicesResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpdateInvoiceResponse&gt; UpdateInvoice(string invoiceId, UpdateInvoiceRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates an invoice by modifying fields, clearing fields, or both. For most updates, you can use a sparse 
`Invoice` object to add fields or change values and use the `fields_to_clear` field to specify fields to clear. 
However, some restrictions apply. For example, you cannot change the `order_id` or `location_id` field and you 
must provide the complete `custom_fields` list to update a custom field. Published invoices have additional restrictions.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Invoices.UpdateInvoice(invoiceId, body);
    // TODO: Handle 'response' of type UpdateInvoiceResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>invoiceId</code> | <code>string</code> | The ID of the invoice to update. |
| <code>body</code> | <code>[UpdateInvoiceRequest](Models/UpdateInvoiceRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpdateInvoiceResponse](Models/UpdateInvoiceResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Labor

> Source: [Labor](Api/Labor.cs)

<details>
<summary><code>Task&lt;CreateBreakTypeResponse&gt; CreateBreakType(CreateBreakTypeRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a new `BreakType`.

A `BreakType` is a template for creating `Break` objects.
You must provide the following values in your request to this
endpoint:

- `location_id`
- `break_name`
- `expected_duration`
- `is_paid`

You can only have three `BreakType` instances per location. If you attempt to add a fourth
`BreakType` for a location, an `INVALID_REQUEST_ERROR` "Exceeded limit of 3 breaks per location."
is returned.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Labor.CreateBreakType(body);
    // TODO: Handle 'response' of type CreateBreakTypeResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[CreateBreakTypeRequest](Models/CreateBreakTypeRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateBreakTypeResponse](Models/CreateBreakTypeResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreateShiftResponse&gt; CreateShift(CreateShiftRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a new `Shift`.

A `Shift` represents a complete workday for a single employee.
You must provide the following values in your request to this
endpoint:

- `location_id`
- `employee_id`
- `start_at`

An attempt to create a new `Shift` can result in a `BAD_REQUEST` error when:
- The `status` of the new `Shift` is `OPEN` and the employee has another
shift with an `OPEN` status.
- The `start_at` date is in the future.
- The `start_at` or `end_at` date overlaps another shift for the same employee.
- The `Break` instances are set in the request and a break `start_at`
is before the `Shift.start_at`, a break `end_at` is after
the `Shift.end_at`, or both.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Labor.CreateShift(body);
    // TODO: Handle 'response' of type CreateShiftResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[CreateShiftRequest](Models/CreateShiftRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateShiftResponse](Models/CreateShiftResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeleteBreakTypeResponse&gt; DeleteBreakType(string id, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes an existing `BreakType`.

A `BreakType` can be deleted even if it is referenced from a `Shift`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Labor.DeleteBreakType(id);
    // TODO: Handle 'response' of type DeleteBreakTypeResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The UUID for the `BreakType` being deleted. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeleteBreakTypeResponse](Models/DeleteBreakTypeResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeleteShiftResponse&gt; DeleteShift(string id, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes a `Shift`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Labor.DeleteShift(id);
    // TODO: Handle 'response' of type DeleteShiftResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The UUID for the `Shift` being deleted. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeleteShiftResponse](Models/DeleteShiftResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetBreakTypeResponse&gt; GetBreakType(string id, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a single `BreakType` specified by `id`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Labor.GetBreakType(id);
    // TODO: Handle 'response' of type GetBreakTypeResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The UUID for the `BreakType` being retrieved. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetBreakTypeResponse](Models/GetBreakTypeResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetEmployeeWageResponse&gt; GetEmployeeWage(string id, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a single `EmployeeWage` specified by `id`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Labor.GetEmployeeWage(id);
    // TODO: Handle 'response' of type GetEmployeeWageResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The UUID for the `EmployeeWage` being retrieved. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetEmployeeWageResponse](Models/GetEmployeeWageResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetShiftResponse&gt; GetShift(string id, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a single `Shift` specified by `id`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Labor.GetShift(id);
    // TODO: Handle 'response' of type GetShiftResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The UUID for the `Shift` being retrieved. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetShiftResponse](Models/GetShiftResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetTeamMemberWageResponse&gt; GetTeamMemberWage(string id, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a single `TeamMemberWage` specified by `id `.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Labor.GetTeamMemberWage(id);
    // TODO: Handle 'response' of type GetTeamMemberWageResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The UUID for the `TeamMemberWage` being retrieved. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetTeamMemberWageResponse](Models/GetTeamMemberWageResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListBreakTypesResponse&gt; ListBreakTypes(string? locationId, int? limit, string? cursor, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a paginated list of `BreakType` instances for a business.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Labor.ListBreakTypes(locationId, limit, cursor);
    // TODO: Handle 'response' of type ListBreakTypesResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>locationId</code> | <code>string?</code> | Filter the returned `BreakType` results to only those that are associated with the<br>specified location. |
| <code>limit</code> | <code>int?</code> | The maximum number of `BreakType` results to return per page. The number can range between 1<br>and 200. The default is 200. |
| <code>cursor</code> | <code>string?</code> | A pointer to the next page of `BreakType` results to fetch. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListBreakTypesResponse](Models/ListBreakTypesResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListEmployeeWagesResponse&gt; ListEmployeeWages(string? employeeId, int? limit, string? cursor, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a paginated list of `EmployeeWage` instances for a business.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Labor.ListEmployeeWages(employeeId, limit, cursor);
    // TODO: Handle 'response' of type ListEmployeeWagesResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>employeeId</code> | <code>string?</code> | Filter the returned wages to only those that are associated with the specified employee. |
| <code>limit</code> | <code>int?</code> | The maximum number of `EmployeeWage` results to return per page. The number can range between<br>1 and 200. The default is 200. |
| <code>cursor</code> | <code>string?</code> | A pointer to the next page of `EmployeeWage` results to fetch. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListEmployeeWagesResponse](Models/ListEmployeeWagesResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListTeamMemberWagesResponse&gt; ListTeamMemberWages(string? teamMemberId, int? limit, string? cursor, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a paginated list of `TeamMemberWage` instances for a business.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Labor.ListTeamMemberWages(teamMemberId, limit, cursor);
    // TODO: Handle 'response' of type ListTeamMemberWagesResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>teamMemberId</code> | <code>string?</code> | Filter the returned wages to only those that are associated with the<br>specified team member. |
| <code>limit</code> | <code>int?</code> | The maximum number of `TeamMemberWage` results to return per page. The number can range between<br>1 and 200. The default is 200. |
| <code>cursor</code> | <code>string?</code> | A pointer to the next page of `EmployeeWage` results to fetch. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListTeamMemberWagesResponse](Models/ListTeamMemberWagesResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListWorkweekConfigsResponse&gt; ListWorkweekConfigs(int? limit, string? cursor, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of `WorkweekConfig` instances for a business.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Labor.ListWorkweekConfigs(limit, cursor);
    // TODO: Handle 'response' of type ListWorkweekConfigsResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>limit</code> | <code>int?</code> | The maximum number of `WorkweekConfigs` results to return per page. |
| <code>cursor</code> | <code>string?</code> | A pointer to the next page of `WorkweekConfig` results to fetch. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListWorkweekConfigsResponse](Models/ListWorkweekConfigsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SearchShiftsResponse&gt; SearchShifts(SearchShiftsRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a paginated list of `Shift` records for a business.
The list to be returned can be filtered by:
- Location IDs.
- Employee IDs.
- Shift status (`OPEN` and `CLOSED`).
- Shift start.
- Shift end.
- Workday details.

The list can be sorted by:
- `start_at`.
- `end_at`.
- `created_at`.
- `updated_at`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Labor.SearchShifts(body);
    // TODO: Handle 'response' of type SearchShiftsResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[SearchShiftsRequest](Models/SearchShiftsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SearchShiftsResponse](Models/SearchShiftsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpdateBreakTypeResponse&gt; UpdateBreakType(string id, UpdateBreakTypeRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates an existing `BreakType`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Labor.UpdateBreakType(id, body);
    // TODO: Handle 'response' of type UpdateBreakTypeResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The UUID for the `BreakType` being updated. |
| <code>body</code> | <code>[UpdateBreakTypeRequest](Models/UpdateBreakTypeRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpdateBreakTypeResponse](Models/UpdateBreakTypeResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpdateShiftResponse&gt; UpdateShift(string id, UpdateShiftRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates an existing `Shift`.

When adding a `Break` to a `Shift`, any earlier `Break` instances in the `Shift` have
the `end_at` property set to a valid RFC-3339 datetime string.

When closing a `Shift`, all `Break` instances in the `Shift` must be complete with `end_at`
set on each `Break`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Labor.UpdateShift(id, body);
    // TODO: Handle 'response' of type UpdateShiftResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The ID of the object being updated. |
| <code>body</code> | <code>[UpdateShiftRequest](Models/UpdateShiftRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpdateShiftResponse](Models/UpdateShiftResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpdateWorkweekConfigResponse&gt; UpdateWorkweekConfig(string id, UpdateWorkweekConfigRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates a `WorkweekConfig`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Labor.UpdateWorkweekConfig(id, body);
    // TODO: Handle 'response' of type UpdateWorkweekConfigResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The UUID for the `WorkweekConfig` object being updated. |
| <code>body</code> | <code>[UpdateWorkweekConfigRequest](Models/UpdateWorkweekConfigRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpdateWorkweekConfigResponse](Models/UpdateWorkweekConfigResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Locations

> Source: [Locations](Api/Locations.cs)

<details>
<summary><code>Task&lt;CreateLocationResponse&gt; CreateLocation(CreateLocationRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a location.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Locations.CreateLocation(body);
    // TODO: Handle 'response' of type CreateLocationResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[CreateLocationRequest](Models/CreateLocationRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateLocationResponse](Models/CreateLocationResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListLocationsResponse&gt; ListLocations(CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Provides information of all locations of a business.

Many Square API endpoints require a `location_id` parameter.
The `id` field of the [`Location`](https://developer.squareup.com/reference/square_2021-08-18/objects/Location) objects returned by this
endpoint correspond to that `location_id` parameter.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Locations.ListLocations();
    // TODO: Handle 'response' of type ListLocationsResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListLocationsResponse](Models/ListLocationsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveLocationResponse&gt; RetrieveLocation(string locationId, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves details of a location. You can specify "main" 
as the location ID to retrieve details of the 
main location.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Locations.RetrieveLocation(locationId);
    // TODO: Handle 'response' of type RetrieveLocationResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>locationId</code> | <code>string</code> | The ID of the location to retrieve. If you specify the string "main",<br>then the endpoint returns the main location. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveLocationResponse](Models/RetrieveLocationResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpdateLocationResponse&gt; UpdateLocation(string locationId, UpdateLocationRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates a location.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Locations.UpdateLocation(locationId, body);
    // TODO: Handle 'response' of type UpdateLocationResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>locationId</code> | <code>string</code> | The ID of the location to update. |
| <code>body</code> | <code>[UpdateLocationRequest](Models/UpdateLocationRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpdateLocationResponse](Models/UpdateLocationResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Loyalty

> Source: [Loyalty](Api/Loyalty.cs)

<details>
<summary><code>Task&lt;AccumulateLoyaltyPointsResponse&gt; AccumulateLoyaltyPoints(string accountId, AccumulateLoyaltyPointsRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Adds points to a loyalty account.

- If you are using the Orders API to manage orders, you only provide the `order_id`. 
The endpoint reads the order to compute points to add to the buyer's account.
- If you are not using the Orders API to manage orders, 
you first perform a client-side computation to compute the points.  
For spend-based and visit-based programs, you can first call 
[CalculateLoyaltyPoints](https://developer.squareup.com/reference/square_2021-08-18/loyalty-api/calculate-loyalty-points) to compute the points  
that you provide to this endpoint. 

__Note:__ The country of the seller's Square account determines whether tax is included in the purchase amount when accruing points for spend-based and visit-based programs. 
For more information, see [Availability of Square Loyalty](https://developer.squareup.com/docs/loyalty-api/overview#loyalty-market-availability).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Loyalty.AccumulateLoyaltyPoints(accountId, body);
    // TODO: Handle 'response' of type AccumulateLoyaltyPointsResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>accountId</code> | <code>string</code> | The [loyalty account](https://developer.squareup.com/reference/square_2021-08-18/objects/LoyaltyAccount) ID to which to add the points. |
| <code>body</code> | <code>[AccumulateLoyaltyPointsRequest](Models/AccumulateLoyaltyPointsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AccumulateLoyaltyPointsResponse](Models/AccumulateLoyaltyPointsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdjustLoyaltyPointsResponse&gt; AdjustLoyaltyPoints(string accountId, AdjustLoyaltyPointsRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Adds points to or subtracts points from a buyer's account. 

Use this endpoint only when you need to manually adjust points. Otherwise, in your application flow, you call 
[AccumulateLoyaltyPoints](https://developer.squareup.com/reference/square_2021-08-18/loyalty-api/accumulate-loyalty-points) 
to add points when a buyer pays for the purchase.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Loyalty.AdjustLoyaltyPoints(accountId, body);
    // TODO: Handle 'response' of type AdjustLoyaltyPointsResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>accountId</code> | <code>string</code> | The ID of the [loyalty account](https://developer.squareup.com/reference/square_2021-08-18/objects/LoyaltyAccount) in which to adjust the points. |
| <code>body</code> | <code>[AdjustLoyaltyPointsRequest](Models/AdjustLoyaltyPointsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdjustLoyaltyPointsResponse](Models/AdjustLoyaltyPointsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CalculateLoyaltyPointsResponse&gt; CalculateLoyaltyPoints(string programId, CalculateLoyaltyPointsRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Calculates the points a purchase earns.

- If you are using the Orders API to manage orders, you provide `order_id` in the request. The 
endpoint calculates the points by reading the order.
- If you are not using the Orders API to manage orders, you provide the purchase amount in 
the request for the endpoint to calculate the points.

An application might call this endpoint to show the points that a buyer can earn with the 
specific purchase.

__Note:__ The country of the seller's Square account determines whether tax is included in the purchase amount when accruing points for spend-based and visit-based programs. 
For more information, see [Availability of Square Loyalty](https://developer.squareup.com/docs/loyalty-api/overview#loyalty-market-availability).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Loyalty.CalculateLoyaltyPoints(programId, body);
    // TODO: Handle 'response' of type CalculateLoyaltyPointsResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>programId</code> | <code>string</code> | The [loyalty program](https://developer.squareup.com/reference/square_2021-08-18/objects/LoyaltyProgram) ID, which defines the rules for accruing points. |
| <code>body</code> | <code>[CalculateLoyaltyPointsRequest](Models/CalculateLoyaltyPointsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CalculateLoyaltyPointsResponse](Models/CalculateLoyaltyPointsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreateLoyaltyAccountResponse&gt; CreateLoyaltyAccount(CreateLoyaltyAccountRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a loyalty account. To create a loyalty account, you must provide the `program_id` and a `mapping` with the `phone_number` of the buyer.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Loyalty.CreateLoyaltyAccount(body);
    // TODO: Handle 'response' of type CreateLoyaltyAccountResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[CreateLoyaltyAccountRequest](Models/CreateLoyaltyAccountRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateLoyaltyAccountResponse](Models/CreateLoyaltyAccountResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreateLoyaltyRewardResponse&gt; CreateLoyaltyReward(CreateLoyaltyRewardRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a loyalty reward. In the process, the endpoint does following:

- Uses the `reward_tier_id` in the request to determine the number of points 
to lock for this reward. 
- If the request includes `order_id`, it adds the reward and related discount to the order. 

After a reward is created, the points are locked and 
not available for the buyer to redeem another reward.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Loyalty.CreateLoyaltyReward(body);
    // TODO: Handle 'response' of type CreateLoyaltyRewardResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[CreateLoyaltyRewardRequest](Models/CreateLoyaltyRewardRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateLoyaltyRewardResponse](Models/CreateLoyaltyRewardResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeleteLoyaltyRewardResponse&gt; DeleteLoyaltyReward(string rewardId, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes a loyalty reward by doing the following:

- Returns the loyalty points back to the loyalty account.
- If an order ID was specified when the reward was created 
(see [CreateLoyaltyReward](https://developer.squareup.com/reference/square_2021-08-18/loyalty-api/create-loyalty-reward)), 
it updates the order by removing the reward and related 
discounts.

You cannot delete a reward that has reached the terminal state (REDEEMED).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Loyalty.DeleteLoyaltyReward(rewardId);
    // TODO: Handle 'response' of type DeleteLoyaltyRewardResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>rewardId</code> | <code>string</code> | The ID of the [loyalty reward](https://developer.squareup.com/reference/square_2021-08-18/objects/LoyaltyReward) to delete. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeleteLoyaltyRewardResponse](Models/DeleteLoyaltyRewardResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListLoyaltyProgramsResponse&gt; ListLoyaltyPrograms(CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of loyalty programs in the seller's account.
Loyalty programs define how buyers can earn points and redeem points for rewards. Square sellers can have only one loyalty program, which is created and managed from the Seller Dashboard. For more information, see [Loyalty Program Overview](https://developer.squareup.com/docs/loyalty/overview).


Replaced with [RetrieveLoyaltyProgram](https://developer.squareup.com/reference/square_2021-08-18/loyalty-api/retrieve-loyalty-program) when used with the keyword `main`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Loyalty.ListLoyaltyPrograms();
    // TODO: Handle 'response' of type ListLoyaltyProgramsResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListLoyaltyProgramsResponse](Models/ListLoyaltyProgramsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RedeemLoyaltyRewardResponse&gt; RedeemLoyaltyReward(string rewardId, RedeemLoyaltyRewardRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Redeems a loyalty reward.

The endpoint sets the reward to the `REDEEMED` terminal state. 

If you are using your own order processing system (not using the 
Orders API), you call this endpoint after the buyer paid for the 
purchase.

After the reward reaches the terminal state, it cannot be deleted. 
In other words, points used for the reward cannot be returned 
to the account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Loyalty.RedeemLoyaltyReward(rewardId, body);
    // TODO: Handle 'response' of type RedeemLoyaltyRewardResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>rewardId</code> | <code>string</code> | The ID of the [loyalty reward](https://developer.squareup.com/reference/square_2021-08-18/objects/LoyaltyReward) to redeem. |
| <code>body</code> | <code>[RedeemLoyaltyRewardRequest](Models/RedeemLoyaltyRewardRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RedeemLoyaltyRewardResponse](Models/RedeemLoyaltyRewardResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveLoyaltyAccountResponse&gt; RetrieveLoyaltyAccount(string accountId, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a loyalty account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Loyalty.RetrieveLoyaltyAccount(accountId);
    // TODO: Handle 'response' of type RetrieveLoyaltyAccountResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>accountId</code> | <code>string</code> | The ID of the [loyalty account](https://developer.squareup.com/reference/square_2021-08-18/objects/LoyaltyAccount) to retrieve. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveLoyaltyAccountResponse](Models/RetrieveLoyaltyAccountResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveLoyaltyProgramResponse&gt; RetrieveLoyaltyProgram(string programId, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves the loyalty program in a seller's account, specified by the program ID or the keyword `main`. 

Loyalty programs define how buyers can earn points and redeem points for rewards. Square sellers can have only one loyalty program, which is created and managed from the Seller Dashboard. For more information, see [Loyalty Program Overview](https://developer.squareup.com/docs/loyalty/overview).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Loyalty.RetrieveLoyaltyProgram(programId);
    // TODO: Handle 'response' of type RetrieveLoyaltyProgramResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>programId</code> | <code>string</code> | The ID of the loyalty program or the keyword `main`. Either value can be used to retrieve the single loyalty program that belongs to the seller. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveLoyaltyProgramResponse](Models/RetrieveLoyaltyProgramResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveLoyaltyRewardResponse&gt; RetrieveLoyaltyReward(string rewardId, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a loyalty reward.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Loyalty.RetrieveLoyaltyReward(rewardId);
    // TODO: Handle 'response' of type RetrieveLoyaltyRewardResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>rewardId</code> | <code>string</code> | The ID of the [loyalty reward](https://developer.squareup.com/reference/square_2021-08-18/objects/LoyaltyReward) to retrieve. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveLoyaltyRewardResponse](Models/RetrieveLoyaltyRewardResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SearchLoyaltyAccountsResponse&gt; SearchLoyaltyAccounts(SearchLoyaltyAccountsRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Searches for loyalty accounts in a loyalty program.  

You can search for a loyalty account using the phone number or customer ID associated with the account. To return all loyalty accounts, specify an empty `query` object or omit it entirely.  

Search results are sorted by `created_at` in ascending order.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Loyalty.SearchLoyaltyAccounts(body);
    // TODO: Handle 'response' of type SearchLoyaltyAccountsResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[SearchLoyaltyAccountsRequest](Models/SearchLoyaltyAccountsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SearchLoyaltyAccountsResponse](Models/SearchLoyaltyAccountsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SearchLoyaltyEventsResponse&gt; SearchLoyaltyEvents(SearchLoyaltyEventsRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Searches for loyalty events.

A Square loyalty program maintains a ledger of events that occur during the lifetime of a 
buyer's loyalty account. Each change in the point balance 
(for example, points earned, points redeemed, and points expired) is 
recorded in the ledger. Using this endpoint, you can search the ledger for events.

Search results are sorted by `created_at` in descending order.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Loyalty.SearchLoyaltyEvents(body);
    // TODO: Handle 'response' of type SearchLoyaltyEventsResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[SearchLoyaltyEventsRequest](Models/SearchLoyaltyEventsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SearchLoyaltyEventsResponse](Models/SearchLoyaltyEventsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SearchLoyaltyRewardsResponse&gt; SearchLoyaltyRewards(SearchLoyaltyRewardsRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Searches for loyalty rewards in a loyalty account. 

In the current implementation, the endpoint supports search by the reward `status`.

If you know a reward ID, use the 
[RetrieveLoyaltyReward](https://developer.squareup.com/reference/square_2021-08-18/loyalty-api/retrieve-loyalty-reward) endpoint.

Search results are sorted by `updated_at` in descending order.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Loyalty.SearchLoyaltyRewards(body);
    // TODO: Handle 'response' of type SearchLoyaltyRewardsResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[SearchLoyaltyRewardsRequest](Models/SearchLoyaltyRewardsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SearchLoyaltyRewardsResponse](Models/SearchLoyaltyRewardsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Merchants

> Source: [Merchants](Api/Merchants.cs)

<details>
<summary><code>Task&lt;ListMerchantsResponse&gt; ListMerchants(int? cursor, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns `Merchant` information for a given access token.

If you don't know a `Merchant` ID, you can use this endpoint to retrieve the merchant ID for an access token.
You can specify your personal access token to get your own merchant information or specify an OAuth token
to get the information for the  merchant that granted you access.

If you know the merchant ID, you can also use the [RetrieveMerchant](https://developer.squareup.com/reference/square_2021-08-18/merchants-api/retrieve-merchant)
endpoint to get the merchant information.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Merchants.ListMerchants(cursor);
    // TODO: Handle 'response' of type ListMerchantsResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>cursor</code> | <code>int?</code> | The cursor generated by the previous response. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListMerchantsResponse](Models/ListMerchantsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveMerchantResponse&gt; RetrieveMerchant(string merchantId, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve a `Merchant` object for the given `merchant_id`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Merchants.RetrieveMerchant(merchantId);
    // TODO: Handle 'response' of type RetrieveMerchantResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>merchantId</code> | <code>string</code> | The ID of the merchant to retrieve. If the string "me" is supplied as the ID,<br>then retrieve the merchant that is currently accessible to this call. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveMerchantResponse](Models/RetrieveMerchantResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## MobileAuthorization

> Source: [MobileAuthorization](Api/MobileAuthorization.cs)

<details>
<summary><code>Task&lt;CreateMobileAuthorizationCodeResponse&gt; CreateMobileAuthorizationCode(CreateMobileAuthorizationCodeRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Generates code to authorize a mobile application to connect to a Square card reader

Authorization codes are one-time-use and expire __60 minutes__ after being issued.

__Important:__ The `Authorization` header you provide to this endpoint must have the following format:

```
Authorization: Bearer ACCESS_TOKEN
```

Replace `ACCESS_TOKEN` with a
[valid production authorization credential](https://developer.squareup.com/docs/build-basics/access-tokens).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.MobileAuthorization.CreateMobileAuthorizationCode(body);
    // TODO: Handle 'response' of type CreateMobileAuthorizationCodeResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[CreateMobileAuthorizationCodeRequest](Models/CreateMobileAuthorizationCodeRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateMobileAuthorizationCodeResponse](Models/CreateMobileAuthorizationCodeResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Oauth

> Source: [Oauth](Api/Oauth.cs)

<details>
<summary><code>Task&lt;ObtainTokenResponse&gt; ObtainToken(ObtainTokenRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns an OAuth access token.

The endpoint supports distinct methods of obtaining OAuth access tokens.
Applications specify a method by adding the `grant_type` parameter
in the request and also provide relevant information.

__Note:__ Regardless of the method application specified,
the endpoint always returns two items; an OAuth access token and
a refresh token in the response.

__OAuth tokens should only live on secure servers. Application clients
should never interact directly with OAuth tokens__.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Oauth.ObtainToken(body);
    // TODO: Handle 'response' of type ObtainTokenResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[ObtainTokenRequest](Models/ObtainTokenRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ObtainTokenResponse](Models/ObtainTokenResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RenewTokenResponse&gt; RenewToken(string clientId, RenewTokenRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

`RenewToken` is deprecated. For information about refreshing OAuth access tokens, see
[Migrate from Renew to Refresh OAuth Tokens](https://developer.squareup.com/docs/oauth-api/migrate-to-refresh-tokens).


Renews an OAuth access token before it expires.

OAuth access tokens besides your application's personal access token expire after __30 days__.
You can also renew expired tokens within __15 days__ of their expiration.
You cannot renew an access token that has been expired for more than 15 days.
Instead, the associated user must re-complete the OAuth flow from the beginning.

__Important:__ The `Authorization` header for this endpoint must have the
following format:

```
Authorization: Client APPLICATION_SECRET
```

Replace `APPLICATION_SECRET` with the application secret on the Credentials
page in the [developer dashboard](https://developer.squareup.com/apps).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Oauth.RenewToken(clientId, body);
    // TODO: Handle 'response' of type RenewTokenResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>clientId</code> | <code>string</code> | Your application ID, available from the [developer dashboard](https://developer.squareup.com/apps). |
| <code>body</code> | <code>[RenewTokenRequest](Models/RenewTokenRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RenewTokenResponse](Models/RenewTokenResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RevokeTokenResponse&gt; RevokeToken(RevokeTokenRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Revokes an access token generated with the OAuth flow.

If an account has more than one OAuth access token for your application, this
endpoint revokes all of them, regardless of which token you specify. When an
OAuth access token is revoked, all of the active subscriptions associated
with that OAuth token are canceled immediately.

__Important:__ The `Authorization` header for this endpoint must have the
following format:

```
Authorization: Client APPLICATION_SECRET
```

Replace `APPLICATION_SECRET` with the application secret on the OAuth
page in the [developer dashboard](https://developer.squareup.com/apps).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Oauth.RevokeToken(body);
    // TODO: Handle 'response' of type RevokeTokenResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[RevokeTokenRequest](Models/RevokeTokenRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RevokeTokenResponse](Models/RevokeTokenResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Orders

> Source: [Orders](Api/Orders.cs)

<details>
<summary><code>Task&lt;BatchRetrieveOrdersResponse&gt; BatchRetrieveOrders(BatchRetrieveOrdersRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a set of [orders](https://developer.squareup.com/reference/square_2021-08-18/objects/Order) by their IDs.

If a given order ID does not exist, the ID is ignored instead of generating an error.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Orders.BatchRetrieveOrders(body);
    // TODO: Handle 'response' of type BatchRetrieveOrdersResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[BatchRetrieveOrdersRequest](Models/BatchRetrieveOrdersRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BatchRetrieveOrdersResponse](Models/BatchRetrieveOrdersResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CalculateOrderResponse&gt; CalculateOrder(CalculateOrderRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Enables applications to preview order pricing without creating an order.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Orders.CalculateOrder(body);
    // TODO: Handle 'response' of type CalculateOrderResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[CalculateOrderRequest](Models/CalculateOrderRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CalculateOrderResponse](Models/CalculateOrderResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreateOrderResponse&gt; CreateOrder(CreateOrderRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a new [order](https://developer.squareup.com/reference/square_2021-08-18/objects/Order) that can include information about products for
purchase and settings to apply to the purchase.

To pay for a created order, see 
[Pay for Orders](https://developer.squareup.com/docs/orders-api/pay-for-orders).

You can modify open orders using the [UpdateOrder](https://developer.squareup.com/reference/square_2021-08-18/orders-api/update-order) endpoint.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Orders.CreateOrder(body);
    // TODO: Handle 'response' of type CreateOrderResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[CreateOrderRequest](Models/CreateOrderRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateOrderResponse](Models/CreateOrderResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PayOrderResponse&gt; PayOrder(string orderId, PayOrderRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Pay for an [order](https://developer.squareup.com/reference/square_2021-08-18/objects/Order) using one or more approved [payments](https://developer.squareup.com/reference/square_2021-08-18/objects/Payment)
or settle an order with a total of `0`.

The total of the `payment_ids` listed in the request must be equal to the order
total. Orders with a total amount of `0` can be marked as paid by specifying an empty
array of `payment_ids` in the request.

To be used with `PayOrder`, a payment must:

- Reference the order by specifying the `order_id` when [creating the payment](https://developer.squareup.com/reference/square_2021-08-18/payments-api/create-payment).
Any approved payments that reference the same `order_id` not specified in the
`payment_ids` is canceled.
- Be approved with [delayed capture](https://developer.squareup.com/docs/payments-api/take-payments#delayed-capture).
Using a delayed capture payment with `PayOrder` completes the approved payment.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Orders.PayOrder(orderId, body);
    // TODO: Handle 'response' of type PayOrderResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>orderId</code> | <code>string</code> | The ID of the order being paid. |
| <code>body</code> | <code>[PayOrderRequest](Models/PayOrderRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PayOrderResponse](Models/PayOrderResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveOrderResponse&gt; RetrieveOrder(string orderId, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves an [Order](https://developer.squareup.com/reference/square_2021-08-18/objects/Order) by ID.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Orders.RetrieveOrder(orderId);
    // TODO: Handle 'response' of type RetrieveOrderResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>orderId</code> | <code>string</code> | The ID of the order to retrieve. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveOrderResponse](Models/RetrieveOrderResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SearchOrdersResponse&gt; SearchOrders(SearchOrdersRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Search all orders for one or more locations. Orders include all sales,
returns, and exchanges regardless of how or when they entered the Square
ecosystem (such as Point of Sale, Invoices, and Connect APIs).

`SearchOrders` requests need to specify which locations to search and define a
[SearchOrdersQuery](https://developer.squareup.com/reference/square_2021-08-18/objects/SearchOrdersQuery) object that controls
how to sort or filter the results. Your `SearchOrdersQuery` can:

  Set filter criteria.
  Set the sort order.
  Determine whether to return results as complete `Order` objects or as
[OrderEntry](https://developer.squareup.com/reference/square_2021-08-18/objects/OrderEntry) objects.

Note that details for orders processed with Square Point of Sale while in
offline mode might not be transmitted to Square for up to 72 hours. Offline
orders have a `created_at` value that reflects the time the order was created,
not the time it was subsequently transmitted to Square.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Orders.SearchOrders(body);
    // TODO: Handle 'response' of type SearchOrdersResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[SearchOrdersRequest](Models/SearchOrdersRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SearchOrdersResponse](Models/SearchOrdersResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpdateOrderResponse&gt; UpdateOrder(string orderId, UpdateOrderRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates an open [order](https://developer.squareup.com/reference/square_2021-08-18/objects/Order) by adding, replacing, or deleting
fields. Orders with a `COMPLETED` or `CANCELED` state cannot be updated.

An `UpdateOrder` request requires the following:

- The `order_id` in the endpoint path, identifying the order to update.
- The latest `version` of the order to update.
- The [sparse order](https://developer.squareup.com/docs/orders-api/manage-orders#sparse-order-objects)
containing only the fields to update and the version to which the update is
being applied.
- If deleting fields, the [dot notation paths](https://developer.squareup.com/docs/orders-api/manage-orders#on-dot-notation)
identifying the fields to clear.

To pay for an order, see 
[Pay for Orders](https://developer.squareup.com/docs/orders-api/pay-for-orders).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Orders.UpdateOrder(orderId, body);
    // TODO: Handle 'response' of type UpdateOrderResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>orderId</code> | <code>string</code> | The ID of the order to update. |
| <code>body</code> | <code>[UpdateOrderRequest](Models/UpdateOrderRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpdateOrderResponse](Models/UpdateOrderResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Payments

> Source: [Payments](Api/Payments.cs)

<details>
<summary><code>Task&lt;CancelPaymentResponse&gt; CancelPayment(string paymentId, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Cancels (voids) a payment. You can use this endpoint to cancel a payment with 
the APPROVED `status`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Payments.CancelPayment(paymentId);
    // TODO: Handle 'response' of type CancelPaymentResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>paymentId</code> | <code>string</code> | The ID of the payment to cancel. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CancelPaymentResponse](Models/CancelPaymentResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CancelPaymentByIdempotencyKeyResponse&gt; CancelPaymentByIdempotencyKey(CancelPaymentByIdempotencyKeyRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Cancels (voids) a payment identified by the idempotency key that is specified in the
request.

Use this method when the status of a `CreatePayment` request is unknown (for example, after you send a
`CreatePayment` request, a network error occurs and you do not get a response). In this case, you can
direct Square to cancel the payment using this endpoint. In the request, you provide the same
idempotency key that you provided in your `CreatePayment` request that you want to cancel. After
canceling the payment, you can submit your `CreatePayment` request again.

Note that if no payment with the specified idempotency key is found, no action is taken and the endpoint
returns successfully.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Payments.CancelPaymentByIdempotencyKey(body);
    // TODO: Handle 'response' of type CancelPaymentByIdempotencyKeyResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[CancelPaymentByIdempotencyKeyRequest](Models/CancelPaymentByIdempotencyKeyRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CancelPaymentByIdempotencyKeyResponse](Models/CancelPaymentByIdempotencyKeyResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CompletePaymentResponse&gt; CompletePayment(string paymentId, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Completes (captures) a payment.
By default, payments are set to complete immediately after they are created.

You can use this endpoint to complete a payment with the APPROVED `status`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Payments.CompletePayment(paymentId);
    // TODO: Handle 'response' of type CompletePaymentResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>paymentId</code> | <code>string</code> | The unique ID identifying the payment to be completed. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CompletePaymentResponse](Models/CompletePaymentResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreatePaymentResponse&gt; CreatePayment(CreatePaymentRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a payment using the provided source. You can use this endpoint 
to charge a card (credit/debit card or    
Square gift card) or record a payment that the seller received outside of Square 
(cash payment from a buyer or a payment that an external entity 
processed on behalf of the seller).

The endpoint creates a 
`Payment` object and returns it in the response.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Payments.CreatePayment(body);
    // TODO: Handle 'response' of type CreatePaymentResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[CreatePaymentRequest](Models/CreatePaymentRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreatePaymentResponse](Models/CreatePaymentResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetPaymentResponse&gt; GetPayment(string paymentId, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves details for a specific payment.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Payments.GetPayment(paymentId);
    // TODO: Handle 'response' of type GetPaymentResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>paymentId</code> | <code>string</code> | A unique ID for the desired payment. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetPaymentResponse](Models/GetPaymentResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListPaymentsResponse&gt; ListPayments(string? beginTime, string? endTime, string? sortOrder, string? cursor, string? locationId, long? total, string? last4, string? cardBrand, int? limit, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a list of payments taken by the account making the request.

Results are eventually consistent, and new payments or changes to payments might take several
seconds to appear.

The maximum results per page is 100.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Payments.ListPayments(beginTime,
        endTime,
        sortOrder,
        cursor,
        locationId,
        total,
        last4,
        cardBrand,
        limit);
    // TODO: Handle 'response' of type ListPaymentsResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>beginTime</code> | <code>string?</code> | The timestamp for the beginning of the reporting period, in RFC 3339 format.<br>Inclusive. Default: The current time minus one year. |
| <code>endTime</code> | <code>string?</code> | The timestamp for the end of the reporting period, in RFC 3339 format.<br><br>Default: The current time. |
| <code>sortOrder</code> | <code>string?</code> | The order in which results are listed:<br>- `ASC` - Oldest to newest.<br>- `DESC` - Newest to oldest (default). |
| <code>cursor</code> | <code>string?</code> | A pagination cursor returned by a previous call to this endpoint.<br>Provide this cursor to retrieve the next set of results for the original query.<br><br>For more information, see [Pagination](https://developer.squareup.com/docs/basics/api101/pagination). |
| <code>locationId</code> | <code>string?</code> | Limit results to the location supplied. By default, results are returned<br>for the default (main) location associated with the seller. |
| <code>total</code> | <code>long?</code> | The exact amount in the `total_money` for a payment. |
| <code>last4</code> | <code>string?</code> | The last four digits of a payment card. |
| <code>cardBrand</code> | <code>string?</code> | The brand of the payment card (for example, VISA). |
| <code>limit</code> | <code>int?</code> | The maximum number of results to be returned in a single page.<br>It is possible to receive fewer results than the specified limit on a given page.<br><br>The default value of 100 is also the maximum allowed value. If the provided value is <br>greater than 100, it is ignored and the default value is used instead.<br><br>Default: `100` |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListPaymentsResponse](Models/ListPaymentsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpdatePaymentResponse&gt; UpdatePayment(string paymentId, UpdatePaymentRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates a payment with the APPROVED status.
You can update the `amount_money` and `tip_money` using this endpoint.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Payments.UpdatePayment(paymentId, body);
    // TODO: Handle 'response' of type UpdatePaymentResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>paymentId</code> | <code>string</code> | The ID of the payment to update. |
| <code>body</code> | <code>[UpdatePaymentRequest](Models/UpdatePaymentRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpdatePaymentResponse](Models/UpdatePaymentResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Refunds

> Source: [Refunds](Api/Refunds.cs)

<details>
<summary><code>Task&lt;GetPaymentRefundResponse&gt; GetPaymentRefund(string refundId, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a specific refund using the `refund_id`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Refunds.GetPaymentRefund(refundId);
    // TODO: Handle 'response' of type GetPaymentRefundResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>refundId</code> | <code>string</code> | The unique ID for the desired `PaymentRefund`. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetPaymentRefundResponse](Models/GetPaymentRefundResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListPaymentRefundsResponse&gt; ListPaymentRefunds(string? beginTime, string? endTime, string? sortOrder, string? cursor, string? locationId, string? status, string? sourceType, int? limit, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a list of refunds for the account making the request.

Results are eventually consistent, and new refunds or changes to refunds might take several
seconds to appear.

The maximum results per page is 100.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Refunds.ListPaymentRefunds(beginTime,
        endTime,
        sortOrder,
        cursor,
        locationId,
        status,
        sourceType,
        limit);
    // TODO: Handle 'response' of type ListPaymentRefundsResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>beginTime</code> | <code>string?</code> | The timestamp for the beginning of the requested reporting period, in RFC 3339 format.<br><br>Default: The current time minus one year. |
| <code>endTime</code> | <code>string?</code> | The timestamp for the end of the requested reporting period, in RFC 3339 format.<br><br>Default: The current time. |
| <code>sortOrder</code> | <code>string?</code> | The order in which results are listed:<br>- `ASC` - Oldest to newest.<br>- `DESC` - Newest to oldest (default). |
| <code>cursor</code> | <code>string?</code> | A pagination cursor returned by a previous call to this endpoint.<br>Provide this cursor to retrieve the next set of results for the original query.<br><br>For more information, see [Pagination](https://developer.squareup.com/docs/basics/api101/pagination). |
| <code>locationId</code> | <code>string?</code> | Limit results to the location supplied. By default, results are returned<br>for all locations associated with the seller. |
| <code>status</code> | <code>string?</code> | If provided, only refunds with the given status are returned.<br>For a list of refund status values, see [PaymentRefund](https://developer.squareup.com/reference/square_2021-08-18/objects/PaymentRefund).<br><br>Default: If omitted, refunds are returned regardless of their status. |
| <code>sourceType</code> | <code>string?</code> | If provided, only refunds with the given source type are returned.<br>- `CARD` - List refunds only for payments where `CARD` was specified as the payment<br>source.<br><br>Default: If omitted, refunds are returned regardless of the source type. |
| <code>limit</code> | <code>int?</code> | The maximum number of results to be returned in a single page.<br><br>It is possible to receive fewer results than the specified limit on a given page.<br><br>If the supplied value is greater than 100, no more than 100 results are returned.<br><br>Default: 100 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListPaymentRefundsResponse](Models/ListPaymentRefundsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RefundPaymentResponse&gt; RefundPayment(RefundPaymentRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Refunds a payment. You can refund the entire payment amount or a
portion of it. You can use this endpoint to refund a card payment or record a 
refund of a cash or external payment. For more information, see
[Refund Payment](https://developer.squareup.com/docs/payments-api/refund-payments).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Refunds.RefundPayment(body);
    // TODO: Handle 'response' of type RefundPaymentResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[RefundPaymentRequest](Models/RefundPaymentRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RefundPaymentResponse](Models/RefundPaymentResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Sites

> Source: [Sites](Api/Sites.cs)

<details>
<summary><code>Task&lt;ListSitesResponse&gt; ListSites(CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists the Square Online sites that belong to a seller.


__Note:__ Square Online APIs are publicly available as part of an early access program. For more information, see [Early access program for Square Online APIs](https://developer.squareup.com/docs/online-api#early-access-program-for-square-online-apis).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Sites.ListSites();
    // TODO: Handle 'response' of type ListSitesResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListSitesResponse](Models/ListSitesResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Snippets

> Source: [Snippets](Api/Snippets.cs)

<details>
<summary><code>Task&lt;DeleteSnippetResponse&gt; DeleteSnippet(string siteId, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Removes your snippet from a Square Online site.

You can call [ListSites](https://developer.squareup.com/reference/square_2021-08-18/sites-api/list-sites) to get the IDs of the sites that belong to a seller.


__Note:__ Square Online APIs are publicly available as part of an early access program. For more information, see [Early access program for Square Online APIs](https://developer.squareup.com/docs/online-api#early-access-program-for-square-online-apis).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Snippets.DeleteSnippet(siteId);
    // TODO: Handle 'response' of type DeleteSnippetResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>siteId</code> | <code>string</code> | The ID of the site that contains the snippet. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeleteSnippetResponse](Models/DeleteSnippetResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveSnippetResponse&gt; RetrieveSnippet(string siteId, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves your snippet from a Square Online site. A site can contain snippets from multiple snippet applications, but you can retrieve only the snippet that was added by your application.

You can call [ListSites](https://developer.squareup.com/reference/square_2021-08-18/sites-api/list-sites) to get the IDs of the sites that belong to a seller.


__Note:__ Square Online APIs are publicly available as part of an early access program. For more information, see [Early access program for Square Online APIs](https://developer.squareup.com/docs/online-api#early-access-program-for-square-online-apis).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Snippets.RetrieveSnippet(siteId);
    // TODO: Handle 'response' of type RetrieveSnippetResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>siteId</code> | <code>string</code> | The ID of the site that contains the snippet. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveSnippetResponse](Models/RetrieveSnippetResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpsertSnippetResponse&gt; UpsertSnippet(string siteId, UpsertSnippetRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Adds a snippet to a Square Online site or updates the existing snippet on the site. 
The snippet code is appended to the end of the `head` element on every page of the site, except checkout pages. A snippet application can add one snippet to a given site. 

You can call [ListSites](https://developer.squareup.com/reference/square_2021-08-18/sites-api/list-sites) to get the IDs of the sites that belong to a seller.


__Note:__ Square Online APIs are publicly available as part of an early access program. For more information, see [Early access program for Square Online APIs](https://developer.squareup.com/docs/online-api#early-access-program-for-square-online-apis).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Snippets.UpsertSnippet(siteId, body);
    // TODO: Handle 'response' of type UpsertSnippetResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>siteId</code> | <code>string</code> | The ID of the site where you want to add or update the snippet. |
| <code>body</code> | <code>[UpsertSnippetRequest](Models/UpsertSnippetRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpsertSnippetResponse](Models/UpsertSnippetResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Subscriptions

> Source: [Subscriptions](Api/Subscriptions.cs)

<details>
<summary><code>Task&lt;CancelSubscriptionResponse&gt; CancelSubscription(string subscriptionId, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Sets the `canceled_date` field to the end of the active billing period.
After this date, the status changes from ACTIVE to CANCELED.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Subscriptions.CancelSubscription(subscriptionId);
    // TODO: Handle 'response' of type CancelSubscriptionResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>subscriptionId</code> | <code>string</code> | The ID of the subscription to cancel. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CancelSubscriptionResponse](Models/CancelSubscriptionResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreateSubscriptionResponse&gt; CreateSubscription(CreateSubscriptionRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a subscription for a customer to a subscription plan.

If you provide a card on file in the request, Square charges the card for
the subscription. Otherwise, Square bills an invoice to the customer's email
address. The subscription starts immediately, unless the request includes
the optional `start_date`. Each individual subscription is associated with a particular location.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Subscriptions.CreateSubscription(body);
    // TODO: Handle 'response' of type CreateSubscriptionResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[CreateSubscriptionRequest](Models/CreateSubscriptionRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateSubscriptionResponse](Models/CreateSubscriptionResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListSubscriptionEventsResponse&gt; ListSubscriptionEvents(string subscriptionId, string? cursor, int? limit, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists all events for a specific subscription.
In the current implementation, only `START_SUBSCRIPTION` and `STOP_SUBSCRIPTION` (when the subscription was canceled) events are returned.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Subscriptions.ListSubscriptionEvents(subscriptionId, cursor, limit);
    // TODO: Handle 'response' of type ListSubscriptionEventsResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>subscriptionId</code> | <code>string</code> | The ID of the subscription to retrieve the events for. |
| <code>cursor</code> | <code>string?</code> | A pagination cursor returned by a previous call to this endpoint.<br>Provide this to retrieve the next set of results for the original query.<br><br>For more information, see [Pagination](https://developer.squareup.com/docs/working-with-apis/pagination). |
| <code>limit</code> | <code>int?</code> | The upper limit on the number of subscription events to return<br>in the response.<br><br>Default: `200` |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListSubscriptionEventsResponse](Models/ListSubscriptionEventsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ResumeSubscriptionResponse&gt; ResumeSubscription(string subscriptionId, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Resumes a deactivated subscription.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Subscriptions.ResumeSubscription(subscriptionId);
    // TODO: Handle 'response' of type ResumeSubscriptionResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>subscriptionId</code> | <code>string</code> | The ID of the subscription to resume. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ResumeSubscriptionResponse](Models/ResumeSubscriptionResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveSubscriptionResponse&gt; RetrieveSubscription(string subscriptionId, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a subscription.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Subscriptions.RetrieveSubscription(subscriptionId);
    // TODO: Handle 'response' of type RetrieveSubscriptionResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>subscriptionId</code> | <code>string</code> | The ID of the subscription to retrieve. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveSubscriptionResponse](Models/RetrieveSubscriptionResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SearchSubscriptionsResponse&gt; SearchSubscriptions(SearchSubscriptionsRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Searches for subscriptions.
Results are ordered chronologically by subscription creation date. If
the request specifies more than one location ID,
the endpoint orders the result
by location ID, and then by creation date within each location. If no locations are given
in the query, all locations are searched.

You can also optionally specify `customer_ids` to search by customer.
If left unset, all customers
associated with the specified locations are returned.
If the request specifies customer IDs, the endpoint orders results
first by location, within location by customer ID, and within
customer by subscription creation date.

For more information, see
[Retrieve subscriptions](https://developer.squareup.com/docs/subscriptions-api/overview#retrieve-subscriptions).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Subscriptions.SearchSubscriptions(body);
    // TODO: Handle 'response' of type SearchSubscriptionsResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[SearchSubscriptionsRequest](Models/SearchSubscriptionsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SearchSubscriptionsResponse](Models/SearchSubscriptionsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpdateSubscriptionResponse&gt; UpdateSubscription(string subscriptionId, UpdateSubscriptionRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates a subscription. You can set, modify, and clear the
`subscription` field values.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Subscriptions.UpdateSubscription(subscriptionId, body);
    // TODO: Handle 'response' of type UpdateSubscriptionResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>subscriptionId</code> | <code>string</code> | The ID for the subscription to update. |
| <code>body</code> | <code>[UpdateSubscriptionRequest](Models/UpdateSubscriptionRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpdateSubscriptionResponse](Models/UpdateSubscriptionResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Team

> Source: [Team](Api/Team.cs)

<details>
<summary><code>Task&lt;BulkCreateTeamMembersResponse&gt; BulkCreateTeamMembers(BulkCreateTeamMembersRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates multiple `TeamMember` objects. The created `TeamMember` objects are returned on successful creates.
This process is non-transactional and processes as much of the request as possible. If one of the creates in
the request cannot be successfully processed, the request is not marked as failed, but the body of the response
contains explicit error information for the failed create.

Learn about [Troubleshooting the Team API](https://developer.squareup.com/docs/team/troubleshooting#bulk-create-team-members).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Team.BulkCreateTeamMembers(body);
    // TODO: Handle 'response' of type BulkCreateTeamMembersResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[BulkCreateTeamMembersRequest](Models/BulkCreateTeamMembersRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BulkCreateTeamMembersResponse](Models/BulkCreateTeamMembersResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BulkUpdateTeamMembersResponse&gt; BulkUpdateTeamMembers(BulkUpdateTeamMembersRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates multiple `TeamMember` objects. The updated `TeamMember` objects are returned on successful updates.
This process is non-transactional and processes as much of the request as possible. If one of the updates in
the request cannot be successfully processed, the request is not marked as failed, but the body of the response
contains explicit error information for the failed update.
Learn about [Troubleshooting the Team API](https://developer.squareup.com/docs/team/troubleshooting#bulk-update-team-members).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Team.BulkUpdateTeamMembers(body);
    // TODO: Handle 'response' of type BulkUpdateTeamMembersResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[BulkUpdateTeamMembersRequest](Models/BulkUpdateTeamMembersRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BulkUpdateTeamMembersResponse](Models/BulkUpdateTeamMembersResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreateTeamMemberResponse&gt; CreateTeamMember(CreateTeamMemberRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a single `TeamMember` object. The `TeamMember` object is returned on successful creates.
You must provide the following values in your request to this endpoint:
- `given_name`
- `family_name`

Learn about [Troubleshooting the Team API](https://developer.squareup.com/docs/team/troubleshooting#createteammember).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Team.CreateTeamMember(body);
    // TODO: Handle 'response' of type CreateTeamMemberResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[CreateTeamMemberRequest](Models/CreateTeamMemberRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateTeamMemberResponse](Models/CreateTeamMemberResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveTeamMemberResponse&gt; RetrieveTeamMember(string teamMemberId, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a `TeamMember` object for the given `TeamMember.id`.
Learn about [Troubleshooting the Team API](https://developer.squareup.com/docs/team/troubleshooting#retrieve-a-team-member).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Team.RetrieveTeamMember(teamMemberId);
    // TODO: Handle 'response' of type RetrieveTeamMemberResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>teamMemberId</code> | <code>string</code> | The ID of the team member to retrieve. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveTeamMemberResponse](Models/RetrieveTeamMemberResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveWageSettingResponse&gt; RetrieveWageSetting(string teamMemberId, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a `WageSetting` object for a team member specified
by `TeamMember.id`.
Learn about [Troubleshooting the Team API](https://developer.squareup.com/docs/team/troubleshooting#retrievewagesetting).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Team.RetrieveWageSetting(teamMemberId);
    // TODO: Handle 'response' of type RetrieveWageSettingResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>teamMemberId</code> | <code>string</code> | The ID of the team member for which to retrieve the wage setting. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveWageSettingResponse](Models/RetrieveWageSettingResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SearchTeamMembersResponse&gt; SearchTeamMembers(SearchTeamMembersRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a paginated list of `TeamMember` objects for a business.
The list can be filtered by the following:
- location IDs
- `status`

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Team.SearchTeamMembers(body);
    // TODO: Handle 'response' of type SearchTeamMembersResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[SearchTeamMembersRequest](Models/SearchTeamMembersRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SearchTeamMembersResponse](Models/SearchTeamMembersResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpdateTeamMemberResponse&gt; UpdateTeamMember(string teamMemberId, UpdateTeamMemberRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates a single `TeamMember` object. The `TeamMember` object is returned on successful updates.
Learn about [Troubleshooting the Team API](https://developer.squareup.com/docs/team/troubleshooting#update-a-team-member).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Team.UpdateTeamMember(teamMemberId, body);
    // TODO: Handle 'response' of type UpdateTeamMemberResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>teamMemberId</code> | <code>string</code> | The ID of the team member to update. |
| <code>body</code> | <code>[UpdateTeamMemberRequest](Models/UpdateTeamMemberRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpdateTeamMemberResponse](Models/UpdateTeamMemberResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpdateWageSettingResponse&gt; UpdateWageSetting(string teamMemberId, UpdateWageSettingRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates or updates a `WageSetting` object. The object is created if a
`WageSetting` with the specified `team_member_id` does not exist. Otherwise,
it fully replaces the `WageSetting` object for the team member.
The `WageSetting` is returned on a successful update.
Learn about [Troubleshooting the Team API](https://developer.squareup.com/docs/team/troubleshooting#create-or-update-a-wage-setting).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Team.UpdateWageSetting(teamMemberId, body);
    // TODO: Handle 'response' of type UpdateWageSettingResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>teamMemberId</code> | <code>string</code> | The ID of the team member for which to update the `WageSetting` object. |
| <code>body</code> | <code>[UpdateWageSettingRequest](Models/UpdateWageSettingRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpdateWageSettingResponse](Models/UpdateWageSettingResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Terminal

> Source: [Terminal](Api/Terminal.cs)

<details>
<summary><code>Task&lt;CancelTerminalCheckoutResponse&gt; CancelTerminalCheckout(string checkoutId, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Cancels a Terminal checkout request if the status of the request permits it.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Terminal.CancelTerminalCheckout(checkoutId);
    // TODO: Handle 'response' of type CancelTerminalCheckoutResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>checkoutId</code> | <code>string</code> | The unique ID for the desired `TerminalCheckout`. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CancelTerminalCheckoutResponse](Models/CancelTerminalCheckoutResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CancelTerminalRefundResponse&gt; CancelTerminalRefund(string terminalRefundId, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Cancels an Interac Terminal refund request by refund request ID if the status of the request permits it.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Terminal.CancelTerminalRefund(terminalRefundId);
    // TODO: Handle 'response' of type CancelTerminalRefundResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>terminalRefundId</code> | <code>string</code> | The unique ID for the desired `TerminalRefund`. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CancelTerminalRefundResponse](Models/CancelTerminalRefundResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreateTerminalCheckoutResponse&gt; CreateTerminalCheckout(CreateTerminalCheckoutRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a Terminal checkout request and sends it to the specified device to take a payment
for the requested amount.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Terminal.CreateTerminalCheckout(body);
    // TODO: Handle 'response' of type CreateTerminalCheckoutResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[CreateTerminalCheckoutRequest](Models/CreateTerminalCheckoutRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateTerminalCheckoutResponse](Models/CreateTerminalCheckoutResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreateTerminalRefundResponse&gt; CreateTerminalRefund(CreateTerminalRefundRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a request to refund an Interac payment completed on a Square Terminal.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Terminal.CreateTerminalRefund(body);
    // TODO: Handle 'response' of type CreateTerminalRefundResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[CreateTerminalRefundRequest](Models/CreateTerminalRefundRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateTerminalRefundResponse](Models/CreateTerminalRefundResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetTerminalCheckoutResponse&gt; GetTerminalCheckout(string checkoutId, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a Terminal checkout request by `checkout_id`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Terminal.GetTerminalCheckout(checkoutId);
    // TODO: Handle 'response' of type GetTerminalCheckoutResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>checkoutId</code> | <code>string</code> | The unique ID for the desired `TerminalCheckout`. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetTerminalCheckoutResponse](Models/GetTerminalCheckoutResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetTerminalRefundResponse&gt; GetTerminalRefund(string terminalRefundId, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves an Interac Terminal refund object by ID.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Terminal.GetTerminalRefund(terminalRefundId);
    // TODO: Handle 'response' of type GetTerminalRefundResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>terminalRefundId</code> | <code>string</code> | The unique ID for the desired `TerminalRefund`. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetTerminalRefundResponse](Models/GetTerminalRefundResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SearchTerminalCheckoutsResponse&gt; SearchTerminalCheckouts(SearchTerminalCheckoutsRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a filtered list of Terminal checkout requests created by the account making the request.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Terminal.SearchTerminalCheckouts(body);
    // TODO: Handle 'response' of type SearchTerminalCheckoutsResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[SearchTerminalCheckoutsRequest](Models/SearchTerminalCheckoutsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SearchTerminalCheckoutsResponse](Models/SearchTerminalCheckoutsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SearchTerminalRefundsResponse&gt; SearchTerminalRefunds(SearchTerminalRefundsRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a filtered list of Interac Terminal refund requests created by the seller making the request.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Terminal.SearchTerminalRefunds(body);
    // TODO: Handle 'response' of type SearchTerminalRefundsResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[SearchTerminalRefundsRequest](Models/SearchTerminalRefundsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SearchTerminalRefundsResponse](Models/SearchTerminalRefundsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Transactions

> Source: [Transactions](Api/Transactions.cs)

<details>
<summary><code>Task&lt;CaptureTransactionResponse&gt; CaptureTransaction(string locationId, string transactionId, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Captures a transaction that was created with the [Charge](https://developer.squareup.com/reference/square_2021-08-18/transactions-api/charge)
endpoint with a `delay_capture` value of `true`.


See [Delayed capture transactions](https://developer.squareup.com/docs/payments/transactions/overview#delayed-capture)
for more information.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Transactions.CaptureTransaction(locationId, transactionId);
    // TODO: Handle 'response' of type CaptureTransactionResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>locationId</code> | <code>string</code> | - |
| <code>transactionId</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CaptureTransactionResponse](Models/CaptureTransactionResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ChargeResponse&gt; Charge(string locationId, ChargeRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Charges a card represented by a card nonce or a customer's card on file.

Your request to this endpoint must include _either_:

- A value for the `card_nonce` parameter (to charge a card payment token generated
with the Web Payments SDK)
- Values for the `customer_card_id` and `customer_id` parameters (to charge
a customer's card on file)

In order for an eCommerce payment to potentially qualify for
[Square chargeback protection](https://squareup.com/help/article/5394), you
_must_ provide values for the following parameters in your request:

- `buyer_email_address`
- At least one of `billing_address` or `shipping_address`

When this response is returned, the amount of Square's processing fee might not yet be
calculated. To obtain the processing fee, wait about ten seconds and call
[RetrieveTransaction](https://developer.squareup.com/reference/square_2021-08-18/transactions-api/retrieve-transaction). See the `processing_fee_money`
field of each [Tender included](https://developer.squareup.com/reference/square_2021-08-18/objects/Tender) in the transaction.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Transactions.Charge(locationId, body);
    // TODO: Handle 'response' of type ChargeResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>locationId</code> | <code>string</code> | The ID of the location to associate the created transaction with. |
| <code>body</code> | <code>[ChargeRequest](Models/ChargeRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChargeResponse](Models/ChargeResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreateRefundResponse&gt; CreateRefund(string locationId, string transactionId, CreateRefundRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Initiates a refund for a previously charged tender.

You must issue a refund within 120 days of the associated payment. See
[this article](https://squareup.com/help/us/en/article/5060) for more information
on refund behavior.

NOTE: Card-present transactions with Interac credit cards **cannot be
refunded using the Connect API**. Interac transactions must refunded
in-person (e.g., dipping the card using POS app).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Transactions.CreateRefund(locationId, transactionId, body);
    // TODO: Handle 'response' of type CreateRefundResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>locationId</code> | <code>string</code> | The ID of the original transaction's associated location. |
| <code>transactionId</code> | <code>string</code> | The ID of the original transaction that includes the tender to refund. |
| <code>body</code> | <code>[CreateRefundRequest](Models/CreateRefundRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateRefundResponse](Models/CreateRefundResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListRefundsResponse&gt; ListRefunds(string locationId, string? beginTime, string? endTime, string? sortOrder, string? cursor, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists refunds for one of a business's locations.

In addition to full or partial tender refunds processed through Square APIs,
refunds may result from itemized returns or exchanges through Square's
Point of Sale applications.

Refunds with a `status` of `PENDING` are not currently included in this
endpoint's response.

Max results per [page](https://developer.squareup.com/docs/working-with-apis/pagination): 50

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Transactions.ListRefunds(locationId, beginTime, endTime, sortOrder, cursor);
    // TODO: Handle 'response' of type ListRefundsResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>locationId</code> | <code>string</code> | The ID of the location to list refunds for. |
| <code>beginTime</code> | <code>string?</code> | The beginning of the requested reporting period, in RFC 3339 format.<br><br>See [Date ranges](https://developer.squareup.com/docs/build-basics/working-with-dates) for details on date inclusivity/exclusivity.<br><br>Default value: The current time minus one year. |
| <code>endTime</code> | <code>string?</code> | The end of the requested reporting period, in RFC 3339 format.<br><br>See [Date ranges](https://developer.squareup.com/docs/build-basics/working-with-dates) for details on date inclusivity/exclusivity.<br><br>Default value: The current time. |
| <code>sortOrder</code> | <code>string?</code> | The order in which results are listed in the response (`ASC` for<br>oldest first, `DESC` for newest first).<br><br>Default value: `DESC` |
| <code>cursor</code> | <code>string?</code> | A pagination cursor returned by a previous call to this endpoint.<br>Provide this to retrieve the next set of results for your original query.<br><br>See [Paginating results](https://developer.squareup.com/docs/working-with-apis/pagination) for more information. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListRefundsResponse](Models/ListRefundsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListTransactionsResponse&gt; ListTransactions(string locationId, string? beginTime, string? endTime, string? sortOrder, string? cursor, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists transactions for a particular location.

Transactions include payment information from sales and exchanges and refund
information from returns and exchanges.

Max results per [page](https://developer.squareup.com/docs/working-with-apis/pagination): 50

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Transactions.ListTransactions(locationId, beginTime, endTime, sortOrder, cursor);
    // TODO: Handle 'response' of type ListTransactionsResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>locationId</code> | <code>string</code> | The ID of the location to list transactions for. |
| <code>beginTime</code> | <code>string?</code> | The beginning of the requested reporting period, in RFC 3339 format.<br><br>See [Date ranges](https://developer.squareup.com/docs/build-basics/working-with-dates) for details on date inclusivity/exclusivity.<br><br>Default value: The current time minus one year. |
| <code>endTime</code> | <code>string?</code> | The end of the requested reporting period, in RFC 3339 format.<br><br>See [Date ranges](https://developer.squareup.com/docs/build-basics/working-with-dates) for details on date inclusivity/exclusivity.<br><br>Default value: The current time. |
| <code>sortOrder</code> | <code>string?</code> | The order in which results are listed in the response (`ASC` for<br>oldest first, `DESC` for newest first).<br><br>Default value: `DESC` |
| <code>cursor</code> | <code>string?</code> | A pagination cursor returned by a previous call to this endpoint.<br>Provide this to retrieve the next set of results for your original query.<br><br>See [Paginating results](https://developer.squareup.com/docs/working-with-apis/pagination) for more information. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListTransactionsResponse](Models/ListTransactionsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveTransactionResponse&gt; RetrieveTransaction(string locationId, string transactionId, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves details for a single transaction.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Transactions.RetrieveTransaction(locationId, transactionId);
    // TODO: Handle 'response' of type RetrieveTransactionResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>locationId</code> | <code>string</code> | The ID of the transaction's associated location. |
| <code>transactionId</code> | <code>string</code> | The ID of the transaction to retrieve. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveTransactionResponse](Models/RetrieveTransactionResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;VoidTransactionResponse&gt; VoidTransaction(string locationId, string transactionId, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Cancels a transaction that was created with the [Charge](https://developer.squareup.com/reference/square_2021-08-18/transactions-api/charge)
endpoint with a `delay_capture` value of `true`.


See [Delayed capture transactions](https://developer.squareup.com/docs/payments/transactions/overview#delayed-capture)
for more information.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Transactions.VoidTransaction(locationId, transactionId);
    // TODO: Handle 'response' of type VoidTransactionResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>locationId</code> | <code>string</code> | - |
| <code>transactionId</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[VoidTransactionResponse](Models/VoidTransactionResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## V1Employees

> Source: [V1Employees](Api/V1Employees.cs)

<details>
<summary><code>Task&lt;V1Employee&gt; CreateEmployee(V1Employee body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

 Use the CreateEmployee endpoint to add an employee to a Square
account. Employees created with the Connect API have an initial status
of `INACTIVE`. Inactive employees cannot sign in to Square Point of Sale
until they are activated from the Square Dashboard. Employee status
cannot be changed with the Connect API.

Employee entities cannot be deleted. To disable employee profiles,
set the employee's status to <code>INACTIVE</code>

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.V1Employees.CreateEmployee(body);
    // TODO: Handle 'response' of type V1Employee
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[V1Employee](Models/V1Employee.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1Employee](Models/V1Employee.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1EmployeeRole&gt; CreateEmployeeRole(V1EmployeeRole body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates an employee role you can then assign to employees.

Square accounts can include any number of roles that can be assigned to
employees. These roles define the actions and permissions granted to an
employee with that role. For example, an employee with a "Shift Manager"
role might be able to issue refunds in Square Point of Sale, whereas an
employee with a "Clerk" role might not.

Roles are assigned with the [V1UpdateEmployee](https://developer.squareup.com/reference/square_2021-08-18/v1-employees-api/update-employee-role)
endpoint. An employee can have only one role at a time.

If an employee has no role, they have none of the permissions associated
with roles. All employees can accept payments with Square Point of Sale.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.V1Employees.CreateEmployeeRole(body);
    // TODO: Handle 'response' of type V1EmployeeRole
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[V1EmployeeRole](Models/V1EmployeeRole.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1EmployeeRole](Models/V1EmployeeRole.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;V1EmployeeRole&gt;&gt; ListEmployeeRoles(string? order, int? limit, string? batchToken, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Provides summary information for all of a business's employee roles.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.V1Employees.ListEmployeeRoles(order, limit, batchToken);
    // TODO: Handle 'response' of type IReadOnlyList<V1EmployeeRole>
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>order</code> | <code>string?</code> | The order in which employees are listed in the response, based on their created_at field.Default value: ASC |
| <code>limit</code> | <code>int?</code> | The maximum integer number of employee entities to return in a single response. Default 100, maximum 200. |
| <code>batchToken</code> | <code>string?</code> | A pagination cursor to retrieve the next set of results for your<br>original query to the endpoint. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[V1EmployeeRole](Models/V1EmployeeRole.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;V1Employee&gt;&gt; ListEmployees(string? order, string? beginUpdatedAt, string? endUpdatedAt, string? beginCreatedAt, string? endCreatedAt, string? status, string? externalId, int? limit, string? batchToken, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Provides summary information for all of a business's employees.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.V1Employees.ListEmployees(order,
        beginUpdatedAt,
        endUpdatedAt,
        beginCreatedAt,
        endCreatedAt,
        status,
        externalId,
        limit,
        batchToken);
    // TODO: Handle 'response' of type IReadOnlyList<V1Employee>
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>order</code> | <code>string?</code> | The order in which employees are listed in the response, based on their created_at field.      Default value: ASC |
| <code>beginUpdatedAt</code> | <code>string?</code> | If filtering results by their updated_at field, the beginning of the requested reporting period, in ISO 8601 format |
| <code>endUpdatedAt</code> | <code>string?</code> | If filtering results by there updated_at field, the end of the requested reporting period, in ISO 8601 format. |
| <code>beginCreatedAt</code> | <code>string?</code> | If filtering results by their created_at field, the beginning of the requested reporting period, in ISO 8601 format. |
| <code>endCreatedAt</code> | <code>string?</code> | If filtering results by their created_at field, the end of the requested reporting period, in ISO 8601 format. |
| <code>status</code> | <code>string?</code> | If provided, the endpoint returns only employee entities with the specified status (ACTIVE or INACTIVE). |
| <code>externalId</code> | <code>string?</code> | If provided, the endpoint returns only employee entities with the specified external_id. |
| <code>limit</code> | <code>int?</code> | The maximum integer number of employee entities to return in a single response. Default 100, maximum 200. |
| <code>batchToken</code> | <code>string?</code> | A pagination cursor to retrieve the next set of results for your<br>original query to the endpoint. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[V1Employee](Models/V1Employee.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1Employee&gt; RetrieveEmployee(string employeeId, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Provides the details for a single employee.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.V1Employees.RetrieveEmployee(employeeId);
    // TODO: Handle 'response' of type V1Employee
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>employeeId</code> | <code>string</code> | The employee's ID. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1Employee](Models/V1Employee.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1EmployeeRole&gt; RetrieveEmployeeRole(string roleId, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Provides the details for a single employee role.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.V1Employees.RetrieveEmployeeRole(roleId);
    // TODO: Handle 'response' of type V1EmployeeRole
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>roleId</code> | <code>string</code> | The role's ID. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1EmployeeRole](Models/V1EmployeeRole.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1Employee&gt; UpdateEmployee(string employeeId, V1Employee body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.V1Employees.UpdateEmployee(employeeId, body);
    // TODO: Handle 'response' of type V1Employee
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>employeeId</code> | <code>string</code> | The ID of the role to modify. |
| <code>body</code> | <code>[V1Employee](Models/V1Employee.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1Employee](Models/V1Employee.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1EmployeeRole&gt; UpdateEmployeeRole(string roleId, V1EmployeeRole body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Modifies the details of an employee role.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.V1Employees.UpdateEmployeeRole(roleId, body);
    // TODO: Handle 'response' of type V1EmployeeRole
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>roleId</code> | <code>string</code> | The ID of the role to modify. |
| <code>body</code> | <code>[V1EmployeeRole](Models/V1EmployeeRole.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1EmployeeRole](Models/V1EmployeeRole.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## V1Transactions

> Source: [V1Transactions](Api/V1Transactions.cs)

<details>
<summary><code>Task&lt;V1Refund&gt; CreateRefund(string locationId, V1CreateRefundRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Issues a refund for a previously processed payment. You must issue
a refund within 60 days of the associated payment.

You cannot issue a partial refund for a split tender payment. You must
instead issue a full or partial refund for a particular tender, by
providing the applicable tender id to the V1CreateRefund endpoint.
Issuing a full refund for a split tender payment refunds all tenders
associated with the payment.

Issuing a refund for a card payment is not reversible. For development
purposes, you can create fake cash payments in Square Point of Sale and
refund them.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.V1Transactions.CreateRefund(locationId, body);
    // TODO: Handle 'response' of type V1Refund
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>locationId</code> | <code>string</code> | The ID of the original payment's associated location. |
| <code>body</code> | <code>[V1CreateRefundRequest](Models/V1CreateRefundRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1Refund](Models/V1Refund.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;V1Order&gt;&gt; ListOrders(string locationId, string? order, int? limit, string? batchToken, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Provides summary information for a merchant's online store orders.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.V1Transactions.ListOrders(locationId, order, limit, batchToken);
    // TODO: Handle 'response' of type IReadOnlyList<V1Order>
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>locationId</code> | <code>string</code> | The ID of the location to list online store orders for. |
| <code>order</code> | <code>string?</code> | The order in which payments are listed in the response. |
| <code>limit</code> | <code>int?</code> | The maximum number of payments to return in a single response. This value cannot exceed 200. |
| <code>batchToken</code> | <code>string?</code> | A pagination cursor to retrieve the next set of results for your<br>original query to the endpoint. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[V1Order](Models/V1Order.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;V1Payment&gt;&gt; ListPayments(string locationId, string? order, string? beginTime, string? endTime, int? limit, string? batchToken, bool? includePartial, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Provides summary information for all payments taken for a given
Square account during a date range. Date ranges cannot exceed 1 year in
length. See Date ranges for details of inclusive and exclusive dates.

*Note**: Details for payments processed with Square Point of Sale while
in offline mode may not be transmitted to Square for up to 72 hours.
Offline payments have a `created_at` value that reflects the time the
payment was originally processed, not the time it was subsequently
transmitted to Square. Consequently, the ListPayments endpoint might
list an offline payment chronologically between online payments that
were seen in a previous request.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.V1Transactions.ListPayments(locationId,
        order,
        beginTime,
        endTime,
        limit,
        batchToken,
        includePartial);
    // TODO: Handle 'response' of type IReadOnlyList<V1Payment>
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>locationId</code> | <code>string</code> | The ID of the location to list payments for. If you specify me, this endpoint returns payments aggregated from all of the business's locations. |
| <code>order</code> | <code>string?</code> | The order in which payments are listed in the response. |
| <code>beginTime</code> | <code>string?</code> | The beginning of the requested reporting period, in ISO 8601 format. If this value is before January 1, 2013 (2013-01-01T00:00:00Z), this endpoint returns an error. Default value: The current time minus one year. |
| <code>endTime</code> | <code>string?</code> | The end of the requested reporting period, in ISO 8601 format. If this value is more than one year greater than begin_time, this endpoint returns an error. Default value: The current time. |
| <code>limit</code> | <code>int?</code> | The maximum number of payments to return in a single response. This value cannot exceed 200. |
| <code>batchToken</code> | <code>string?</code> | A pagination cursor to retrieve the next set of results for your<br>original query to the endpoint. |
| <code>includePartial</code> | <code>bool?</code> | Indicates whether or not to include partial payments in the response. Partial payments will have the tenders collected so far, but the itemizations will be empty until the payment is completed. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[V1Payment](Models/V1Payment.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;V1Refund&gt;&gt; ListRefunds(string locationId, string? order, string? beginTime, string? endTime, int? limit, string? batchToken, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Provides the details for all refunds initiated by a merchant or any of the merchant's mobile staff during a date range. Date ranges cannot exceed one year in length.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.V1Transactions.ListRefunds(locationId, order, beginTime, endTime, limit, batchToken);
    // TODO: Handle 'response' of type IReadOnlyList<V1Refund>
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>locationId</code> | <code>string</code> | The ID of the location to list refunds for. |
| <code>order</code> | <code>string?</code> | The order in which payments are listed in the response. |
| <code>beginTime</code> | <code>string?</code> | The beginning of the requested reporting period, in ISO 8601 format. If this value is before January 1, 2013 (2013-01-01T00:00:00Z), this endpoint returns an error. Default value: The current time minus one year. |
| <code>endTime</code> | <code>string?</code> | The end of the requested reporting period, in ISO 8601 format. If this value is more than one year greater than begin_time, this endpoint returns an error. Default value: The current time. |
| <code>limit</code> | <code>int?</code> | The approximate number of refunds to return in a single response. Default: 100. Max: 200. Response may contain more results than the prescribed limit when refunds are made simultaneously to multiple tenders in a payment or when refunds are generated in an exchange to account for the value of returned goods. |
| <code>batchToken</code> | <code>string?</code> | A pagination cursor to retrieve the next set of results for your<br>original query to the endpoint. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[V1Refund](Models/V1Refund.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;V1Settlement&gt;&gt; ListSettlements(string locationId, string? order, string? beginTime, string? endTime, int? limit, string? status, string? batchToken, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Provides summary information for all deposits and withdrawals
initiated by Square to a linked bank account during a date range. Date
ranges cannot exceed one year in length.

*Note**: the ListSettlements endpoint does not provide entry
information.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.V1Transactions.ListSettlements(locationId,
        order,
        beginTime,
        endTime,
        limit,
        status,
        batchToken);
    // TODO: Handle 'response' of type IReadOnlyList<V1Settlement>
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>locationId</code> | <code>string</code> | The ID of the location to list settlements for. If you specify me, this endpoint returns settlements aggregated from all of the business's locations. |
| <code>order</code> | <code>string?</code> | The order in which settlements are listed in the response. |
| <code>beginTime</code> | <code>string?</code> | The beginning of the requested reporting period, in ISO 8601 format. If this value is before January 1, 2013 (2013-01-01T00:00:00Z), this endpoint returns an error. Default value: The current time minus one year. |
| <code>endTime</code> | <code>string?</code> | The end of the requested reporting period, in ISO 8601 format. If this value is more than one year greater than begin_time, this endpoint returns an error. Default value: The current time. |
| <code>limit</code> | <code>int?</code> | The maximum number of settlements to return in a single response. This value cannot exceed 200. |
| <code>status</code> | <code>string?</code> | Provide this parameter to retrieve only settlements with a particular status (SENT or FAILED). |
| <code>batchToken</code> | <code>string?</code> | A pagination cursor to retrieve the next set of results for your<br>original query to the endpoint. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[V1Settlement](Models/V1Settlement.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1Order&gt; RetrieveOrder(string locationId, string orderId, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Provides comprehensive information for a single online store order, including the order's history.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.V1Transactions.RetrieveOrder(locationId, orderId);
    // TODO: Handle 'response' of type V1Order
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>locationId</code> | <code>string</code> | The ID of the order's associated location. |
| <code>orderId</code> | <code>string</code> | The order's Square-issued ID. You obtain this value from Order objects returned by the List Orders endpoint |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1Order](Models/V1Order.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1Payment&gt; RetrievePayment(string locationId, string paymentId, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Provides comprehensive information for a single payment.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.V1Transactions.RetrievePayment(locationId, paymentId);
    // TODO: Handle 'response' of type V1Payment
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>locationId</code> | <code>string</code> | The ID of the payment's associated location. |
| <code>paymentId</code> | <code>string</code> | The Square-issued payment ID. payment_id comes from Payment objects returned by the List Payments endpoint, Settlement objects returned by the List Settlements endpoint, or Refund objects returned by the List Refunds endpoint. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1Payment](Models/V1Payment.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1Settlement&gt; RetrieveSettlement(string locationId, string settlementId, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Provides comprehensive information for a single settlement.

The returned `Settlement` objects include an `entries` field that lists
the transactions that contribute to the settlement total. Most
settlement entries correspond to a payment payout, but settlement
entries are also generated for less common events, like refunds, manual
adjustments, or chargeback holds.

Square initiates its regular deposits as indicated in the
[Deposit Options with Square](https://squareup.com/help/us/en/article/3807)
help article. Details for a regular deposit are usually not available
from Connect API endpoints before 10 p.m. PST the same day.

Square does not know when an initiated settlement **completes**, only
whether it has failed. A completed settlement is typically reflected in
a bank account within 3 business days, but in exceptional cases it may
take longer.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.V1Transactions.RetrieveSettlement(locationId, settlementId);
    // TODO: Handle 'response' of type V1Settlement
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>locationId</code> | <code>string</code> | The ID of the settlements's associated location. |
| <code>settlementId</code> | <code>string</code> | The settlement's Square-issued ID. You obtain this value from Settlement objects returned by the List Settlements endpoint. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1Settlement](Models/V1Settlement.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1Order&gt; UpdateOrder(string locationId, string orderId, V1UpdateOrderRequest body, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates the details of an online store order. Every update you perform on an order corresponds to one of three actions:

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.V1Transactions.UpdateOrder(locationId, orderId, body);
    // TODO: Handle 'response' of type V1Order
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>locationId</code> | <code>string</code> | The ID of the order's associated location. |
| <code>orderId</code> | <code>string</code> | The order's Square-issued ID. You obtain this value from Order objects returned by the List Orders endpoint |
| <code>body</code> | <code>[V1UpdateOrderRequest](Models/V1UpdateOrderRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1Order](Models/V1Order.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

