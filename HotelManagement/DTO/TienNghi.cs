namespace HotelManagement.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    // # -*- encoding: utf-8 -*-
    // # Copyright NaVinHomes Management (https://github.com/kyoo-147/HotelManagement_NaVinHomes) 2024. All Rights Reserved.
    // #  MIT License  (https://opensource.org/licenses/MIT)

    [Table("TienNghi")]
    public partial class TienNghi
    {
        public TienNghi()
        {
            CTTNs = new HashSet<CTTN>();
        }
        [Key]
        [StringLength(5)]
        public string MaTN { get; set; }

        [Required]
        [StringLength(50)]
        public string TenTN { get; set; }

        public bool? DaXoa { get; set; }

        public virtual ICollection<CTTN> CTTNs { get; set; }
    }
}
