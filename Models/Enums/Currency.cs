using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// Indicates the associated currency for an amount of money. Values correspond
/// to <see href="https://wikipedia.org/wiki/ISO_4217">ISO 4217</see>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Currency>))]
public sealed record Currency : StringEnum<Currency>
{
    private Currency(string value) : base(value)
    {
    }

    /// <summary>
    /// Unknown currency
    /// </summary>
    public static readonly Currency UnknownCurrency = new("UNKNOWN_CURRENCY");

    /// <summary>
    /// United Arab Emirates dirham
    /// </summary>
    public static readonly Currency Aed = new("AED");

    /// <summary>
    /// Afghan afghani
    /// </summary>
    public static readonly Currency Afn = new("AFN");

    /// <summary>
    /// Albanian lek
    /// </summary>
    public static readonly Currency All = new("ALL");

    /// <summary>
    /// Armenian dram
    /// </summary>
    public static readonly Currency Amd = new("AMD");

    /// <summary>
    /// Netherlands Antillean guilder
    /// </summary>
    public static readonly Currency Ang = new("ANG");

    /// <summary>
    /// Angolan kwanza
    /// </summary>
    public static readonly Currency Aoa = new("AOA");

    /// <summary>
    /// Argentine peso
    /// </summary>
    public static readonly Currency Ars = new("ARS");

    /// <summary>
    /// Australian dollar
    /// </summary>
    public static readonly Currency Aud = new("AUD");

    /// <summary>
    /// Aruban florin
    /// </summary>
    public static readonly Currency Awg = new("AWG");

    /// <summary>
    /// Azerbaijani manat
    /// </summary>
    public static readonly Currency Azn = new("AZN");

    /// <summary>
    /// Bosnia and Herzegovina convertible mark
    /// </summary>
    public static readonly Currency Bam = new("BAM");

    /// <summary>
    /// Barbados dollar
    /// </summary>
    public static readonly Currency Bbd = new("BBD");

    /// <summary>
    /// Bangladeshi taka
    /// </summary>
    public static readonly Currency Bdt = new("BDT");

    /// <summary>
    /// Bulgarian lev
    /// </summary>
    public static readonly Currency Bgn = new("BGN");

    /// <summary>
    /// Bahraini dinar
    /// </summary>
    public static readonly Currency Bhd = new("BHD");

    /// <summary>
    /// Burundian franc
    /// </summary>
    public static readonly Currency Bif = new("BIF");

    /// <summary>
    /// Bermudian dollar
    /// </summary>
    public static readonly Currency Bmd = new("BMD");

    /// <summary>
    /// Brunei dollar
    /// </summary>
    public static readonly Currency Bnd = new("BND");

    /// <summary>
    /// Boliviano
    /// </summary>
    public static readonly Currency Bob = new("BOB");

    /// <summary>
    /// Bolivian Mvdol
    /// </summary>
    public static readonly Currency Bov = new("BOV");

    /// <summary>
    /// Brazilian real
    /// </summary>
    public static readonly Currency Brl = new("BRL");

    /// <summary>
    /// Bahamian dollar
    /// </summary>
    public static readonly Currency Bsd = new("BSD");

    /// <summary>
    /// Bhutanese ngultrum
    /// </summary>
    public static readonly Currency Btn = new("BTN");

    /// <summary>
    /// Botswana pula
    /// </summary>
    public static readonly Currency Bwp = new("BWP");

    /// <summary>
    /// Belarusian ruble
    /// </summary>
    public static readonly Currency Byr = new("BYR");

    /// <summary>
    /// Belize dollar
    /// </summary>
    public static readonly Currency Bzd = new("BZD");

    /// <summary>
    /// Canadian dollar
    /// </summary>
    public static readonly Currency Cad = new("CAD");

    /// <summary>
    /// Congolese franc
    /// </summary>
    public static readonly Currency Cdf = new("CDF");

    /// <summary>
    /// WIR Euro
    /// </summary>
    public static readonly Currency Che = new("CHE");

    /// <summary>
    /// Swiss franc
    /// </summary>
    public static readonly Currency Chf = new("CHF");

    /// <summary>
    /// WIR Franc
    /// </summary>
    public static readonly Currency Chw = new("CHW");

    /// <summary>
    /// Unidad de Fomento
    /// </summary>
    public static readonly Currency Clf = new("CLF");

    /// <summary>
    /// Chilean peso
    /// </summary>
    public static readonly Currency Clp = new("CLP");

