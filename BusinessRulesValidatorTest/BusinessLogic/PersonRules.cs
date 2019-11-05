using BusinessRulesValidator;
using BusinessRulesValidatorTest.BusinessObjects;
using System;

namespace BusinessRulesValidatorTest.BusinessLogic
{
    /// <summary>
    /// Classe contenant l'ensemble des règles de validation d'un individu
    /// </summary>
    public class PersonRules<T> : RulesCore<T>
        where T : InputData
    {
        #region predicates
        Func<T, bool> firstNameNotSet = (obj) => string.IsNullOrEmpty(obj.PersonData.FirstName);
        Func<T, bool> lastNameNotSet = (obj) => string.IsNullOrEmpty(obj.PersonData.LastName);
        #endregion

        #region constructors
        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public PersonRules()
        {
            Rules.Add(new Tuple<Func<T, bool>, ValidationError>(firstNameNotSet, new ValidationError(3, "Le prénom doit être renseigné")));
            Rules.Add(new Tuple<Func<T, bool>, ValidationError>(lastNameNotSet, new ValidationError(4, "Le nom doit être renseigné")));
        }
        #endregion
    }
}
