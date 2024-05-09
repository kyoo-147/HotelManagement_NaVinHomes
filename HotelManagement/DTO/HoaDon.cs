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

    [Table("HoaDon")]
    public partial class HoaDon
    {
        [Key]
        [StringLength(5)]
        public string MaHD { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NgHD { get; set; }

        [Column(TypeName = "money")]
        public decimal TriGia { get; set; }

        [StringLength(5)]
        public string MaNV { get; set; }

        [Required]
        [StringLength(20)]
        public string TrangThai { get; set; }

        [Required]
        [StringLength(7)]
        public string MaCTDP { get; set; }

        public virtual CTDP CTDP { get; set; }

       // public bool? DaXoa { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
