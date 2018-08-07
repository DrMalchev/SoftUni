using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CSHARP_Blog.Models
{
    public class Article
    {

		public Article()
		{
			this.AddedDate = DateTime.Now;
		}

		[Key]
		public int Id { get; set; }

		[Required]
		[MaxLength(50)]
		public string Title { get; set; }

		[Required]
		[Column(TypeName ="text")]
		public string Content { get; set; }

		public DateTime	AddedDate { get; set; }

		public string AuthorId { get; set; }

		public User Author { get; set; }

		[NotMapped]
		public string Summary { 
		get
			{

				if (this.Content == null)
				{
					return null;
				}
				string summary = this.Content.Substring(0,this.Content.Length/2)+"...";

				return summary;
			}
		
		}

	}
}
