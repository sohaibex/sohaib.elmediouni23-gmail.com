//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Facturation
{
    using System;
    using System.Collections.Generic;
    
    public partial class REPARATION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public REPARATION()
        {
            this.FACTURATION = new HashSet<FACTURATION>();
            this.CODE_REPARATION = new HashSet<CODE_REPARATION>();
            this.PIECE = new HashSet<PIECE>();
        }
    
        public int IdReparation { get; set; }
        public Nullable<System.DateTime> DateEtHeurDepartIngenieur { get; set; }
        public Nullable<System.DateTime> DateEtHeurArriveIngenieur { get; set; }
        public Nullable<System.DateTime> DateEtHeurDebutService { get; set; }
        public Nullable<System.DateTime> DateEtHeurFinService { get; set; }
        public Nullable<int> TempsPause { get; set; }
        public Nullable<System.TimeSpan> HeurePause { get; set; }
        public string DescriptionTravaux { get; set; }
        public Nullable<int> IdIngenieur_ { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACTURATION> FACTURATION { get; set; }
        public virtual INGENIEUR INGENIEUR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CODE_REPARATION> CODE_REPARATION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PIECE> PIECE { get; set; }
    }
}
