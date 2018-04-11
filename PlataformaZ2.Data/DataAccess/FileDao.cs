﻿////-----------------------------------------------------------------------
//// <copyright file="FileDao.cs" company="Zetacorp">
////  (R) Registrado 2018 Zetacorp.
////  Desenvolvido por ZETACORP.
//// </copyright>
////-----------------------------------------------------------------------
namespace PlataformaZ2.Data.DataAccess
{
    /// <summary>
    /// Database model representing File
    /// </summary>
    public class FileDao : BaseDao
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileDao" /> class.
        /// </summary>
        public FileDao()
        {            
        }

        /// <summary> Gets or sets the file's name (for the user visualization) </summary>
        public virtual string Name { get; set; }

        /// <summary> Gets or sets the file's real name with extension (at the file system) </summary>
        public virtual string RealName { get; set; }
    }
}
