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

    [Table("DichVu")]
    public partial class DichVu
    {
        [Key]
        [StringLength(5)]
        public string MaDV { get; set; }

        [Required]
        [StringLength(20)]
        public string TenDV { get; set; }

        [Column(TypeName = "money")]
        public decimal DonGia { get; set; }

        public int? SLConLai { get; set; }

        [Required]
        [StringLength(20)]
        public string LoaiDV { get; set; }

        public bool? DaXoa { get; set; }

        public DichVu (DichVu dichVu)
        {
            this.MaDV = dichVu.MaDV;
            this.DaXoa = dichVu.DaXoa;
            this.TenDV = dichVu.TenDV;
            this.DonGia = dichVu.DonGia;
            this.SLConLai = dichVu.SLConLai;
            this.LoaiDV = dichVu.LoaiDV;
        }
        public DichVu()
        {
            
        }
    }
}
