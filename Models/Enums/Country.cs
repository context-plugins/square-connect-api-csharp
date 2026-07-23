using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// Indicates the country associated with another entity, such as a business.
/// Values are in <see href="http://www.iso.org/iso/home/standards/country_codes.htm">ISO 3166-1-alpha-2 format</see>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Country>))]
public sealed record Country : StringEnum<Country>
{
    private Country(string value) : base(value)
    {
    }

    /// <summary>
    /// Unknown
    /// </summary>
    public static readonly Country Zz = new("ZZ");

    /// <summary>
    /// Andorra
    /// </summary>
    public static readonly Country Ad = new("AD");

    /// <summary>
    /// United Arab Emirates
    /// </summary>
    public static readonly Country Ae = new("AE");

    /// <summary>
    /// Afghanistan
    /// </summary>
    public static readonly Country Af = new("AF");

    /// <summary>
    /// Antigua and Barbuda
    /// </summary>
    public static readonly Country Ag = new("AG");

    /// <summary>
    /// Anguilla
    /// </summary>
    public static readonly Country Ai = new("AI");

    /// <summary>
    /// Albania
    /// </summary>
    public static readonly Country Al = new("AL");

    /// <summary>
    /// Armenia
    /// </summary>
    public static readonly Country Am = new("AM");

    /// <summary>
    /// Angola
    /// </summary>
    public static readonly Country Ao = new("AO");

    /// <summary>
    /// Antartica
    /// </summary>
    public static readonly Country Aq = new("AQ");

    /// <summary>
    /// Argentina
    /// </summary>
    public static readonly Country Ar = new("AR");

    /// <summary>
    /// American Samoa
    /// </summary>
    public static readonly Country As = new("AS");

    /// <summary>
    /// Austria
    /// </summary>
    public static readonly Country At = new("AT");

    /// <summary>
    /// Australia
    /// </summary>
    public static readonly Country Au = new("AU");

    /// <summary>
    /// Aruba
    /// </summary>
    public static readonly Country Aw = new("AW");

    /// <summary>
    /// Åland Islands
    /// </summary>
    public static readonly Country Ax = new("AX");

    /// <summary>
    /// Azerbaijan
    /// </summary>
    public static readonly Country Az = new("AZ");

    /// <summary>
    /// Bosnia and Herzegovina
    /// </summary>
    public static readonly Country Ba = new("BA");

    /// <summary>
    /// Barbados
    /// </summary>
    public static readonly Country Bb = new("BB");

    /// <summary>
    /// Bangladesh
    /// </summary>
    public static readonly Country Bd = new("BD");

    /// <summary>
    /// Belgium
    /// </summary>
    public static readonly Country Be = new("BE");

    /// <summary>
    /// Burkina Faso
    /// </summary>
    public static readonly Country Bf = new("BF");

    /// <summary>
    /// Bulgaria
    /// </summary>
    public static readonly Country Bg = new("BG");

    /// <summary>
    /// Bahrain
    /// </summary>
    public static readonly Country Bh = new("BH");

    /// <summary>
    /// Burundi
    /// </summary>
    public static readonly Country Bi = new("BI");

    /// <summary>
    /// Benin
    /// </summary>
    public static readonly Country Bj = new("BJ");

    /// <summary>
    /// Saint Barthélemy
    /// </summary>
    public static readonly Country Bl = new("BL");

    /// <summary>
    /// Bermuda
    /// </summary>
    public static readonly Country Bm = new("BM");

    /// <summary>
    /// Brunei
    /// </summary>
    public static readonly Country Bn = new("BN");

    /// <summary>
    /// Bolivia
    /// </summary>
    public static readonly Country Bo = new("BO");

    /// <summary>
    /// Bonaire
    /// </summary>
    public static readonly Country Bq = new("BQ");

    /// <summary>
    /// Brazil
    /// </summary>
    public static readonly Country Br = new("BR");

    /// <summary>
    /// Bahamas
    /// </summary>
    public static readonly Country Bs = new("BS");

