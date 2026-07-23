using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

public record BatchUpsertCatalogObjectsRequest
{
    /// <summary>
    /// A batch of CatalogObjects to be inserted/updated atomically.
    /// The objects within a batch will be inserted in an all-or-nothing fashion, i.e., if an error occurs
    /// attempting to insert or update an object within a batch, the entire batch will be rejected. However, an error
    /// in one batch will not affect other batches within the same request.
    /// <para>
    /// For each object, its <c>updated_at</c> field is ignored and replaced with a current <see href="https://developer.squareup.com/docs/build-basics/working-with-dates">timestamp</see>, and its
    /// <c>is_deleted</c> field must not be set to <c>true</c>.
    /// </para>
    /// <para>
    /// To modify an existing object, supply its ID. To create a new object, use an ID starting
    /// with <c>#</c>. These IDs may be used to create relationships between an object and attributes of
    /// other objects that reference it. For example, you can create a CatalogItem with
    /// ID <c>#ABC</c> and a CatalogItemVariation with its <c>item_id</c> attribute set to
    /// <c>#ABC</c> in order to associate the CatalogItemVariation with its parent
    /// CatalogItem.
    /// </para>
    /// <para>
    /// Any <c>#</c>-prefixed IDs are valid only within a single atomic batch, and will be replaced by server-generated IDs.
    /// </para>
    /// <para>
    /// Each batch may contain up to 1,000 objects. The total number of objects across all batches for a single request
    /// may not exceed 10,000. If either of these limits is violated, an error will be returned and no objects will
    /// be inserted or updated.
    /// </para>
    /// </summary>
    [JsonPropertyName("batches")]
    public required IReadOnlyList<CatalogObjectBatch> Batches { get; init; }

    /// <summary>
    /// A value you specify that uniquely identifies this
    /// request among all your requests. A common way to create
    /// a valid idempotency key is to use a Universally unique
    /// identifier (UUID).
    /// <para>
    /// If you're unsure whether a particular request was successful,
    /// you can reattempt it with the same idempotency key without
    /// worrying about creating duplicate objects.
    /// </para>
    /// <para>
    /// See <see href="https://developer.squareup.com/docs/basics/api101/idempotency">Idempotency</see> for more information.
    /// </para>
    /// </summary>
    [JsonPropertyName("idempotency_key")]
    [MinLength(1)]
    public required string IdempotencyKey { get; init; }
}
