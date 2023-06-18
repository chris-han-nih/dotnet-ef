namespace break_away.Models;

public class InternetSpecial
{
    public int InternetSpecialId { get; set; }
    public int Nights { get; set; }
    public decimal CostUSD { get; set; }
    public DateTime FromDate { get; set; }
    public DateTime ToDate { get; set; }
    // [ForeignKey("Accommodation")]
    public int AccommodationId { get; set; } // Foreign key 이름을 관련 테이블의 기본 키 이름과 다르게 지정할 경우, 이 이름을 ForeignKeyAttribute로 지정해야 한다.
    public Lodging Accommodation { get; set; }
}