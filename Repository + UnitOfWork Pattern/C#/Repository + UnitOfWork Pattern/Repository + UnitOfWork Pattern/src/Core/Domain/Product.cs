using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository_UnitOfWork_Pattern.src.Core.Domain
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Level { get; set; }

        public float FullPrice { get; set; }

        public virtual Brand Brand { get; set; }

        public int BrandId { get; set; }

        public bool IsPromotinalProduct
        {
            get { return Level == 1; }
        }
    }
}
