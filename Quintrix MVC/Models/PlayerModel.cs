
using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace  Quintrix_MVC.Models
{
	public class PlayerModel
	{

        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Level { get; set; }
    }
}