using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// The tax IDs that a Location is operating under.
/// </summary>
public record TaxIds
{
    /// <summary>
    /// The EU VAT number for this location. For example, "IE3426675K".
    /// If the EU VAT number is present, it is well-formed and has been
    /// validated with VIES, the VAT Information Exchange System.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eu_vat")]
    public string? EuVat { get; init; }

    /// <summary>
    /// The French government uses the NAF (Nomenclature des Activités Françaises) to display and
    /// track economic statistical data. This is also called the APE (Activite Principale de l’Entreprise) code.
    /// For example, 6910Z.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fr_naf")]
    public string? FrNaf { get; init; }

    /// <summary>
    /// The SIRET (Système d'Identification du Répertoire des Entreprises et de leurs Etablissements)
    /// number is a 14 digits code issued by the French INSEE. For example, "39922799000021".
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fr_siret")]
    public string? FrSiret { get; init; }
}
