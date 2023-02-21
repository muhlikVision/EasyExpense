using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyExpense.Models
{
	public class Transaction
	{
		[Key]
		public int transactionId { get; set; }

		public int categoryId { get; set; }
		public Category Category { get; set; } //foriegn key

		public Double Amount { get; set; }

		[Column(TypeName = "nvarchar(75)")]
		public String? Note { get; set; }
		public DateTime Date  { get; set; } = DateTime.Now;


	}
}