    /// <summary>
    /// Bhutan
    /// </summary>
    public static readonly Country Bt = new("BT");

    /// <summary>
    /// Bouvet Island
    /// </summary>
    public static readonly Country Bv = new("BV");

    /// <summary>
    /// Botswana
    /// </summary>
    public static readonly Country Bw = new("BW");

    /// <summary>
    /// Belarus
    /// </summary>
    public static readonly Country By = new("BY");

    /// <summary>
    /// Belize
    /// </summary>
    public static readonly Country Bz = new("BZ");

    /// <summary>
    /// Canada
    /// </summary>
    public static readonly Country Ca = new("CA");

    /// <summary>
    /// Cocos Islands
    /// </summary>
    public static readonly Country Cc = new("CC");

    /// <summary>
    /// Democratic Republic of the Congo
    /// </summary>
    public static readonly Country Cd = new("CD");

    /// <summary>
    /// Central African Republic
    /// </summary>
    public static readonly Country Cf = new("CF");

    /// <summary>
    /// Congo
    /// </summary>
    public static readonly Country Cg = new("CG");

    /// <summary>
    /// Switzerland
    /// </summary>
    public static readonly Country Ch = new("CH");

    /// <summary>
    /// Ivory Coast
    /// </summary>
    public static readonly Country Ci = new("CI");

    /// <summary>
    /// Cook Islands
    /// </summary>
    public static readonly Country Ck = new("CK");

    /// <summary>
    /// Chile
    /// </summary>
    public static readonly Country Cl = new("CL");

    /// <summary>
    /// Cameroon
    /// </summary>
    public static readonly Country Cm = new("CM");

    /// <summary>
    /// China
    /// </summary>
    public static readonly Country Cn = new("CN");

    /// <summary>
    /// Colombia
    /// </summary>
    public static readonly Country Co = new("CO");

    /// <summary>
    /// Costa Rica
    /// </summary>
    public static readonly Country Cr = new("CR");

    /// <summary>
    /// Cuba
    /// </summary>
    public static readonly Country Cu = new("CU");

    /// <summary>
    /// Cabo Verde
    /// </summary>
    public static readonly Country Cv = new("CV");

    /// <summary>
    /// Curaçao
    /// </summary>
    public static readonly Country Cw = new("CW");

    /// <summary>
    /// Christmas Island
    /// </summary>
    public static readonly Country Cx = new("CX");

    /// <summary>
    /// Cyprus
    /// </summary>
    public static readonly Country Cy = new("CY");

    /// <summary>
    /// Czechia
    /// </summary>
    public static readonly Country Cz = new("CZ");

    /// <summary>
    /// Germany
    /// </summary>
    public static readonly Country De = new("DE");

    /// <summary>
    /// Djibouti
    /// </summary>
    public static readonly Country Dj = new("DJ");

    /// <summary>
    /// Denmark
    /// </summary>
    public static readonly Country Dk = new("DK");

    /// <summary>
    /// Dominica
    /// </summary>
    public static readonly Country Dm = new("DM");

    /// <summary>
    /// Dominican Republic
    /// </summary>
    public static readonly Country Do = new("DO");

    /// <summary>
    /// Algeria
    /// </summary>
    public static readonly Country Dz = new("DZ");

    /// <summary>
    /// Ecuador
    /// </summary>
    public static readonly Country Ec = new("EC");

    /// <summary>
    /// Estonia
    /// </summary>
    public static readonly Country Ee = new("EE");

    /// <summary>
    /// Egypt
    /// </summary>
    public static readonly Country Eg = new("EG");

    /// <summary>
    /// Western Sahara
    /// </summary>
    public static readonly Country Eh = new("EH");

    /// <summary>
    /// Eritrea
    /// </summary>
    public static readonly Country Er = new("ER");

    /// <summary>
    /// Spain
    /// </summary>
    public static readonly Country Es = new("ES");

