using Microsoft.AspNetCore.Mvc;

namespace MyProject.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class TransferController : ControllerBase
  {
    /// <summary>
    /// Kartalar orasida pul o'tkazish operatsiyasi.
    /// </summary>
    /// <param name="request">SenderCard, ReceiverCard, Amount ma'lumotlari.</param>
    /// <returns>Transfer natijasi.</returns>
    /// <response code="200">Pul muvaffaqiyatli o'tkazildi.</response>
    /// <response code="400">Mablag' yetarli emas yoki ma'lumot noto'g'ri.</response>
    /// <response code="401">Token muddati tugagan yoki noto'g'ri.</response>
    [HttpPost("send")]
    public IActionResult SendMoney([FromBody] TransferRequest request)
    {
      // Token yo'q deb faraz qilamiz (real loyihalarda JWT bo'ladi)
      if (!Request.Headers.ContainsKey("Authorization"))
        return Unauthorized("Token kerak!");

      // Oddiy validatsiya
      if (request.Amount <= 0)
        return BadRequest("Summani to'g'ri kiriting!");

      if (request.SenderCard.Length != 16 || request.ReceiverCard.Length != 16)
        return BadRequest("Karta raqami 16 ta bo'lishi kerak!");

      // Balansni doimiy qilib olaylik (realda DB dan olinadi)
      decimal balance = 1_000_000;

      if (request.Amount > balance)
        return BadRequest("Mablag' yetarli emas");

      return Ok(new
      {
        message = "Transfer muvaffaqiyatli bajarildi",
        amount = request.Amount,
        time = DateTime.Now
      });
    }
  }

  public class TransferRequest
  {
    public string SenderCard { get; set; }
    public string ReceiverCard { get; set; }
    public decimal Amount { get; set; }
  }
}
