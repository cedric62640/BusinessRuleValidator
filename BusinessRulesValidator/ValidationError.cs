namespace BusinessRulesValidator
{
    /// <summary>
    /// Données d'une erreur de validation
    /// </summary>
    public class ValidationError
    {
        #region properties
        /// <summary>
        /// Code de l'erreur
        /// </summary>
        public int Code { get; private set; }

        /// <summary>
        /// Message de l'erreur
        /// </summary>
        public string Message { get; private set; }
        #endregion

        #region constructors
        /// <summary>
        /// Constructeur vide par défaut
        /// </summary>
        public ValidationError()
        {

        }

        /// <summary>
        /// Constructeur paramétré avec le code d'erreur
        /// </summary>
        /// <param name="code">Code d'erreur</param>
        public ValidationError(int code)
        {
            Code = code;
        }

        /// <summary>
        /// Constructeur paramétré avec le code d'erreur et le message d'erreur
        /// </summary>
        /// <param name="code">Code d'erreur</param>
        /// <param name="message">Message d'erreur</param>
        public ValidationError(int code, string message) : this(code)
        {
            Message = message;
        }
        #endregion
    }
}