    /// <summary>
    /// Ethiopia
    /// </summary>
    public static readonly Country Et = new("ET");

    /// <summary>
    /// Finland
    /// </summary>
    public static readonly Country Fi = new("FI");

    /// <summary>
    /// Fiji
    /// </summary>
    public static readonly Country Fj = new("FJ");

    /// <summary>
    /// Falkland Islands
    /// </summary>
    public static readonly Country Fk = new("FK");

    /// <summary>
    /// Federated States of Micronesia
    /// </summary>
    public static readonly Country Fm = new("FM");

    /// <summary>
    /// Faroe Islands
    /// </summary>
    public static readonly Country Fo = new("FO");

    /// <summary>
    /// France
    /// </summary>
    public static readonly Country Fr = new("FR");

    /// <summary>
    /// Gabon
    /// </summary>
    public static readonly Country Ga = new("GA");

    /// <summary>
    /// United Kingdom
    /// </summary>
    public static readonly Country Gb = new("GB");

    /// <summary>
    /// Grenada
    /// </summary>
    public static readonly Country Gd = new("GD");

    /// <summary>
    /// Georgia
    /// </summary>
    public static readonly Country Ge = new("GE");

    /// <summary>
    /// French Guiana
    /// </summary>
    public static readonly Country Gf = new("GF");

    /// <summary>
    /// Guernsey
    /// </summary>
    public static readonly Country Gg = new("GG");

    /// <summary>
    /// Ghana
    /// </summary>
    public static readonly Country Gh = new("GH");

    /// <summary>
    /// Gibraltar
    /// </summary>
    public static readonly Country Gi = new("GI");

    /// <summary>
    /// Greenland
    /// </summary>
    public static readonly Country Gl = new("GL");

    /// <summary>
    /// Gambia
    /// </summary>
    public static readonly Country Gm = new("GM");

    /// <summary>
    /// Guinea
    /// </summary>
    public static readonly Country Gn = new("GN");

    /// <summary>
    /// Guadeloupe
    /// </summary>
    public static readonly Country Gp = new("GP");

    /// <summary>
    /// Equatorial Guinea
    /// </summary>
    public static readonly Country Gq = new("GQ");

    /// <summary>
    /// Greece
    /// </summary>
    public static readonly Country Gr = new("GR");

    /// <summary>
    /// South Georgia and the South Sandwich Islands
    /// </summary>
    public static readonly Country Gs = new("GS");

    /// <summary>
    /// Guatemala
    /// </summary>
    public static readonly Country Gt = new("GT");

    /// <summary>
    /// Guam
    /// </summary>
    public static readonly Country Gu = new("GU");

    /// <summary>
    /// Guinea-Bissau
    /// </summary>
    public static readonly Country Gw = new("GW");

    /// <summary>
    /// Guyana
    /// </summary>
    public static readonly Country Gy = new("GY");

    /// <summary>
    /// Hong Kong
    /// </summary>
    public static readonly Country Hk = new("HK");

    /// <summary>
    /// Heard Island and McDonald Islands
    /// </summary>
    public static readonly Country Hm = new("HM");

    /// <summary>
    /// Honduras
    /// </summary>
    public static readonly Country Hn = new("HN");

    /// <summary>
    /// Croatia
    /// </summary>
    public static readonly Country Hr = new("HR");

    /// <summary>
    /// Haiti
    /// </summary>
    public static readonly Country Ht = new("HT");

    /// <summary>
    /// Hungary
    /// </summary>
    public static readonly Country Hu = new("HU");

    /// <summary>
    /// Indonesia
    /// </summary>
    public static readonly Country Id = new("ID");

    /// <summary>
    /// Ireland
    /// </summary>
    public static readonly Country Ie = new("IE");

    /// <summary>
    /// Israel
    /// </summary>
    public static readonly Country Il = new("IL");

    /// <summary>
    /// Isle of Man
    /// </summary>
    public static readonly Country Im = new("IM");

    /// <summary>
    /// India
    /// </summary>
    public static readonly Country In = new("IN");

