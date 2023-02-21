using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyExpense.Models
{
	public class Category
	{
		[Key]
		public int categoryId { get; set; }

		[Column(TypeName = "nvarchar(50)")]
		public String? Title { get; set; }

		[Column(TypeName = "nvarchar(5)")]
		public String? Icon { get; set; }

		[Column(TypeName = "nvarchar(10)")]
		public String Type { get; set; } = "Expense";



	}
}
