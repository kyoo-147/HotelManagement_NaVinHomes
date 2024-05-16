namespace HotelManagement.DTO
{
    using HotelManagement.BUS;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    // # -*- encoding: utf-8 -*-
    // # Copyright NaVinHomes Management (https://github.com/kyoo-147/HotelManagement_NaVinHomes) 2024. All Rights Reserved.
    // #  MIT License  (https://opensource.org/licenses/MIT)

    [Table("Phong")]
    public partial class Phong
    {
        public Phong()
        {
            CTDPs = new HashSet<CTDP>();
        }
        [Key]
        [StringLength(5)]
        public string MaPH { get; set; }

        [Required]
        [StringLength(20)]
        public string TTPH { get; set; }

        [Required]
        [StringLength(20)]
        public string TTDD { get; set; }

        [StringLength(100)]
        public string GhiChu { get; set; }

        [Required]
        [StringLength(5)]
        public string MaLPH { get; set; }


        public bool? DaXoa { get; set; }
        public virtual LoaiPhong LoaiPhong { get; set; }

        public virtual ICollection<CTDP> CTDPs { get; set; }
    }
}
