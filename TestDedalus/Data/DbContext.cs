using Microsoft.EntityFrameworkCore;
using RestSharp;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Xml.Linq;
using TestDedalus.Models;

namespace TestDedalus.Data
{
    public class TestDedalusContext : DbContext
    {
        public TestDedalusContext(DbContextOptions<TestDedalusContext> options) : base(options)
        { }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Capital> Capitals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
#if DEBUG
            optionsBuilder.EnableSensitiveDataLogging();
#endif
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // aquí se pueden meter datos por defecto en la BD

            modelBuilder.Entity<Country>().ToTable("Countries");
            modelBuilder.Entity<Capital>().ToTable("Capitals");

            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    CountryId = "AX",
                    CountryName = "Åland Islands"
                },
                new Country
                {
                    CountryId = "AF",
                    CountryName = "Afghanistan"
                },
                new Country
                {
                    CountryId = "AL",
                    CountryName = "Albania"
                },
                new Country
                {
                    CountryId = "DZ",
                    CountryName = "Algeria"
                },
                new Country
                {
                    CountryId = "AS",
                    CountryName = "American Samoa"
                },
                new Country
                {
                    CountryId = "AD",
                    CountryName = "Andorra"
                },
                new Country
                {
                    CountryId = "AO",
                    CountryName = "Angola"
                },
                new Country
                {
                    CountryId = "AI",
                    CountryName = "Anguilla"
                },
                new Country
                {
                    CountryId = "AQ",
                    CountryName = "Antarctica"
                },
                new Country
                {
                    CountryId = "AG",
                    CountryName = "Antigua & Barbuda"
                },
                new Country
                {
                    CountryId = "AR",
                    CountryName = "Argentina"
                },
                new Country
                {
                    CountryId = "AM",
                    CountryName = "Armenia"
                },
                new Country
                {
                    CountryId = "AW",
                    CountryName = "Aruba"
                },
                new Country
                {
                    CountryId = "AU",
                    CountryName = "Australia"
                },
                new Country
                {
                    CountryId = "AT",
                    CountryName = "Austria"
                },
                new Country
                {
                    CountryId = "AZ",
                    CountryName = "Azerbaijan"
                },
                new Country
                {
                    CountryId = "BS",
                    CountryName = "Bahamas"
                },
                new Country
                {
                    CountryId = "BH",
                    CountryName = "Bahrain"
                },
                new Country
                {
                    CountryId = "BD",
                    CountryName = "Bangladesh"
                },
                new Country
                {
                    CountryId = "BB",
                    CountryName = "Barbados"
                },
                new Country
                {
                    CountryId = "BY",
                    CountryName = "Belarus"
                },
                new Country
                {
                    CountryId = "BE",
                    CountryName = "Belgium"
                },
                new Country
                {
                    CountryId = "BZ",
                    CountryName = "Belize"
                },
                new Country
                {
                    CountryId = "BJ",
                    CountryName = "Benin"
                },
                new Country
                {
                    CountryId = "BM",
                    CountryName = "Bermuda"
                },
                new Country
                {
                    CountryId = "BT",
                    CountryName = "Bhutan"
                },
                new Country
                {
                    CountryId = "BO",
                    CountryName = "Bolivia"
                },
                new Country
                {
                    CountryId = "BQ",
                    CountryName = "Bonaire, Sint Eustatius and Saba"
                },
                new Country
                {
                    CountryId = "BA",
                    CountryName = "Bosnia & Herzegovina"
                },
                new Country
                {
                    CountryId = "BW",
                    CountryName = "Botswana"
                },
                new Country
                {
                    CountryId = "BV",
                    CountryName = "Bouvet Island"
                },
                new Country
                {
                    CountryId = "BR",
                    CountryName = "Brazil"
                },
                new Country
                {
                    CountryId = "IO",
                    CountryName = "Britsh Indian Ocean Territory"
                },
                new Country
                {
                    CountryId = "BN",
                    CountryName = "Brunei-Darussalam"
                },
                new Country
                {
                    CountryId = "BG",
                    CountryName = "Bulgaria"
                },
                new Country
                {
                    CountryId = "BF",
                    CountryName = "Burkina Faso"
                },
                new Country
                {
                    CountryId = "BI",
                    CountryName = "Burundi"
                },
                new Country
                {
                    CountryId = "CI",
                    CountryName = "Côte D'Ivoire (Ivory Coast)"
                },
                new Country
                {
                    CountryId = "KH",
                    CountryName = "Cambodia"
                },
                new Country
                {
                    CountryId = "CM",
                    CountryName = "Cameroon"
                },
                new Country
                {
                    CountryId = "CA",
                    CountryName = "Canada"
                },
                new Country
                {
                    CountryId = "CV",
                    CountryName = "Cape Verde"
                },
                new Country
                {
                    CountryId = "KY",
                    CountryName = "Cayman Islands"
                },
                new Country
                {
                    CountryId = "CF",
                    CountryName = "Central African Republic"
                },
                new Country
                {
                    CountryId = "TD",
                    CountryName = "Chad"
                },
                new Country
                {
                    CountryId = "CL",
                    CountryName = "Chile"
                },
                new Country
                {
                    CountryId = "CN",
                    CountryName = "China"
                },
                new Country
                {
                    CountryId = "CX",
                    CountryName = "Chrismas Island"
                },
                new Country
                {
                    CountryId = "CC",
                    CountryName = "Cocos (Keeling) Islands"
                },
                new Country
                {
                    CountryId = "MF",
                    CountryName = "Collectivity of Saint Martin"
                },
                new Country
                {
                    CountryId = "CO",
                    CountryName = "Colombia"
                },
                new Country
                {
                    CountryId = "KM",
                    CountryName = "Comoros"
                },
                new Country
                {
                    CountryId = "CG",
                    CountryName = "Congo"
                },
                new Country
                {
                    CountryId = "CD",
                    CountryName = "Congo, Democratic Republic"
                },
                new Country
                {
                    CountryId = "CK",
                    CountryName = "Cook Islands"
                },
                new Country
                {
                    CountryId = "CR",
                    CountryName = "Costa Rica"
                },
                new Country
                {
                    CountryId = "HR",
                    CountryName = "Croatia"
                },
                new Country
                {
                    CountryId = "CU",
                    CountryName = "Cuba"
                },
                new Country
                {
                    CountryId = "CW",
                    CountryName = "Curaçao"
                },
                new Country
                {
                    CountryId = "CY",
                    CountryName = "Cyprus"
                },
                new Country
                {
                    CountryId = "CZ",
                    CountryName = "Czech Republic"
                },
                new Country
                {
                    CountryId = "DK",
                    CountryName = "Denmark"
                },
                new Country
                {
                    CountryId = "DJ",
                    CountryName = "Djibouti"
                },
                new Country
                {
                    CountryId = "DM",
                    CountryName = "Dominica"
                },
                new Country
                {
                    CountryId = "DO",
                    CountryName = "Dominican Republic"
                },
                new Country
                {
                    CountryId = "EC",
                    CountryName = "Ecuador"
                },
                new Country
                {
                    CountryId = "EG",
                    CountryName = "Egypt"
                },
                new Country
                {
                    CountryId = "SV",
                    CountryName = "El Salvador"
                },
                new Country
                {
                    CountryId = "GQ",
                    CountryName = "Equatorial Guinea"
                },
                new Country
                {
                    CountryId = "ER",
                    CountryName = "Eritrea"
                },
                new Country
                {
                    CountryId = "EE",
                    CountryName = "Estonia"
                },
                new Country
                {
                    CountryId = "ET",
                    CountryName = "Ethiopia"
                },
                new Country
                {
                    CountryId = "FK",
                    CountryName = "Falkand Islands (Malvinas)"
                },
                new Country
                {
                    CountryId = "FO",
                    CountryName = "Faroe Islands"
                },
                new Country
                {
                    CountryId = "FJ",
                    CountryName = "Fiji"
                },
                new Country
                {
                    CountryId = "FI",
                    CountryName = "Finland"
                },
                new Country
                {
                    CountryId = "FR",
                    CountryName = "France"
                },
                new Country
                {
                    CountryId = "GF",
                    CountryName = "French Guiana"
                },
                new Country
                {
                    CountryId = "PF",
                    CountryName = "French Polynesia"
                },
                new Country
                {
                    CountryId = "TF",
                    CountryName = "French Southern Territories"
                },
                new Country
                {
                    CountryId = "GA",
                    CountryName = "Gabon"
                },
                new Country
                {
                    CountryId = "GM",
                    CountryName = "Gambia"
                },
                new Country
                {
                    CountryId = "GE",
                    CountryName = "Georgia"
                },
                new Country
                {
                    CountryId = "DE",
                    CountryName = "Germany"
                },
                new Country
                {
                    CountryId = "GH",
                    CountryName = "Ghana"
                },
                new Country
                {
                    CountryId = "GI",
                    CountryName = "Gibraltar"
                },
                new Country
                {
                    CountryId = "GR",
                    CountryName = "Greece"
                },
                new Country
                {
                    CountryId = "GL",
                    CountryName = "Greenland"
                },
                new Country
                {
                    CountryId = "GD",
                    CountryName = "Grenada"
                },
                new Country
                {
                    CountryId = "GP",
                    CountryName = "Guadeloupe"
                },
                new Country
                {
                    CountryId = "GU",
                    CountryName = "Guam"
                },
                new Country
                {
                    CountryId = "GT",
                    CountryName = "Guatemala"
                },
                new Country
                {
                    CountryId = "GN",
                    CountryName = "Guinea"
                },
                new Country
                {
                    CountryId = "GW",
                    CountryName = "Guinea-Bissau"
                },
                new Country
                {
                    CountryId = "GY",
                    CountryName = "Guyana"
                },
                new Country
                {
                    CountryId = "HT",
                    CountryName = "Haiti"
                },
                new Country
                {
                    CountryId = "HM",
                    CountryName = "Heard Island And McDonald Islands"
                },
                new Country
                {
                    CountryId = "HN",
                    CountryName = "Honduras"
                },
                new Country
                {
                    CountryId = "HK",
                    CountryName = "Hong Kong"
                },
                new Country
                {
                    CountryId = "HU",
                    CountryName = "Hungary"
                },
                new Country
                {
                    CountryId = "IS",
                    CountryName = "Iceland"
                },
                new Country
                {
                    CountryId = "IN",
                    CountryName = "India"
                },
                new Country
                {
                    CountryId = "ID",
                    CountryName = "Indonesia"
                },
                new Country
                {
                    CountryId = "IR",
                    CountryName = "Iran"
                },
                new Country
                {
                    CountryId = "IQ",
                    CountryName = "Iraq"
                },
                new Country
                {
                    CountryId = "IE",
                    CountryName = "Ireland"
                },
                new Country
                {
                    CountryId = "IL",
                    CountryName = "Israel"
                },
                new Country
                {
                    CountryId = "IT",
                    CountryName = "Italy"
                },
                new Country
                {
                    CountryId = "JM",
                    CountryName = "Jamaica"
                },
                new Country
                {
                    CountryId = "JP",
                    CountryName = "Japan"
                },
                new Country
                {
                    CountryId = "JO",
                    CountryName = "Jordan"
                },
                new Country
                {
                    CountryId = "KZ",
                    CountryName = "Kazakhstan"
                },
                new Country
                {
                    CountryId = "KE",
                    CountryName = "Kenya"
                },
                new Country
                {
                    CountryId = "KI",
                    CountryName = "Kiribati"
                },
                new Country
                {
                    CountryId = "KW",
                    CountryName = "Kuwait"
                },
                new Country
                {
                    CountryId = "KG",
                    CountryName = "Kyrgyzstan"
                },
                new Country
                {
                    CountryId = "LA",
                    CountryName = "Laos"
                },
                new Country
                {
                    CountryId = "LV",
                    CountryName = "Latvia"
                },
                new Country
                {
                    CountryId = "LB",
                    CountryName = "Lebanon"
                },
                new Country
                {
                    CountryId = "LS",
                    CountryName = "Lesotho"
                },
                new Country
                {
                    CountryId = "LR",
                    CountryName = "Liberia"
                },
                new Country
                {
                    CountryId = "LY",
                    CountryName = "Libyan Arab Jamahiriya"
                },
                new Country
                {
                    CountryId = "LI",
                    CountryName = "Liechtenstein"
                },
                new Country
                {
                    CountryId = "LT",
                    CountryName = "Lithuania"
                },
                new Country
                {
                    CountryId = "LU",
                    CountryName = "Luxembourg"
                },
                new Country
                {
                    CountryId = "MO",
                    CountryName = "Macao"
                },
                new Country
                {
                    CountryId = "MK",
                    CountryName = "Macedonia (former YR)"
                },
                new Country
                {
                    CountryId = "MG",
                    CountryName = "Madagascar"
                },
                new Country
                {
                    CountryId = "MW",
                    CountryName = "Malawi"
                },
                new Country
                {
                    CountryId = "MY",
                    CountryName = "Malaysia"
                },
                new Country
                {
                    CountryId = "MV",
                    CountryName = "Maldives (Maladive Ilands)"
                },
                new Country
                {
                    CountryId = "ML",
                    CountryName = "Mali"
                },
                new Country
                {
                    CountryId = "MT",
                    CountryName = "Malta"
                },
                new Country
                {
                    CountryId = "MH",
                    CountryName = "Marshall Islands"
                },
                new Country
                {
                    CountryId = "MQ",
                    CountryName = "Martinique"
                },
                new Country
                {
                    CountryId = "MR",
                    CountryName = "Mauritania"
                },
                new Country
                {
                    CountryId = "MU",
                    CountryName = "Mauritius"
                },
                new Country
                {
                    CountryId = "YT",
                    CountryName = "Mayotte"
                },
                new Country
                {
                    CountryId = "MX",
                    CountryName = "Mexico"
                },
                new Country
                {
                    CountryId = "FM",
                    CountryName = "Micronesia (Federa States of)"
                },
                new Country
                {
                    CountryId = "MD",
                    CountryName = "Moldova, Republic of"
                },
                new Country
                {
                    CountryId = "MC",
                    CountryName = "Monaco"
                },
                new Country
                {
                    CountryId = "MN",
                    CountryName = "Mongolia"
                },
                new Country
                {
                    CountryId = "ME",
                    CountryName = "Montenegro"
                },
                new Country
                {
                    CountryId = "MS",
                    CountryName = "Montserrat"
                },
                new Country
                {
                    CountryId = "MA",
                    CountryName = "Morocco"
                },
                new Country
                {
                    CountryId = "MZ",
                    CountryName = "Mozambique"
                },
                new Country
                {
                    CountryId = "MM",
                    CountryName = "Myanmar (Burma)"
                },
                new Country
                {
                    CountryId = "NA",
                    CountryName = "Namibia"
                },
                new Country
                {
                    CountryId = "NR",
                    CountryName = "Nauru"
                },
                new Country
                {
                    CountryId = "NP",
                    CountryName = "Nepal"
                },
                new Country
                {
                    CountryId = "NL",
                    CountryName = "Netherlands"
                },
                new Country
                {
                    CountryId = "AN",
                    CountryName = "Netherlands Antilles"
                },
                new Country
                {
                    CountryId = "NC",
                    CountryName = "New Caledonia"
                },
                new Country
                {
                    CountryId = "NZ",
                    CountryName = "New Zealand"
                },
                new Country
                {
                    CountryId = "NI",
                    CountryName = "Nicaragua"
                },
                new Country
                {
                    CountryId = "NE",
                    CountryName = "Niger"
                },
                new Country
                {
                    CountryId = "NG",
                    CountryName = "Nigeria"
                },
                new Country
                {
                    CountryId = "NU",
                    CountryName = "Niue"
                },
                new Country
                {
                    CountryId = "NF",
                    CountryName = "Norfolk Island"
                },
                new Country
                {
                    CountryId = "KP",
                    CountryName = "North Korea"
                },
                new Country
                {
                    CountryId = "MP",
                    CountryName = "Northern Mariana Islands"
                },
                new Country
                {
                    CountryId = "NO",
                    CountryName = "Norway"
                },
                new Country
                {
                    CountryId = "OM",
                    CountryName = "Oman"
                },
                new Country
                {
                    CountryId = "PK",
                    CountryName = "Pakistan"
                },
                new Country
                {
                    CountryId = "PW",
                    CountryName = "Palau"
                },
                new Country
                {
                    CountryId = "PS",
                    CountryName = "Palestinian Territory, Occupied"
                },
                new Country
                {
                    CountryId = "PA",
                    CountryName = "Panama"
                },
                new Country
                {
                    CountryId = "PG",
                    CountryName = "Papua-New Guinea"
                },
                new Country
                {
                    CountryId = "PY",
                    CountryName = "Paraguay"
                },
                new Country
                {
                    CountryId = "PE",
                    CountryName = "Peru"
                },
                new Country
                {
                    CountryId = "PH",
                    CountryName = "Philippines"
                },
                new Country
                {
                    CountryId = "PN",
                    CountryName = "Pitcairn"
                },
                new Country
                {
                    CountryId = "PL",
                    CountryName = "Poland"
                },
                new Country
                {
                    CountryId = "PT",
                    CountryName = "Portugal"
                },
                new Country
                {
                    CountryId = "PR",
                    CountryName = "Puerto Rico"
                },
                new Country
                {
                    CountryId = "QA",
                    CountryName = "Quatar"
                },
                new Country
                {
                    CountryId = "RE",
                    CountryName = "Reunion"
                },
                new Country
                {
                    CountryId = "RO",
                    CountryName = "Romania"
                },
                new Country
                {
                    CountryId = "RU",
                    CountryName = "Russian Federation"
                },
                new Country
                {
                    CountryId = "RW",
                    CountryName = "Rwanda"
                },
                new Country
                {
                    CountryId = "BL",
                    CountryName = "Saint Barthélemy"
                },
                new Country
                {
                    CountryId = "SH",
                    CountryName = "Saint Helena, Ascension and Tristan da Cunha"
                },
                new Country
                {
                    CountryId = "PM",
                    CountryName = "Saint Pierre And Micquelon"
                },
                new Country
                {
                    CountryId = "SM",
                    CountryName = "San Marino"
                },
                new Country
                {
                    CountryId = "ST",
                    CountryName = "Sao Tome & Principe"
                },
                new Country
                {
                    CountryId = "SA",
                    CountryName = "Saudi Arabia"
                },
                new Country
                {
                    CountryId = "SN",
                    CountryName = "Senegal"
                },
                new Country
                {
                    CountryId = "RS",
                    CountryName = "Serbia"
                },
                new Country
                {
                    CountryId = "SC",
                    CountryName = "Seychelles"
                },
                new Country
                {
                    CountryId = "SL",
                    CountryName = "Sierra Leone"
                },
                new Country
                {
                    CountryId = "SG",
                    CountryName = "Singapore"
                },
                new Country
                {
                    CountryId = "SX",
                    CountryName = "Sint-Maarten"
                },
                new Country
                {
                    CountryId = "SK",
                    CountryName = "Slovakia"
                },
                new Country
                {
                    CountryId = "SI",
                    CountryName = "Slovenia"
                },
                new Country
                {
                    CountryId = "SB",
                    CountryName = "Solomon Islands"
                },
                new Country
                {
                    CountryId = "SO",
                    CountryName = "Somalia"
                },
                new Country
                {
                    CountryId = "ZA",
                    CountryName = "South Africa"
                },
                new Country
                {
                    CountryId = "GS",
                    CountryName = "South Georgia & South Sandwich Islands"
                },
                new Country
                {
                    CountryId = "KR",
                    CountryName = "South Korea"
                },
                new Country
                {
                    CountryId = "ES",
                    CountryName = "Spain"
                },
                new Country
                {
                    CountryId = "LK",
                    CountryName = "Sri Lanka"
                },
                new Country
                {
                    CountryId = "KN",
                    CountryName = "St. Kitts & Nevis"
                },
                new Country
                {
                    CountryId = "LC",
                    CountryName = "St. Lucia"
                },
                new Country
                {
                    CountryId = "VC",
                    CountryName = "St. Vincent & Grenadines"
                },
                new Country
                {
                    CountryId = "SD",
                    CountryName = "Sudan"
                },
                new Country
                {
                    CountryId = "SR",
                    CountryName = "Suriname"
                },
                new Country
                {
                    CountryId = "SJ",
                    CountryName = "Svalbard And Jan Mayen"
                },
                new Country
                {
                    CountryId = "SZ",
                    CountryName = "Swaziland"
                },
                new Country
                {
                    CountryId = "SE",
                    CountryName = "Sweden"
                },
                new Country
                {
                    CountryId = "CH",
                    CountryName = "Switzerland"
                },
                new Country
                {
                    CountryId = "SY",
                    CountryName = "Syrian Arab Republic"
                },
                new Country
                {
                    CountryId = "TW",
                    CountryName = "Taiwan"
                },
                new Country
                {
                    CountryId = "TJ",
                    CountryName = "Tajikistan"
                },
                new Country
                {
                    CountryId = "TZ",
                    CountryName = "Tanzania"
                },
                new Country
                {
                    CountryId = "TH",
                    CountryName = "Thailand"
                },
                new Country
                {
                    CountryId = "TL",
                    CountryName = "Timor-Leste"
                },
                new Country
                {
                    CountryId = "TG",
                    CountryName = "Togo"
                },
                new Country
                {
                    CountryId = "TK",
                    CountryName = "Tokelau"
                },
                new Country
                {
                    CountryId = "TO",
                    CountryName = "Tonga"
                },
                new Country
                {
                    CountryId = "TT",
                    CountryName = "Trinidad & Tobago"
                },
                new Country
                {
                    CountryId = "TN",
                    CountryName = "Tunisia"
                },
                new Country
                {
                    CountryId = "TR",
                    CountryName = "Turkey"
                },
                new Country
                {
                    CountryId = "TM",
                    CountryName = "Turkmenistan"
                },
                new Country
                {
                    CountryId = "TC",
                    CountryName = "Turks And Caicos Islands"
                },
                new Country
                {
                    CountryId = "TV",
                    CountryName = "Tuvalu"
                },
                new Country
                {
                    CountryId = "UG",
                    CountryName = "Uganda"
                },
                new Country
                {
                    CountryId = "UA",
                    CountryName = "Ukraine"
                },
                new Country
                {
                    CountryId = "AE",
                    CountryName = "United Arab Emirates"
                },
                new Country
                {
                    CountryId = "GB",
                    CountryName = "United Kingdom"
                },
                new Country
                {
                    CountryId = "US",
                    CountryName = "United States"
                },
                new Country
                {
                    CountryId = "UM",
                    CountryName = "United States Minor Outlying Islands"
                },
                new Country
                {
                    CountryId = "UY",
                    CountryName = "Uruguay"
                },
                new Country
                {
                    CountryId = "UZ",
                    CountryName = "Uzbekistan"
                },
                new Country
                {
                    CountryId = "VU",
                    CountryName = "Vanuatu"
                },
                new Country
                {
                    CountryId = "VA",
                    CountryName = "Vatican City"
                },
                new Country
                {
                    CountryId = "VE",
                    CountryName = "Venezuela"
                },
                new Country
                {
                    CountryId = "VN",
                    CountryName = "Vietnam"
                },
                new Country
                {
                    CountryId = "VG",
                    CountryName = "Virgin Islands, British"
                },
                new Country
                {
                    CountryId = "VI",
                    CountryName = "Virgin Islands, U.S."
                },
                new Country
                {
                    CountryId = "WF",
                    CountryName = "Wallis And Futuna"
                },
                new Country
                {
                    CountryId = "EH",
                    CountryName = "Western Sahara"
                },
                new Country
                {
                    CountryId = "WS",
                    CountryName = "Western Samoa"
                },
                new Country
                {
                    CountryId = "YE",
                    CountryName = "Yemen"
                },
                new Country
                {
                    CountryId = "ZM",
                    CountryName = "Zambia"
                },
                new Country
                {
                    CountryId = "ZW",
                    CountryName = "Zimbabwe"
                }
            );

            int i = 1; // para el código de capital, por ponerle un autonumérico

            // poblamos una lista de capitales sacándolas directamente del WS, para luego introducirlas en la BD
            var capitalCitiesList = new List<Capital>();

            // también tenemos que poblar una lista de los países, aunque ya tengamos su modelo creado, porque no puede acceder a él aún
            // podía haber hecho esto para crear los países en su momento? sí.
            var countriesList = new List<FakeCountry>();

            string countryListUrl = "http://webservices.oorsprong.org/websamples.countryinfo/CountryInfoService.wso/ListOfCountryNamesByName";
            string html = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(countryListUrl);

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
            }

            var document = XDocument.Load(countryListUrl);

            var children = document.Descendants().Where(node => node.Name == "tCountryCodeAndName");

            foreach (var child in children)
            {
                countriesList.Add(
                    new FakeCountry
                    {
                        CountryId = child.Elements().First().Value,
                        CountryName = child.Elements().Last().Value
                    }
                );
            }

            //foreach (var country in Countries) // esto no se puede hacer porque no se debe acceder al modelo durante su creación
            foreach (var country in countriesList)
            {
                var client = new RestClient("http://webservices.oorsprong.org/websamples.countryinfo/CountryInfoService.wso?op=CapitalCity");
                var request2 = new RestRequest(Method.POST);
                //request.AddHeader("postman-token", "73177c85-6b10-ab52-2b67-09e2ddedfda1");
                //request.AddHeader("cache-control", "no-cache");
                request2.AddHeader("content-type", "application/soap+xml");
                request2.AddParameter(
                    "application/soap+xml",

                    "<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n" +
                    "<soap12:Envelope xmlns:soap12=\"http://www.w3.org/2003/05/soap-envelope\">\r\n" +
                    "  <soap12:Body>\r\n" +
                    "    <CapitalCity xmlns=\"http://www.oorsprong.org/websamples.countryinfo\">\r\n" +
                    "      <sCountryISOCode>" + country.CountryId + "</sCountryISOCode>\r\n" +
                    "    </CapitalCity>\r\n" +
                    "  </soap12:Body>\r\n" +
                    "</soap12:Envelope>",

                    ParameterType.RequestBody
                );

                IRestResponse response = client.Execute(request2);

                //cutre pero funciona
                string countryCapitalName = response.Content.Substring(response.Content.IndexOf("<m:CapitalCityResult>") + 21, response.Content.IndexOf("</m:CapitalCityResult>") - response.Content.IndexOf("<m:CapitalCityResult>") - 21);

                capitalCitiesList.Add(
                    new Capital
                    {
                        CapitalId = i.ToString().PadLeft(3, '0'),
                        CapitalName = countryCapitalName,
                        CountryId = country.CountryId
                    }
                );

                i++;
            }

            //insertamos todas las capitales a la vez
            modelBuilder.Entity<Capital>().HasData(
                new List<Capital>(capitalCitiesList)
            );
        }
    }
}
