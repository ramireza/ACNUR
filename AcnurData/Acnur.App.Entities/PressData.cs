//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Acnur.App.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml.Serialization;
    
    
    /// <summary>
    /// DTO TabCuenta
    /// </summary>
    [System.Runtime.Serialization.DataContract(IsReference=true)]
    [Serializable]
    public partial class PressData
    {
    
    	/// <summary>
        /// Atributo IdPressData
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public int IdPressData { get; set; }
    
    	/// <summary>
        /// Atributo IdCategoryPress
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public int IdCategoryPress { get; set; }
    
    	/// <summary>
        /// Atributo Title
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public string Title { get; set; }
    
    	/// <summary>
        /// Atributo IdSubcategoryPress
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public int IdSubcategoryPress { get; set; }
    
    	/// <summary>
        /// Atributo WebLink
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public string WebLink { get; set; }
    
    	/// <summary>
        /// Atributo MediaName
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public string MediaName { get; set; }
    
    	/// <summary>
        /// Atributo IdEventLocationDepartament
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public int IdEventLocationDepartament { get; set; }
    
    	/// <summary>
        /// Atributo IdEventLocationMunicipality
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public int IdEventLocationMunicipality { get; set; }
    
    	/// <summary>
        /// Atributo IdEventLocationSubMunicipality
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public int IdEventLocationSubMunicipality { get; set; }
    
    	/// <summary>
        /// Atributo EventLocationCommunityOrOtherData
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public string EventLocationCommunityOrOtherData { get; set; }
    
    	/// <summary>
        /// Atributo EventData
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public System.DateTime EventData { get; set; }
    
    	/// <summary>
        /// Atributo Description
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public string Description { get; set; }
    
    	/// <summary>
        /// Atributo IdAuthor
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public string IdAuthor { get; set; }
    
    	/// <summary>
        /// Atributo IdOffice
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public int IdOffice { get; set; }
    
    	/// <summary>
        /// Atributo IdUnit
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public int IdUnit { get; set; }
    
    
    	/// <summary>
        /// Atributo de agregacion ParameterDetail
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public virtual ParameterDetail ParameterDetail { get; set; }
    
    	/// <summary>
        /// Atributo de agregacion ParameterDetail1
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public virtual ParameterDetail ParameterDetail1 { get; set; }
    
    	/// <summary>
        /// Atributo de agregacion ParameterDetail2
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public virtual ParameterDetail ParameterDetail2 { get; set; }
    
    	/// <summary>
        /// Atributo de agregacion ParameterDetail3
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public virtual ParameterDetail ParameterDetail3 { get; set; }
    
    	/// <summary>
        /// Atributo de agregacion ParameterDetail4
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public virtual ParameterDetail ParameterDetail4 { get; set; }
    
    	/// <summary>
        /// Atributo de agregacion ParameterDetail5
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public virtual ParameterDetail ParameterDetail5 { get; set; }
    
    	/// <summary>
        /// Atributo de agregacion ParameterDetail6
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public virtual ParameterDetail ParameterDetail6 { get; set; }
    }
}
