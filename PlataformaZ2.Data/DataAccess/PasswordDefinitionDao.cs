﻿////-----------------------------------------------------------------------
//// <copyright file="PasswordDefinitionDao.cs" company="Zetacorp">
////  (R) Registrado 2018 Zetacorp.
////  Desenvolvido por ZETACORP.
//// </copyright>
////-----------------------------------------------------------------------
namespace PlataformaZ2.Data.DataAccess
{
    using System;

    /// <summary>
    /// Database model representing PasswordDefinition
    /// </summary>
    public class PasswordDefinitionDao : BaseDao
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PasswordDefinitionDao" /> class.
        /// </summary>
        public PasswordDefinitionDao()
        {            
        }

        /// <summary> Gets or sets the User that will use the token (it's a reference for another DAO) </summary>
        public virtual UserDao User { get; set; }

        /// <summary> Gets or sets the token for password change </summary>
        public virtual string Token { get; set; }

        /// <summary> Gets or sets the token's creation date </summary>
        public virtual DateTime CreationDate { get; set; }

        /// <summary> Gets or sets the token's expiration date </summary>
        public virtual DateTime? ExpirationDate { get; set; }
    }
}