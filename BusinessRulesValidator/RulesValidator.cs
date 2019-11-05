using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessRulesValidator
{
    /// <summary>
    /// Classe de validation des règles métier
    /// </summary>
    /// <typeparam name="T">Type d'objet à valider</typeparam>
    public class RulesValidator<T>
    {
        #region attributes
        private T validator;
        private List<Tuple<Func<T, bool>, ValidationError>> rules = new List<Tuple<Func<T, bool>, ValidationError>>();
        #endregion

        #region constructors
        /// <summary>
        /// Constructeur paramétré par défaut
        /// </summary>
        /// <param name="input">Objet à valider</param>
        public RulesValidator(T input)
        {
            validator = input;
        }

        #endregion

        #region publics methods
        /// <summary>
        /// Ajoute un ensemble de règles métier à valider
        /// </summary>
        /// <param name="rules">Liste des règles métier</param>
        public void AddRules(List<Tuple<Func<T, bool>, ValidationError>> rules)
        {
            this.rules.AddRange(rules);
        }

        /// <summary>
        /// Retourne la première erreur de validation
        /// </summary>
        public ValidationError GetValidationError()
        {
            return GetValidationError(new List<int>());
        }

        /// <summary>
        /// Retourne la première erreur de validation pour un prédicat renvoyant true
        /// </summary>
        /// <param name="errorCodesToSkip">Liste de codes d'erreur à ignorer</param>
        public ValidationError GetValidationError(List<int> errorCodesToSkip)
        {
            return GetErrors(errorCodesToSkip, true).FirstOrDefault();
        }

        /// <summary>
        /// Retourne la liste de toutes les erreurs de validation pour chaque prédicat renvoyant true
        /// </summary>
        public List<ValidationError> GetValidationErrors()
        {
            return GetValidationErrors(new List<int>());
        }

        /// <summary>
        /// Retourne la liste de toutes les erreurs de validation pour chaque prédicat renvoyant true
        /// </summary>
        /// <param name="errorCodesToSkip">Liste de codes d'erreur à ignorer</param>
        public List<ValidationError> GetValidationErrors(List<int> errorCodesToSkip)
        {
            return GetErrors(errorCodesToSkip, false);
        }
        #endregion

        #region privates methods
        /// <summary>
        /// Retourne la liste de toutes les erreurs de validation pour chaque prédicat renvoyant true
        /// </summary>
        /// <param name="errorCodesToSkip">Liste de codes d'erreur à ignorer</param>
        /// <param name="stopOnFirstError">Arrête l'alimentation de la liste à la première erreur</param>
        private List<ValidationError> GetErrors(List<int> errorCodesToSkip, bool stopOnFirstError)
        {
            if (errorCodesToSkip == null) throw new ArgumentNullException("errorCodesToSkip");
            List<ValidationError> list = new List<ValidationError>();

            try
            {
                foreach (Tuple<Func<T, bool>, ValidationError> rule in rules)
                {
                    bool predicate = rule.Item1.Invoke(validator);
                    if (predicate && !errorCodesToSkip.Contains(rule.Item2.Code))
                    {
                        list.Add(rule.Item2);
                        if (stopOnFirstError) break;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return list;
        }
        #endregion
    }
}
