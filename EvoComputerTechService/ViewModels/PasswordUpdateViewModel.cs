using System.ComponentModel.DataAnnotations;

namespace EvoComputerTechService.ViewModels
{
    public class PasswordUpdateViewModel
    {
        [Required(ErrorMessage = "Eski Şifre alanı gereklidir.")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Şifreniz minimum 6 karakterli olmalıdır!")]
        [Display(Name = "Eski Şifre")]
        [DataType(DataType.Password)]
        public string OldPassword { get; set; }
        [Required(ErrorMessage = "Yeni Şifre alanı gereklidir.")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Şİfreniz minimum 6 karakterli olmalıdır.")]
        [Display(Name = "Yeni Şifre")]
        public string NewPassword { get; set; }
        [Required(ErrorMessage = "Şifre alanı tekrar gereklidir.")]
        [DataType(DataType.Password)]
        [Display(Name = "Yeni şifre tekrar")]
        [Compare(nameof(NewPassword), ErrorMessage = "Şifreler uyuşmuyor!")]
        public string ConfirmNewPassword { get; set; }
    }
}