    /// <summary>
    /// Chinese yuan
    /// </summary>
    public static readonly Currency Cny = new("CNY");

    /// <summary>
    /// Colombian peso
    /// </summary>
    public static readonly Currency Cop = new("COP");

    /// <summary>
    /// Unidad de Valor Real
    /// </summary>
    public static readonly Currency Cou = new("COU");

    /// <summary>
    /// Costa Rican colon
    /// </summary>
    public static readonly Currency Crc = new("CRC");

    /// <summary>
    /// Cuban convertible peso
    /// </summary>
    public static readonly Currency Cuc = new("CUC");

    /// <summary>
    /// Cuban peso
    /// </summary>
    public static readonly Currency Cup = new("CUP");

    /// <summary>
    /// Cape Verdean escudo
    /// </summary>
    public static readonly Currency Cve = new("CVE");

    /// <summary>
    /// Czech koruna
    /// </summary>
    public static readonly Currency Czk = new("CZK");

    /// <summary>
    /// Djiboutian franc
    /// </summary>
    public static readonly Currency Djf = new("DJF");

    /// <summary>
    /// Danish krone
    /// </summary>
    public static readonly Currency Dkk = new("DKK");

    /// <summary>
    /// Dominican peso
    /// </summary>
    public static readonly Currency Dop = new("DOP");

    /// <summary>
    /// Algerian dinar
    /// </summary>
    public static readonly Currency Dzd = new("DZD");

    /// <summary>
    /// Egyptian pound
    /// </summary>
    public static readonly Currency Egp = new("EGP");

    /// <summary>
    /// Eritrean nakfa
    /// </summary>
    public static readonly Currency Ern = new("ERN");

    /// <summary>
    /// Ethiopian birr
    /// </summary>
    public static readonly Currency Etb = new("ETB");

    /// <summary>
    /// Euro
    /// </summary>
    public static readonly Currency Eur = new("EUR");

    /// <summary>
    /// Fiji dollar
    /// </summary>
    public static readonly Currency Fjd = new("FJD");

    /// <summary>
    /// Falkland Islands pound
    /// </summary>
    public static readonly Currency Fkp = new("FKP");

    /// <summary>
    /// Pound sterling
    /// </summary>
    public static readonly Currency Gbp = new("GBP");

    /// <summary>
    /// Georgian lari
    /// </summary>
    public static readonly Currency Gel = new("GEL");

    /// <summary>
    /// Ghanaian cedi
    /// </summary>
    public static readonly Currency Ghs = new("GHS");

    /// <summary>
    /// Gibraltar pound
    /// </summary>
    public static readonly Currency Gip = new("GIP");

    /// <summary>
    /// Gambian dalasi
    /// </summary>
    public static readonly Currency Gmd = new("GMD");

    /// <summary>
    /// Guinean franc
    /// </summary>
    public static readonly Currency Gnf = new("GNF");

    /// <summary>
    /// Guatemalan quetzal
    /// </summary>
    public static readonly Currency Gtq = new("GTQ");

    /// <summary>
    /// Guyanese dollar
    /// </summary>
    public static readonly Currency Gyd = new("GYD");

    /// <summary>
    /// Hong Kong dollar
    /// </summary>
    public static readonly Currency Hkd = new("HKD");

    /// <summary>
    /// Honduran lempira
    /// </summary>
    public static readonly Currency Hnl = new("HNL");

    /// <summary>
    /// Croatian kuna
    /// </summary>
    public static readonly Currency Hrk = new("HRK");

    /// <summary>
    /// Haitian gourde
    /// </summary>
    public static readonly Currency Htg = new("HTG");

    /// <summary>
    /// Hungarian forint
    /// </summary>
    public static readonly Currency Huf = new("HUF");

    /// <summary>
    /// Indonesian rupiah
    /// </summary>
    public static readonly Currency Idr = new("IDR");

    /// <summary>
    /// Israeli new shekel
    /// </summary>
    public static readonly Currency Ils = new("ILS");

    /// <summary>
    /// Indian rupee
    /// </summary>
    public static readonly Currency Inr = new("INR");

    /// <summary>
    /// Iraqi dinar
    /// </summary>
    public static readonly Currency Iqd = new("IQD");

    /// <summary>
    /// Iranian rial
    /// </summary>
    public static readonly Currency Irr = new("IRR");

    /// <summary>
    /// Icelandic króna
    /// </summary>
    public static readonly Currency Isk = new("ISK");

