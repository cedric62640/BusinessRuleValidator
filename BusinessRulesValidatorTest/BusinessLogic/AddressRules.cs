using BusinessRulesValidator;
using BusinessRulesValidatorTest.BusinessObjects;
using System;

namespace BusinessRulesValidatorTest.BusinessLogic
{
    /// <summary>
    /// Classe contenant l'ensemble des règles de validation d'une adresse
    /// </summary>
    public class AddressRules<T> : RulesCore<T> 
        where T : InputData
    {
        #region predicates
        Func<T, bool> wayNumberEquals0 = (obj) => obj.AddressData.WayNumber == 0;
        Func<T, bool> wayNameLengthTooLong = (obj) => !string.IsNullOrEmpty(obj.AddressData.WayName) && obj.AddressData.WayName.Length > 32;
        #endregion

        #region constructors
        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public AddressRules()
        {
            Rules.Add(new Tuple<Func<T, bool>, ValidationError>(wayNumberEquals0, new ValidationError(1, "Le numéro de rue ne peut être égal à 0")));
            Rules.Add(new Tuple<Func<T, bool>, ValidationError>(wayNameLengthTooLong, new ValidationError(2, "Le nom de la rue est trop long")));
        }
        #endregion
    }
}
