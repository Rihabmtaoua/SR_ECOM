//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SR_ECOM.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Mode_Livraison
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mode_Livraison()
        {
            this.Livraison = new HashSet<Livraison>();
        }
    
        public int Mode_Liv_Id { get; set; }
        public string Mode_Liv_Des { get; set; }
        public Nullable<decimal> Prix_Liv_Mode { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Livraison> Livraison { get; set; }
    }
}
