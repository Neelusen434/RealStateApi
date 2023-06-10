using Microsoft.AspNetCore.Authentication;
using System.ComponentModel.DataAnnotations;

namespace RealStateApi.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Category can't be null or emty")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Category can't be null or emty")]
        public string ImageUrl { get; set;}

        public ICollection<Property> Properties { get; set;}



        
    }
}
