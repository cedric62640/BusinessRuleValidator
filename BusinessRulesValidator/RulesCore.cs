using System;
using System.Collections.Generic;

namespace BusinessRulesValidator
{
    /// <summary>
    /// Classe de base definissant les règles de validation
    /// </summary>
    /// <typeparam name="T1">Type d'objet sur lequel appliquer les règles</typeparam>
    public abstract class RulesCore<T1>
    {
        #region properties
        /// <summary>
        /// Ensemble des règles de validation contenu dans une liste de tuple
        /// </summary>
        public List<Tuple<Func<T1, bool>, ValidationError>> Rules { get; set; }
        #endregion

        #region constructors
        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public RulesCore()
        {
            Rules = new List<Tuple<Func<T1, bool>, ValidationError>>();
        }
        #endregion
    }
}
