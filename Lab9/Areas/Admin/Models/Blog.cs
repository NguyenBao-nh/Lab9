using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab9.Models
{
    [Table("Blog")]
    public class Blog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên bài viết không được để trống")]
        [StringLength(100, ErrorMessage = "Tên bài viết không quá 100 ký tự")]
        [Column(TypeName = "nvarchar(100)")]
        [Display(Name = "Tên bài viết")]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Trạng thái")]
        public byte Status { get; set; } = 1;

        [DataType(DataType.Date)]
        [Display(Name = "Ngày tạo")]
        public DateTime CreatedDate { get; set; } = DateTime.Now;

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