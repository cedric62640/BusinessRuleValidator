using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessRulesValidatorTest.BusinessObjects
{
    /// <summary>
    /// Données d'une adresse
    /// </summary>
    public class Address : IAddress
    {
        #region properties
        /// <summary>
        /// Numéro de rue
        /// </summary>
        public int WayNumber { get; set; }

        /// <summary>
        /// Nom de la rue
        /// </summary>
        public string WayName { get; set; }

        /// <summary>
        /// Ville
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Code Postal
        /// </summary>
        public string ZipCode { get; set; }

        /// <summary>
        /// Code pays
        /// </summary>
        public string CountryCode { get; set; }

        /// <summary>
        /// Ligne d'adresse postal 1
        /// </summary>
        public string PostalAddressLine1 { get; set; }

        /// <summary>
        /// Ligne d'adresse postal 2
        /// </summary>
        public string PostalAddressLine2 { get; set; }

        /// <summary>
        /// Ligne d'adresse postal 3
        /// </summary>
        public string PostalAddressLine3 { get; set; }

        /// <summary>
        /// Ligne d'adresse postal 4
        /// </summary>
        public string PostalAddressLine4 { get; set; }

        /// <summary>
        /// Ligne d'adresse postal 5
        /// </summary>
        public string PostalAddressLine5 { get; set; }

        /// <summary>
        /// Ligne d'adresse postal 6
        /// </summary>
        public string PostalAddressLine6 { get; set; }
        #endregion
    }
}