    /// <summary>
    /// Jamaican dollar
    /// </summary>
    public static readonly Currency Jmd = new("JMD");

    /// <summary>
    /// Jordanian dinar
    /// </summary>
    public static readonly Currency Jod = new("JOD");

    /// <summary>
    /// Japanese yen
    /// </summary>
    public static readonly Currency Jpy = new("JPY");

    /// <summary>
    /// Kenyan shilling
    /// </summary>
    public static readonly Currency Kes = new("KES");

    /// <summary>
    /// Kyrgyzstani som
    /// </summary>
    public static readonly Currency Kgs = new("KGS");

    /// <summary>
    /// Cambodian riel
    /// </summary>
    public static readonly Currency Khr = new("KHR");

    /// <summary>
    /// Comoro franc
    /// </summary>
    public static readonly Currency Kmf = new("KMF");

    /// <summary>
    /// North Korean won
    /// </summary>
    public static readonly Currency Kpw = new("KPW");

    /// <summary>
    /// South Korean won
    /// </summary>
    public static readonly Currency Krw = new("KRW");

    /// <summary>
    /// Kuwaiti dinar
    /// </summary>
    public static readonly Currency Kwd = new("KWD");

    /// <summary>
    /// Cayman Islands dollar
    /// </summary>
    public static readonly Currency Kyd = new("KYD");

    /// <summary>
    /// Kazakhstani tenge
    /// </summary>
    public static readonly Currency Kzt = new("KZT");

    /// <summary>
    /// Lao kip
    /// </summary>
    public static readonly Currency Lak = new("LAK");

    /// <summary>
    /// Lebanese pound
    /// </summary>
    public static readonly Currency Lbp = new("LBP");

    /// <summary>
    /// Sri Lankan rupee
    /// </summary>
    public static readonly Currency Lkr = new("LKR");

    /// <summary>
    /// Liberian dollar
    /// </summary>
    public static readonly Currency Lrd = new("LRD");

    /// <summary>
    /// Lesotho loti
    /// </summary>
    public static readonly Currency Lsl = new("LSL");

    /// <summary>
    /// Lithuanian litas
    /// </summary>
    public static readonly Currency Ltl = new("LTL");

    /// <summary>
    /// Latvian lats
    /// </summary>
    public static readonly Currency Lvl = new("LVL");

    /// <summary>
    /// Libyan dinar
    /// </summary>
    public static readonly Currency Lyd = new("LYD");

    /// <summary>
    /// Moroccan dirham
    /// </summary>
    public static readonly Currency Mad = new("MAD");

    /// <summary>
    /// Moldovan leu
    /// </summary>
    public static readonly Currency Mdl = new("MDL");

    /// <summary>
    /// Malagasy ariary
    /// </summary>
    public static readonly Currency Mga = new("MGA");

    /// <summary>
    /// Macedonian denar
    /// </summary>
    public static readonly Currency Mkd = new("MKD");

    /// <summary>
    /// Myanmar kyat
    /// </summary>
    public static readonly Currency Mmk = new("MMK");

    /// <summary>
    /// Mongolian tögrög
    /// </summary>
    public static readonly Currency Mnt = new("MNT");

    /// <summary>
    /// Macanese pataca
    /// </summary>
    public static readonly Currency Mop = new("MOP");

    /// <summary>
    /// Mauritanian ouguiya
    /// </summary>
    public static readonly Currency Mro = new("MRO");

    /// <summary>
    /// Mauritian rupee
    /// </summary>
    public static readonly Currency Mur = new("MUR");

    /// <summary>
    /// Maldivian rufiyaa
    /// </summary>
    public static readonly Currency Mvr = new("MVR");

    /// <summary>
    /// Malawian kwacha
    /// </summary>
    public static readonly Currency Mwk = new("MWK");

    /// <summary>
    /// Mexican peso
    /// </summary>
    public static readonly Currency Mxn = new("MXN");

    /// <summary>
    /// Mexican Unidad de Inversion
    /// </summary>
    public static readonly Currency Mxv = new("MXV");

    /// <summary>
    /// Malaysian ringgit
    /// </summary>
    public static readonly Currency Myr = new("MYR");

    /// <summary>
    /// Mozambican metical
    /// </summary>
    public static readonly Currency Mzn = new("MZN");

    /// <summary>
    /// Namibian dollar
    /// </summary>
    public static readonly Currency Nad = new("NAD");

    /// <summary>
    /// Nigerian naira
    /// </summary>
    public static readonly Currency Ngn = new("NGN");

