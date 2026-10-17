using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab9.Models
{
    [Table("Banner")]
    public class Banner
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên Banner không được để trống")]
        [StringLength(100, ErrorMessage = "Tên Banner không quá 100 ký tự")]
        [Column(TypeName = "nvarchar(100)")]
        [Display(Name = "Tên Banner")]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Trạng thái")]
        public byte Status { get; set; } = 1;

        [Display(Name = "Độ ưu tiên")]
        public int Prioty { get; set; } = 0;

        [StringLength(100)]
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "Hình ảnh")]
        public string? Image { get; set; }

        [StringLength(350, ErrorMessage = "Mô tả không quá 350 ký tự")]
        [Column(TypeName = "nvarchar(350)")]
        [Display(Name = "Mô tả")]
        public string? Description { get; set; }
    }
}