using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Data.Views
{
    [Table("MobileBusinessView", Schema = "ods")]
    public partial class GoodsView
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long mobile_business_fk { get; set; }

        public long? tax_item_type_fk { get; set; }

        [StringLength(100)]
        public string text_description { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal minimum_price { get; set; }

        public decimal? maximum_price { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int loyalty_points_to_accrue { get; set; }

        public int? likes { get; set; }

        public int? dislikes { get; set; }

        public decimal? commission_amount { get; set; }

        [StringLength(30)]
        public string unit_of_measure { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(1)]
        public string physical_or_virtual_indicator { get; set; }

        [StringLength(1)]
        public string visable_flag { get; set; }

        [StringLength(1)]
        public string default_purchase_mode { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(1)]
        public string ok_for_pickup_flag { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(1)]
        public string ok_for_delivery_flag { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(1)]
        public string ok_for_ship_flag { get; set; }

        public int? service_life_in_days { get; set; }

        public int? service_life_exact_or_category_flag { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal commission_ratio { get; set; }

        public int? quantity_available { get; set; }

        public int? quantity_on_hand { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(1)]
        public string platform_gets_all_inventory_flag { get; set; }
    }
}
