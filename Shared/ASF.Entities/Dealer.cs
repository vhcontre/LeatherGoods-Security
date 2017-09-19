//====================================================================================================
// Base code generated with LeatherGoods
// Architecture Solutions Foundation
//
// Generated by academic at LeatherGoods V 1.0 
//====================================================================================================

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;


namespace ASF.Entities
{
    /// <summary>
    /// Represents a row of entity data.
    /// </summary>
    [Serializable]
    [DataContract]
    public partial class Dealer : EntityBase
    {
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        [DisplayName("Category Id")]
        public int CategoryId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        [DisplayName("Country Id")]
        public int CountryId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        [DisplayName("Description")]
        public string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        [DisplayName("Total Products")]
        public int TotalProducts { get; set; }
    }
}