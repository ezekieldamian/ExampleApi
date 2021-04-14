using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Data.Views
{
    [Table("MobileBusinessView", Schema = "ods")]
    public partial class MobileBusinessView
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long mobile_business_id { get; set; }

        [StringLength(100)]
        public string organization_name { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(1)]
        public string offers_goods_flag { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(1)]
        public string offers_services_flag { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(1)]
        public string offers_assets_flag { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(1)]
        public string ships_goods_flag { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(1)]
        public string accepts_credit_card_flag { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(1)]
        public string accepts_ach_flag { get; set; }

        public long? monthly_volume_bracket_fk { get; set; }

        public long? transactions_per_month_bracket_fk { get; set; }

        public long? transactions_size_bracket_fk { get; set; }

        public long? selected_theme_fk { get; set; }

        public long? selected_color_fk { get; set; }

        [StringLength(100)]
        public string headquarters_address_line_1 { get; set; }

        [StringLength(100)]
        public string headquarters_address_line_2 { get; set; }

        [StringLength(100)]
        public string headquarters_address_line_3 { get; set; }

        [StringLength(100)]
        public string headquarters_city { get; set; }

        [StringLength(2)]
        public string headquarters_state_postal_code { get; set; }

        [StringLength(9)]
        public string headquarters_zip_code { get; set; }
    }
}