    /// <summary>
    /// British Indian Ocean Territory
    /// </summary>
    public static readonly Country Io = new("IO");

    /// <summary>
    /// Iraq
    /// </summary>
    public static readonly Country Iq = new("IQ");

    /// <summary>
    /// Iran
    /// </summary>
    public static readonly Country Ir = new("IR");

    /// <summary>
    /// Iceland
    /// </summary>
    public static readonly Country Is = new("IS");

    /// <summary>
    /// Italy
    /// </summary>
    public static readonly Country It = new("IT");

    /// <summary>
    /// Jersey
    /// </summary>
    public static readonly Country Je = new("JE");

    /// <summary>
    /// Jamaica
    /// </summary>
    public static readonly Country Jm = new("JM");

    /// <summary>
    /// Jordan
    /// </summary>
    public static readonly Country Jo = new("JO");

    /// <summary>
    /// Japan
    /// </summary>
    public static readonly Country Jp = new("JP");

    /// <summary>
    /// Kenya
    /// </summary>
    public static readonly Country Ke = new("KE");

    /// <summary>
    /// Kyrgyzstan
    /// </summary>
    public static readonly Country Kg = new("KG");

    /// <summary>
    /// Cambodia
    /// </summary>
    public static readonly Country Kh = new("KH");

    /// <summary>
    /// Kiribati
    /// </summary>
    public static readonly Country Ki = new("KI");

    /// <summary>
    /// Comoros
    /// </summary>
    public static readonly Country Km = new("KM");

    /// <summary>
    /// Saint Kitts and Nevis
    /// </summary>
    public static readonly Country Kn = new("KN");

    /// <summary>
    /// Democratic People's Republic of Korea
    /// </summary>
    public static readonly Country Kp = new("KP");

    /// <summary>
    /// Republic of Korea
    /// </summary>
    public static readonly Country Kr = new("KR");

    /// <summary>
    /// Kuwait
    /// </summary>
    public static readonly Country Kw = new("KW");

    /// <summary>
    /// Cayman Islands
    /// </summary>
    public static readonly Country Ky = new("KY");

    /// <summary>
    /// Kazakhstan
    /// </summary>
    public static readonly Country Kz = new("KZ");

    /// <summary>
    /// Lao People's Democratic Republic
    /// </summary>
    public static readonly Country La = new("LA");

    /// <summary>
    /// Lebanon
    /// </summary>
    public static readonly Country Lb = new("LB");

    /// <summary>
    /// Saint Lucia
    /// </summary>
    public static readonly Country Lc = new("LC");

    /// <summary>
    /// Liechtenstein
    /// </summary>
    public static readonly Country Li = new("LI");

    /// <summary>
    /// Sri Lanka
    /// </summary>
    public static readonly Country Lk = new("LK");

    /// <summary>
    /// Liberia
    /// </summary>
    public static readonly Country Lr = new("LR");

    /// <summary>
    /// Lesotho
    /// </summary>
    public static readonly Country Ls = new("LS");

    /// <summary>
    /// Lithuania
    /// </summary>
    public static readonly Country Lt = new("LT");

    /// <summary>
    /// Luxembourg
    /// </summary>
    public static readonly Country Lu = new("LU");

    /// <summary>
    /// Latvia
    /// </summary>
    public static readonly Country Lv = new("LV");

    /// <summary>
    /// Libya
    /// </summary>
    public static readonly Country Ly = new("LY");

    /// <summary>
    /// Morocco
    /// </summary>
    public static readonly Country Ma = new("MA");

    /// <summary>
    /// Monaco
    /// </summary>
    public static readonly Country Mc = new("MC");

    /// <summary>
    /// Moldova
    /// </summary>
    public static readonly Country Md = new("MD");

    /// <summary>
    /// Montenegro
    /// </summary>
    public static readonly Country Me = new("ME");

    /// <summary>
    /// Saint Martin
    /// </summary>
    public static readonly Country Mf = new("MF");

