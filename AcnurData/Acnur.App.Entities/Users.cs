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
    public partial class Users
    {
    	/// <summary>
        /// Constructor Users
        /// </summary>
        public Users()
        {
            this.GeneralInformationActionUsers = new HashSet<GeneralInformationActionUsers>();
            this.Audit = new HashSet<Audit>();
            this.ModuleUser = new HashSet<ModuleUser>();
            this.OperationsModuleUser = new HashSet<OperationsModuleUser>();
            this.StepsFlowModuleUser = new HashSet<StepsFlowModuleUser>();
            this.GeneralInformationEventUsers = new HashSet<GeneralInformationEventUsers>();
            this.GeneralInformationRiskProfileUsers = new HashSet<GeneralInformationRiskProfileUsers>();
            this.GeneralInformationEmergencyUsers = new HashSet<GeneralInformationEmergencyUsers>();
        }
    
    
    	/// <summary>
        /// Atributo IdUser
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public int IdUser { get; set; }
    
    	/// <summary>
        /// Atributo UserName
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public string UserName { get; set; }
    
    	/// <summary>
        /// Atributo Name
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public string Name { get; set; }
    
    	/// <summary>
        /// Atributo LastName
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public string LastName { get; set; }
    
    	/// <summary>
        /// Atributo Mail
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public string Mail { get; set; }
    
    	/// <summary>
        /// Atributo Active
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public bool Active { get; set; }
    
    	/// <summary>
        /// Atributo IdRol
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public int IdRol { get; set; }
    
    
    	/// <summary>
        /// Atributo de agregacion GeneralInformationActionUsers
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public virtual ICollection<GeneralInformationActionUsers> GeneralInformationActionUsers { get; set; }
    
    	/// <summary>
        /// Atributo de agregacion Audit
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public virtual ICollection<Audit> Audit { get; set; }
    
    	/// <summary>
        /// Atributo de agregacion ModuleUser
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public virtual ICollection<ModuleUser> ModuleUser { get; set; }
    
    	/// <summary>
        /// Atributo de agregacion OperationsModuleUser
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public virtual ICollection<OperationsModuleUser> OperationsModuleUser { get; set; }
    
    	/// <summary>
        /// Atributo de agregacion ParameterDetail
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public virtual ParameterDetail ParameterDetail { get; set; }
    
    	/// <summary>
        /// Atributo de agregacion StepsFlowModuleUser
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public virtual ICollection<StepsFlowModuleUser> StepsFlowModuleUser { get; set; }
    
    	/// <summary>
        /// Atributo de agregacion GeneralInformationEventUsers
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public virtual ICollection<GeneralInformationEventUsers> GeneralInformationEventUsers { get; set; }
    
    	/// <summary>
        /// Atributo de agregacion GeneralInformationRiskProfileUsers
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public virtual ICollection<GeneralInformationRiskProfileUsers> GeneralInformationRiskProfileUsers { get; set; }
    
    	/// <summary>
        /// Atributo de agregacion GeneralInformationEmergencyUsers
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public virtual ICollection<GeneralInformationEmergencyUsers> GeneralInformationEmergencyUsers { get; set; }
    }
}