    /// <summary>
    /// Nicaraguan córdoba
    /// </summary>
    public static readonly Currency Nio = new("NIO");

    /// <summary>
    /// Norwegian krone
    /// </summary>
    public static readonly Currency Nok = new("NOK");

    /// <summary>
    /// Nepalese rupee
    /// </summary>
    public static readonly Currency Npr = new("NPR");

    /// <summary>
    /// New Zealand dollar
    /// </summary>
    public static readonly Currency Nzd = new("NZD");

    /// <summary>
    /// Omani rial
    /// </summary>
    public static readonly Currency Omr = new("OMR");

    /// <summary>
    /// Panamanian balboa
    /// </summary>
    public static readonly Currency Pab = new("PAB");

    /// <summary>
    /// Peruvian sol
    /// </summary>
    public static readonly Currency Pen = new("PEN");

    /// <summary>
    /// Papua New Guinean kina
    /// </summary>
    public static readonly Currency Pgk = new("PGK");

    /// <summary>
    /// Philippine peso
    /// </summary>
    public static readonly Currency Php = new("PHP");

    /// <summary>
    /// Pakistani rupee
    /// </summary>
    public static readonly Currency Pkr = new("PKR");

    /// <summary>
    /// Polish złoty
    /// </summary>
    public static readonly Currency Pln = new("PLN");

    /// <summary>
    /// Paraguayan guaraní
    /// </summary>
    public static readonly Currency Pyg = new("PYG");

    /// <summary>
    /// Qatari riyal
    /// </summary>
    public static readonly Currency Qar = new("QAR");

    /// <summary>
    /// Romanian leu
    /// </summary>
    public static readonly Currency Ron = new("RON");

    /// <summary>
    /// Serbian dinar
    /// </summary>
    public static readonly Currency Rsd = new("RSD");

    /// <summary>
    /// Russian ruble
    /// </summary>
    public static readonly Currency Rub = new("RUB");

    /// <summary>
    /// Rwandan franc
    /// </summary>
    public static readonly Currency Rwf = new("RWF");

    /// <summary>
    /// Saudi riyal
    /// </summary>
    public static readonly Currency Sar = new("SAR");

    /// <summary>
    /// Solomon Islands dollar
    /// </summary>
    public static readonly Currency Sbd = new("SBD");

    /// <summary>
    /// Seychelles rupee
    /// </summary>
    public static readonly Currency Scr = new("SCR");

    /// <summary>
    /// Sudanese pound
    /// </summary>
    public static readonly Currency Sdg = new("SDG");

    /// <summary>
    /// Swedish krona
    /// </summary>
    public static readonly Currency Sek = new("SEK");

    /// <summary>
    /// Singapore dollar
    /// </summary>
    public static readonly Currency Sgd = new("SGD");

    /// <summary>
    /// Saint Helena pound
    /// </summary>
    public static readonly Currency Shp = new("SHP");

    /// <summary>
    /// Sierra Leonean leone
    /// </summary>
    public static readonly Currency Sll = new("SLL");

    /// <summary>
    /// Somali shilling
    /// </summary>
    public static readonly Currency Sos = new("SOS");

    /// <summary>
    /// Surinamese dollar
    /// </summary>
    public static readonly Currency Srd = new("SRD");

    /// <summary>
    /// South Sudanese pound
    /// </summary>
    public static readonly Currency Ssp = new("SSP");

    /// <summary>
    /// São Tomé and Príncipe dobra
    /// </summary>
    public static readonly Currency Std = new("STD");

    /// <summary>
    /// Salvadoran colón
    /// </summary>
    public static readonly Currency Svc = new("SVC");

    /// <summary>
    /// Syrian pound
    /// </summary>
    public static readonly Currency Syp = new("SYP");

    /// <summary>
    /// Swazi lilangeni
    /// </summary>
    public static readonly Currency Szl = new("SZL");

    /// <summary>
    /// Thai baht
    /// </summary>
    public static readonly Currency Thb = new("THB");

    /// <summary>
    /// Tajikstani somoni
    /// </summary>
    public static readonly Currency Tjs = new("TJS");

    /// <summary>
    /// Turkmenistan manat
    /// </summary>
    public static readonly Currency Tmt = new("TMT");

    /// <summary>
    /// Tunisian dinar
    /// </summary>
    public static readonly Currency Tnd = new("TND");

    /// <summary>
    /// Tongan pa'anga
    /// </summary>
    public static readonly Currency Top = new("TOP");

