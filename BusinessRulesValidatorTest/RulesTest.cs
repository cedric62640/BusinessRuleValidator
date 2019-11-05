using BusinessRulesValidator;
using BusinessRulesValidatorTest.BusinessLogic;
using BusinessRulesValidatorTest.BusinessObjects;
using BusinessRulesValidatorTest.Mock;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace BusinessRuleValidatorTest
{
    [TestClass]
    public class RulesTest
    {
        /// <summary>
        /// Objet correct en entrée, aucune erreur en sortie
        /// </summary>
        [TestMethod]
        public void ParseInputData_NoError_ReturnNull()
        {
            Address address = MockData.SetCorrectAddress();
            Person person = MockData.SetCorrectPerson();
            InputData inputData = new InputData() { AddressData = address, PersonData = person };

            RulesValidator<InputData> businessRulesValidator = new RulesValidator<InputData>(inputData);
            AddressRules<InputData> addressRules = new AddressRules<InputData>();
            PersonRules<InputData> personRules = new PersonRules<InputData>();

            businessRulesValidator.AddRules(addressRules.Rules);
            businessRulesValidator.AddRules(personRules.Rules);
            ValidationError result = businessRulesValidator.GetValidationError();

            Assert.IsNull(result);
        }

        /// <summary>
        /// Numéro de rue égal à 0, code retour 1 attendu
        /// </summary>
        [TestMethod]
        public void ParseInputData_AddressWayNumberEquals0_ReturnResultCodeEquals1()
        {
            Address address = MockData.SetIncorrectWayNumberAddress();
            Person person = MockData.SetCorrectPerson();
            InputData inputData = new InputData() { AddressData = address, PersonData = person };

            RulesValidator<InputData> businessRulesValidator = new RulesValidator<InputData>(inputData);
            AddressRules<InputData> addressRules = new AddressRules<InputData>();
            PersonRules<InputData> personRules = new PersonRules<InputData>();

            businessRulesValidator.AddRules(addressRules.Rules);
            businessRulesValidator.AddRules(personRules.Rules);
            ValidationError result = businessRulesValidator.GetValidationError();

            Assert.AreEqual(result.Code, 1);
        }

        /// <summary>
        /// Numéro de rue égal à 0, code retour 1 ignoré, aucune erreur en sortie
        /// </summary>
        [TestMethod]
        public void ParseInputData_AddressWayNumberEquals0AndSkipResultCode1_ReturnNull()
        {
            Address address = MockData.SetIncorrectWayNumberAddress();
            Person person = MockData.SetCorrectPerson();
            InputData inputData = new InputData() { AddressData = address, PersonData = person };

            RulesValidator<InputData> businessRulesValidator = new RulesValidator<InputData>(inputData);
            AddressRules<InputData> addressRules = new AddressRules<InputData>();
            PersonRules<InputData> personRules = new PersonRules<InputData>();

            List<int> rulesToSkip = new List<int>();
            rulesToSkip.Add(1);

            businessRulesValidator.AddRules(addressRules.Rules);
            businessRulesValidator.AddRules(personRules.Rules);
            ValidationError result = businessRulesValidator.GetValidationError(rulesToSkip);

            Assert.IsNull(result);
        }

        /// <summary>
        /// Données de l'adresse et de l'individu incorrect, liste de 4 objets de type ValidationError attendu en sortie
        /// </summary>
        [TestMethod]
        public void ParseInputData_AddressAndPersonAreIncorrect_ReturnListOfValidationError()
        {
            Address address = MockData.SetIncorrectWayNumberAndWayNameAddress();
            Person person = MockData.SetIncorrectFirstNameLastNamePerson();
            InputData inputData = new InputData() { AddressData = address, PersonData = person };

            RulesValidator<InputData> businessRulesValidator = new RulesValidator<InputData>(inputData);
            AddressRules<InputData> addressRules = new AddressRules<InputData>();
            PersonRules<InputData> personRules = new PersonRules<InputData>();


            businessRulesValidator.AddRules(addressRules.Rules);
            businessRulesValidator.AddRules(personRules.Rules);
            List<ValidationError> result = businessRulesValidator.GetValidationErrors();

            Assert.AreEqual(result.Count, 4);
        }

        /*
         * etc, etc..
         */
    }
}