    /// <summary>
    /// Madagascar
    /// </summary>
    public static readonly Country Mg = new("MG");

    /// <summary>
    /// Marshall Islands
    /// </summary>
    public static readonly Country Mh = new("MH");

    /// <summary>
    /// North Macedonia
    /// </summary>
    public static readonly Country Mk = new("MK");

    /// <summary>
    /// Mali
    /// </summary>
    public static readonly Country Ml = new("ML");

    /// <summary>
    /// Myanmar
    /// </summary>
    public static readonly Country Mm = new("MM");

    /// <summary>
    /// Mongolia
    /// </summary>
    public static readonly Country Mn = new("MN");

    /// <summary>
    /// Macao
    /// </summary>
    public static readonly Country Mo = new("MO");

    /// <summary>
    /// Northern Mariana Islands
    /// </summary>
    public static readonly Country Mp = new("MP");

    /// <summary>
    /// Martinique
    /// </summary>
    public static readonly Country Mq = new("MQ");

    /// <summary>
    /// Mauritania
    /// </summary>
    public static readonly Country Mr = new("MR");

    /// <summary>
    /// Montserrat
    /// </summary>
    public static readonly Country Ms = new("MS");

    /// <summary>
    /// Malta
    /// </summary>
    public static readonly Country Mt = new("MT");

    /// <summary>
    /// Mauritius
    /// </summary>
    public static readonly Country Mu = new("MU");

    /// <summary>
    /// Maldives
    /// </summary>
    public static readonly Country Mv = new("MV");

    /// <summary>
    /// Malawi
    /// </summary>
    public static readonly Country Mw = new("MW");

    /// <summary>
    /// Mexico
    /// </summary>
    public static readonly Country Mx = new("MX");

    /// <summary>
    /// Malaysia
    /// </summary>
    public static readonly Country My = new("MY");

    /// <summary>
    /// Mozambique
    /// </summary>
    public static readonly Country Mz = new("MZ");

    /// <summary>
    /// Namibia
    /// </summary>
    public static readonly Country Na = new("NA");

    /// <summary>
    /// New Caledonia
    /// </summary>
    public static readonly Country Nc = new("NC");

    /// <summary>
    /// Niger
    /// </summary>
    public static readonly Country Ne = new("NE");

    /// <summary>
    /// Norfolk Island
    /// </summary>
    public static readonly Country Nf = new("NF");

    /// <summary>
    /// Nigeria
    /// </summary>
    public static readonly Country Ng = new("NG");

    /// <summary>
    /// Nicaragua
    /// </summary>
    public static readonly Country Ni = new("NI");

    /// <summary>
    /// Netherlands
    /// </summary>
    public static readonly Country Nl = new("NL");

    /// <summary>
    /// Norway
    /// </summary>
    public static readonly Country No = new("NO");

    /// <summary>
    /// Nepal
    /// </summary>
    public static readonly Country Np = new("NP");

    /// <summary>
    /// Nauru
    /// </summary>
    public static readonly Country Nr = new("NR");

    /// <summary>
    /// Niue
    /// </summary>
    public static readonly Country Nu = new("NU");

    /// <summary>
    /// New Zealand
    /// </summary>
    public static readonly Country Nz = new("NZ");

    /// <summary>
    /// Oman
    /// </summary>
    public static readonly Country Om = new("OM");

    /// <summary>
    /// Panama
    /// </summary>
    public static readonly Country Pa = new("PA");

    /// <summary>
    /// Peru
    /// </summary>
    public static readonly Country Pe = new("PE");

    /// <summary>
    /// French Polynesia
    /// </summary>
    public static readonly Country Pf = new("PF");

    /// <summary>
    /// Papua New Guinea
    /// </summary>
    public static readonly Country Pg = new("PG");

    /// <summary>
    /// Philippines
    /// </summary>
    public static readonly Country Ph = new("PH");

    /// <summary>
    /// Pakistan
    /// </summary>
    public static readonly Country Pk = new("PK");

