using BusinessRulesValidatorTest.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessRulesValidatorTest.Mock
{
    /// <summary>
    /// Données de test
    /// </summary>
    public static class MockData
    {
        /// <summary>
        /// Instancie une adresse correcte
        /// </summary>
        public static Address SetCorrectAddress()
        {
            return new Address()
            {
                City = "Paris",
                CountryCode = "FR",
                WayName = "rue de la louche",
                WayNumber = 15,
                ZipCode = "75001",
                PostalAddressLine3 = "15 rue de la louche",
                PostalAddressLine4 = "75001 Paris"
            };
        }

        /// <summary>
        /// Instancie une adresse incorrecte
        /// </summary>
        public static Address SetIncorrectWayNumberAddress()
        {
            return new Address()
            {
                City = "Paris",
                CountryCode = "FR",
                WayName = "rue de la louche",
                WayNumber = 0,
                ZipCode = "75001",
                PostalAddressLine3 = "0 rue de la louche",
                PostalAddressLine4 = "75001 Paris"
            };
        }

        /// <summary>
        /// Instancie une adresse incorrecte
        /// </summary>
        public static Address SetIncorrectWayNameAddress()
        {
            return new Address()
            {
                City = "Paris",
                CountryCode = "FR",
                WayName = "rue du maître corbeau sur un arbre perché",
                WayNumber = 40,
                ZipCode = "75001",
                PostalAddressLine3 = "0 rue de la louche",
                PostalAddressLine4 = "75001 Paris"
            };
        }

        /// <summary>
        /// Instancie une adresse incorrecte
        /// </summary>
        public static Address SetIncorrectWayNumberAndWayNameAddress()
        {
            return new Address()
            {
                City = "Paris",
                CountryCode = "FR",
                WayName = "rue du maître corbeau sur un arbre perché",
                WayNumber = 0,
                ZipCode = "75001",
                PostalAddressLine3 = "0 rue de la louche",
                PostalAddressLine4 = "75001 Paris"
            };
        }

        /// <summary>
        /// Instancie un invividu correct
        /// </summary>
        public static Person SetCorrectPerson()
        {
            return new Person()
            {
                FirstName = "John",
                LastName = "Doe"
            };
        }

        /// <summary>
        /// Instancie un invividu correct
        /// </summary>
        public static Person SetIncorrectFirstNamePerson()
        {
            return new Person()
            {
                FirstName = string.Empty,
                LastName = "Doe"
            };
        }

        /// <summary>
        /// Instancie un invividu correct
        /// </summary>
        public static Person SetIncorrectLastNamePerson()
        {
            return new Person()
            {
                FirstName = "John",
                LastName = string.Empty
            };
        }

        /// <summary>
        /// Instancie un invividu correct
        /// </summary>
        public static Person SetIncorrectFirstNameLastNamePerson()
        {
            return new Person()
            {
                FirstName = null,
                LastName = null
            };
        }
    }
}
