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

    [Table("TaiKhoan")]
    public partial class TaiKhoan
    {
        [Key]
        [StringLength(50)]
        public string TenTK { get; set; }

        [Required]
        [StringLength(1000)]
        public string Password { get; set; }

        public int CapDoQuyen { get; set; }

        [Required]
        [StringLength(5)]
        public string MaNV { get; set; }

        public bool? DaXoa { get; set; }
        public virtual NhanVien NhanVien { get; set; }
    }
}