    /// <summary>
    /// Poland
    /// </summary>
    public static readonly Country Pl = new("PL");

    /// <summary>
    /// Saint Pierre and Miquelon
    /// </summary>
    public static readonly Country Pm = new("PM");

    /// <summary>
    /// Pitcairn
    /// </summary>
    public static readonly Country Pn = new("PN");

    /// <summary>
    /// Puerto Rico
    /// </summary>
    public static readonly Country Pr = new("PR");

    /// <summary>
    /// Palestine
    /// </summary>
    public static readonly Country Ps = new("PS");

    /// <summary>
    /// Portugal
    /// </summary>
    public static readonly Country Pt = new("PT");

    /// <summary>
    /// Palau
    /// </summary>
    public static readonly Country Pw = new("PW");

    /// <summary>
    /// Paraguay
    /// </summary>
    public static readonly Country Py = new("PY");

    /// <summary>
    /// Qatar
    /// </summary>
    public static readonly Country Qa = new("QA");

    /// <summary>
    /// Réunion
    /// </summary>
    public static readonly Country Re = new("RE");

    /// <summary>
    /// Romania
    /// </summary>
    public static readonly Country Ro = new("RO");

    /// <summary>
    /// Serbia
    /// </summary>
    public static readonly Country Rs = new("RS");

    /// <summary>
    /// Russia
    /// </summary>
    public static readonly Country Ru = new("RU");

    /// <summary>
    /// Rwanda
    /// </summary>
    public static readonly Country Rw = new("RW");

    /// <summary>
    /// Saudi Arabia
    /// </summary>
    public static readonly Country Sa = new("SA");

    /// <summary>
    /// Solomon Islands
    /// </summary>
    public static readonly Country Sb = new("SB");

    /// <summary>
    /// Seychelles
    /// </summary>
    public static readonly Country Sc = new("SC");

    /// <summary>
    /// Sudan
    /// </summary>
    public static readonly Country Sd = new("SD");

    /// <summary>
    /// Sweden
    /// </summary>
    public static readonly Country Se = new("SE");

    /// <summary>
    /// Singapore
    /// </summary>
    public static readonly Country Sg = new("SG");

    /// <summary>
    /// Saint Helena, Ascension and Tristan da Cunha
    /// </summary>
    public static readonly Country Sh = new("SH");

    /// <summary>
    /// Slovenia
    /// </summary>
    public static readonly Country Si = new("SI");

    /// <summary>
    /// Svalbard and Jan Mayen
    /// </summary>
    public static readonly Country Sj = new("SJ");

    /// <summary>
    /// Slovakia
    /// </summary>
    public static readonly Country Sk = new("SK");

    /// <summary>
    /// Sierra Leone
    /// </summary>
    public static readonly Country Sl = new("SL");

    /// <summary>
    /// San Marino
    /// </summary>
    public static readonly Country Sm = new("SM");

    /// <summary>
    /// Senegal
    /// </summary>
    public static readonly Country Sn = new("SN");

    /// <summary>
    /// Somalia
    /// </summary>
    public static readonly Country So = new("SO");

    /// <summary>
    /// Suriname
    /// </summary>
    public static readonly Country Sr = new("SR");

    /// <summary>
    /// South Sudan
    /// </summary>
    public static readonly Country Ss = new("SS");

    /// <summary>
    /// Sao Tome and Principe
    /// </summary>
    public static readonly Country St = new("ST");

    /// <summary>
    /// El Salvador
    /// </summary>
    public static readonly Country Sv = new("SV");

    /// <summary>
    /// Sint Maarten
    /// </summary>
    public static readonly Country Sx = new("SX");

    /// <summary>
    /// Syrian Arab Republic
    /// </summary>
    public static readonly Country Sy = new("SY");

    /// <summary>
    /// Eswatini
    /// </summary>
    public static readonly Country Sz = new("SZ");

    /// <summary>
    /// Turks and Caicos Islands
    /// </summary>
    public static readonly Country Tc = new("TC");