    /// <summary>
    /// Turkish lira
    /// </summary>
    public static readonly Currency Try = new("TRY");

    /// <summary>
    /// Trinidad and Tobago dollar
    /// </summary>
    public static readonly Currency Ttd = new("TTD");

    /// <summary>
    /// New Taiwan dollar
    /// </summary>
    public static readonly Currency Twd = new("TWD");

    /// <summary>
    /// Tanzanian shilling
    /// </summary>
    public static readonly Currency Tzs = new("TZS");

    /// <summary>
    /// Ukrainian hryvnia
    /// </summary>
    public static readonly Currency Uah = new("UAH");

    /// <summary>
    /// Ugandan shilling
    /// </summary>
    public static readonly Currency Ugx = new("UGX");

    /// <summary>
    /// United States dollar
    /// </summary>
    public static readonly Currency Usd = new("USD");

    /// <summary>
    /// United States dollar (next day)
    /// </summary>
    public static readonly Currency Usn = new("USN");

    /// <summary>
    /// United States dollar (same day)
    /// </summary>
    public static readonly Currency Uss = new("USS");

    /// <summary>
    /// Uruguay Peso en Unidedades Indexadas
    /// </summary>
    public static readonly Currency Uyi = new("UYI");

    /// <summary>
    /// Uruguyan peso
    /// </summary>
    public static readonly Currency Uyu = new("UYU");

    /// <summary>
    /// Uzbekistan som
    /// </summary>
    public static readonly Currency Uzs = new("UZS");

    /// <summary>
    /// Venezuelan bolívar soberano
    /// </summary>
    public static readonly Currency Vef = new("VEF");

    /// <summary>
    /// Vietnamese đồng
    /// </summary>
    public static readonly Currency Vnd = new("VND");

    /// <summary>
    /// Vanuatu vatu
    /// </summary>
    public static readonly Currency Vuv = new("VUV");

    /// <summary>
    /// Samoan tala
    /// </summary>
    public static readonly Currency Wst = new("WST");

    /// <summary>
    /// CFA franc BEAC
    /// </summary>
    public static readonly Currency Xaf = new("XAF");

    /// <summary>
    /// Silver
    /// </summary>
    public static readonly Currency Xag = new("XAG");

    /// <summary>
    /// Gold
    /// </summary>
    public static readonly Currency Xau = new("XAU");

    /// <summary>
    /// European Composite Unit
    /// </summary>
    public static readonly Currency Xba = new("XBA");

    /// <summary>
    /// European Monetary Unit
    /// </summary>
    public static readonly Currency Xbb = new("XBB");

    /// <summary>
    /// European Unit of Account 9
    /// </summary>
    public static readonly Currency Xbc = new("XBC");

    /// <summary>
    /// European Unit of Account 17
    /// </summary>
    public static readonly Currency Xbd = new("XBD");

    /// <summary>
    /// East Caribbean dollar
    /// </summary>
    public static readonly Currency Xcd = new("XCD");

    /// <summary>
    /// Special drawing rights (International Monetary Fund)
    /// </summary>
    public static readonly Currency Xdr = new("XDR");

    /// <summary>
    /// CFA franc BCEAO
    /// </summary>
    public static readonly Currency Xof = new("XOF");

    /// <summary>
    /// Palladium
    /// </summary>
    public static readonly Currency Xpd = new("XPD");

    /// <summary>
    /// CFP franc
    /// </summary>
    public static readonly Currency Xpf = new("XPF");

    /// <summary>
    /// Platinum
    /// </summary>
    public static readonly Currency Xpt = new("XPT");

    /// <summary>
    /// Code reserved for testing
    /// </summary>
    public static readonly Currency Xts = new("XTS");

    /// <summary>
    /// No currency
    /// </summary>
    public static readonly Currency Xxx = new("XXX");

    /// <summary>
    /// Yemeni rial
    /// </summary>
    public static readonly Currency Yer = new("YER");

    /// <summary>
    /// South African rand
    /// </summary>
    public static readonly Currency Zar = new("ZAR");

    /// <summary>
    /// Zambian kwacha
    /// </summary>
    public static readonly Currency Zmk = new("ZMK");

    /// <summary>
    /// Zambian kwacha
    /// </summary>
    public static readonly Currency Zmw = new("ZMW");

    /// <summary>
    /// Bitcoin
    /// </summary>
    public static readonly Currency Btc = new("BTC");

    public static Currency FromValue(string value) => FromValueCore(value);
}
