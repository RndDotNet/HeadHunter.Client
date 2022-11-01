using System.Text.Json.Serialization;

namespace RndDotNet.HeadHunter.Client.Vacancies;

/// <summary>
/// Salary.
/// </summary>
public class VacancySalary
{
	/// <summary>
	/// Lower limit of salary range.
	/// </summary>
	[JsonPropertyName("from")]
	public double? From { get; set; }
	
	/// <summary>
	/// Upper limit of salary range.
	/// </summary>
	[JsonPropertyName("to")]
	public double? To { get; set; }
	
	/// <summary>
	/// Indication that the salary is shown before tax. If not indicated — null.
	/// </summary>
	[JsonPropertyName("gross")]
	public bool? Gross { get; set; }
	
	/// <summary>
	/// Indication of salary currency.
	/// </summary>
	[JsonPropertyName("currency")]
	public string Currency { get; set; }
}