    /// <summary>
    /// Chad
    /// </summary>
    public static readonly Country Td = new("TD");

    /// <summary>
    /// French Southern Territories
    /// </summary>
    public static readonly Country Tf = new("TF");

    /// <summary>
    /// Togo
    /// </summary>
    public static readonly Country Tg = new("TG");

    /// <summary>
    /// Thailand
    /// </summary>
    public static readonly Country Th = new("TH");

    /// <summary>
    /// Tajikistan
    /// </summary>
    public static readonly Country Tj = new("TJ");

    /// <summary>
    /// Tokelau
    /// </summary>
    public static readonly Country Tk = new("TK");

    /// <summary>
    /// Timor-Leste
    /// </summary>
    public static readonly Country Tl = new("TL");

    /// <summary>
    /// Turkmenistan
    /// </summary>
    public static readonly Country Tm = new("TM");

    /// <summary>
    /// Tunisia
    /// </summary>
    public static readonly Country Tn = new("TN");

    /// <summary>
    /// Tonga
    /// </summary>
    public static readonly Country To = new("TO");

    /// <summary>
    /// Turkey
    /// </summary>
    public static readonly Country Tr = new("TR");

    /// <summary>
    /// Trinidad and Tobago
    /// </summary>
    public static readonly Country Tt = new("TT");

    /// <summary>
    /// Tuvalu
    /// </summary>
    public static readonly Country Tv = new("TV");

    /// <summary>
    /// Taiwan
    /// </summary>
    public static readonly Country Tw = new("TW");

    /// <summary>
    /// Tanzania
    /// </summary>
    public static readonly Country Tz = new("TZ");

    /// <summary>
    /// Ukraine
    /// </summary>
    public static readonly Country Ua = new("UA");

    /// <summary>
    /// Uganda
    /// </summary>
    public static readonly Country Ug = new("UG");

    /// <summary>
    /// United States Minor Outlying Islands
    /// </summary>
    public static readonly Country Um = new("UM");

    /// <summary>
    /// United States of America
    /// </summary>
    public static readonly Country Us = new("US");

    /// <summary>
    /// Uruguay
    /// </summary>
    public static readonly Country Uy = new("UY");

    /// <summary>
    /// Uzbekistan
    /// </summary>
    public static readonly Country Uz = new("UZ");

    /// <summary>
    /// Vatican City
    /// </summary>
    public static readonly Country Va = new("VA");

    /// <summary>
    /// Saint Vincent and the Grenadines
    /// </summary>
    public static readonly Country Vc = new("VC");

    /// <summary>
    /// Venezuela
    /// </summary>
    public static readonly Country Ve = new("VE");

    /// <summary>
    /// British Virgin Islands
    /// </summary>
    public static readonly Country Vg = new("VG");

    /// <summary>
    /// U.S. Virgin Islands
    /// </summary>
    public static readonly Country Vi = new("VI");

    /// <summary>
    /// Vietnam
    /// </summary>
    public static readonly Country Vn = new("VN");

    /// <summary>
    /// Vanuatu
    /// </summary>
    public static readonly Country Vu = new("VU");

    /// <summary>
    /// Wallis and Futuna
    /// </summary>
    public static readonly Country Wf = new("WF");

    /// <summary>
    /// Samoa
    /// </summary>
    public static readonly Country Ws = new("WS");

    /// <summary>
    /// Yemen
    /// </summary>
    public static readonly Country Ye = new("YE");

    /// <summary>
    /// Mayotte
    /// </summary>
    public static readonly Country Yt = new("YT");

    /// <summary>
    /// South Africa
    /// </summary>
    public static readonly Country Za = new("ZA");

    /// <summary>
    /// Zambia
    /// </summary>
    public static readonly Country Zm = new("ZM");

    /// <summary>
    /// Zimbabwe
    /// </summary>
    public static readonly Country Zw = new("ZW");

    public static Country FromValue(string value) => FromValueCore(value);
}
