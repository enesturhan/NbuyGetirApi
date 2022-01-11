using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbuyGetir.Core.Entities
{
    /// <summary>
    /// kimin tarafından updated created deleted yapıldığı bilgisini tutacağız
    /// </summary>
    public interface IAuditableEntity
    {
        //bu entity önemli ürün gibi bir nesne ise bu alanlara kesinlikle tutarız.
        public DateTime CreatedDate { get; set; }
        /// <summary>
        /// entity hangi yarihte ilk güncellendi
        /// </summary>
        public DateTime? UpdatedDate { get; set; }
        /// <summary>
        /// kim tarafından eklendi.
        /// </summary>
        public string CreatedBy { get; set; }
        /// <summary>
        /// kim tarafından güncellendi.
        /// </summary>
        public string UpdatedBy { get; set; }


    }
}
