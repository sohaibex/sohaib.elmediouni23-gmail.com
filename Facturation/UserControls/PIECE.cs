//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Facturation.UserControls
{
    using System;
    using System.Collections.Generic;
    
    public partial class PIECE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PIECE()
        {
            this.REPARATION = new HashSet<REPARATION>();
        }
    
        public string RefPiece { get; set; }
        public string LblPiece { get; set; }
        public Nullable<double> Prix { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REPARATION> REPARATION { get; set; }
    }
}