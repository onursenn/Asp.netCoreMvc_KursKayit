using System.ComponentModel.DataAnnotations;

namespace Kurs_Kayit.Models
{
  public class Candidate
  {
    [Required(ErrorMessage ="Mail Alan Boş Bırakılamaz.")]
    [EmailAddress(ErrorMessage ="E-mail Formatında Giriş Yapınız.")]
    public string? Email { get; set; } = string.Empty;

    [StringLength(25,ErrorMessage ="Maximum 25 Karakter Kullanabilirsiniz.")]
    [Required(ErrorMessage ="Ad Alan Boş Bırakılamaz.")]
    public string? FirstName { get; set; } = string.Empty;


    [StringLength(25,ErrorMessage ="Maximum 25 Karakter Kullanabilirsiniz.")]
    [Required(ErrorMessage ="Soyad Alan Boş Bırakılamaz.")]
    public string? LastName { get; set; } = string.Empty;
    
    public string? FullName => $"{FirstName} {LastName?.ToUpper()}";
    public int? Age { get; set; }
    public string? SelectedCourse { get; set; } = string.Empty;
    public DateTime ApplyAt { get; set; }

    public Candidate()
    {
      ApplyAt = DateTime.Now;
    }


  }
}













