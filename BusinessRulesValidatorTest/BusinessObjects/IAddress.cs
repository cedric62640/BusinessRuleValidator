namespace BusinessRulesValidatorTest.BusinessObjects
{
    /// <summary>
    /// Données d'une adresse
    /// </summary>
    public interface IAddress
    {
        /// <summary>
        /// Ville
        /// </summary>
        string City { get; set; }

        /// <summary>
        /// Code pays
        /// </summary>
        string CountryCode { get; set; }

        /// <summary>
        /// Nom de la rue
        /// </summary>
        string WayName { get; set; }

        /// <summary>
        /// Numéro de rue
        /// </summary>
        int WayNumber { get; set; }

        /// <summary>
        /// Code postal
        /// </summary>
        string ZipCode { get; set; }
    }
}