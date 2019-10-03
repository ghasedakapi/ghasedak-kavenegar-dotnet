using Ghasedak.Kavenegar.Models.Enums;
namespace Ghasedak.Kavenegar.Models
{
 public class StatusResult
 {
	public long Messageid { get; set; }
	public MessageStatus Status { get; set; }
	public string Statustext { get; set; }
 }
}