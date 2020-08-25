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
    
    public partial class Commande
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Commande()
        {
            this.Livraison = new HashSet<Livraison>();
        }
    
        public long Cmd_id { get; set; }
        public Nullable<int> User_id { get; set; }
        public string Etat_Cmd { get; set; }
        public Nullable<System.DateTime> Date_Cmd { get; set; }
        public Nullable<decimal> Cmd_Total { get; set; }
        public Nullable<int> Cat_Id { get; set; }
        public Nullable<int> Marq_Id { get; set; }
        public Nullable<long> Art_Id { get; set; }
    
        public virtual Article Article { get; set; }
        public virtual Categorie Categorie { get; set; }
        public virtual Commande Commande1 { get; set; }
        public virtual Commande Commande2 { get; set; }
        public virtual Utilisateur Utilisateur { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Livraison> Livraison { get; set; }
    }
}
