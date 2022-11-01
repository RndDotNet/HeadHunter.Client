using System.Text.Json.Serialization;
using RndDotNet.HeadHunter.Client.Areas;

namespace RndDotNet.HeadHunter.Client.Vacancies;

/// <summary>
/// Detailed vacancy information.
/// </summary>
public class Vacancy
{
	/// <summary>
	/// Vacancy ID.
	/// </summary>
	[JsonPropertyName("id")]
	public string Id { get; set; }
	
	/// <summary>
	/// Job description, contains html.
	/// </summary>
	[JsonPropertyName("description")]
	public string Description { get; set; }
	
	/// <summary>
	/// Branded job description.
	/// </summary>
	/// <remarks>
	/// branded_description – a string with HTML code ( <script/> and <style/> may be present)
	/// that is an alternative to a standard vacancy description.
	/// The HTML code is adapted for mobile devices and displays correctly without javascript support enabled.
	/// </remarks>
	[JsonPropertyName("branded_description")]
	public string? BrandedDescription { get; set; }
	
	/// <summary>
	/// Details of key skills indicated in the vacancy. This list may be empty.
	/// </summary>
	[JsonPropertyName("key_skills")]
	public VacancyKeySkill[] KeySkills { get; set; }
	
	/// <summary>
	/// Work schedule.
	/// </summary>
	[JsonPropertyName("schedule")]
	public VacancySchedule Schedule { get; set; }
	
	/// <summary>
	/// Indication that the job is available for applicants with disabilities.
	/// </summary>
	[JsonPropertyName("accept_handicapped")]
	public bool AcceptHandicapped { get; set; }
	
	/// <summary>
	/// Indication that the job is available for applicants as young as 14 years old.
	/// </summary>
	[JsonPropertyName("accept_kids")]
	public bool AcceptKids { get; set; }
	
	/// <summary>
	/// Required work experience.
	/// </summary>
	[JsonPropertyName("experience")]
	public VacancySchedule Experience { get; set; }
	
	/// <summary>
	/// Vacancy address.
	/// </summary>
	[JsonPropertyName("address")]
	public VacancyAddress? Address { get; set; }
	
	/// <summary>
	/// Link to the vacancy on the website.
	/// </summary>
	[JsonPropertyName("alternate_url")]
	public string AlternateUrl { get; set; }
	
	/// <summary>
	/// Link to the application for the vacancy on the website.
	/// </summary>
	[JsonPropertyName("apply_alternate_url")]
	public string ApplyAlternateUrl { get; set; }
	
	/// <summary>
	/// Employer's internal vacancy code.
	/// </summary>
	[JsonPropertyName("code")]
	public string? Code { get; set; }
	
	/// <summary>
	/// Department on whose behalf the vacancy is uploaded (if available for the company).
	/// </summary>
	[JsonPropertyName("department")]
	public VacancyDepartment? Department { get; set; }
	
	/// <summary>
	/// Type of employment.
	/// </summary>
	[JsonPropertyName("employment")]
	public VacancyEmployment? Employment { get; set; }
	
	/// <summary>
	/// Salary.
	/// </summary>
	[JsonPropertyName("salary")]
	public VacancySalary? Salary { get; set; }
	
	/// <summary>
	/// Whether the vacancy is archived.
	/// </summary>
	[JsonPropertyName("archived")]
	public bool Archived { get; set; }
	
	/// <summary>
	/// Vacancy name.
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; set; }
	
	/// <summary>
	/// Interview about life in the company.
	/// </summary>
	[JsonPropertyName("insider_interview")]
	public VacancyInsiderInterview? InsiderInterview { get; set; }
	
	/// <summary>
	/// Vacancy region.
	/// </summary>
	[JsonPropertyName("area")]
	public Area? Area { get; set; }
	
	/// <summary>
	/// Date and time resume was created.
	/// </summary>
	[JsonPropertyName("initial_created_at")]
	public string InitialCreatedAt { get; set; }
	
	/// <summary>
	/// Date and time of vacancy publication.
	/// </summary>
	[JsonPropertyName("created_at")]
	public string CreatedAt { get; set; }
	
	/// <summary>
	/// Date and time of vacancy publication.
	/// </summary>
	[JsonPropertyName("published_at")]
	public string PublishedAt { get; set; }
	
	/// <summary>
	/// Whether it is mandatory to fill out a message for application.
	/// </summary>
	[JsonPropertyName("response_letter_required")]
	public bool ResponseLetterRequired { get; set; }
	
	/// <summary>
	/// Vacancy type.
	/// </summary>
	[JsonPropertyName("type")]
	public VacancyType Type { get; set; }
	
	/// <summary>
	/// Information on whether there is an attached test task for the vacancy. If there is a test — true.
	/// </summary>
	[JsonPropertyName("has_test")]
	public bool HasTest { get; set; }
	
	/// <summary>
	/// You cannot apply for vacancies with direct type on hh.ru, these vacancies have an external website URL in the response_url key
	/// (in most cases, the employer's website with an application form).
	/// </summary>
	[JsonPropertyName("response_url")]
	public string? ResponseUrl { get; set; }
	
	/// <summary>
	/// Information about attached test for the job. If there is no test — null.
	/// </summary>
	/// <remarks>At the moment it is impossible to apply for vacancies with mandatory test with API.</remarks>
	[JsonPropertyName("test")]
	public VacancyTest? Test { get; set; }
	
	/// <summary>
	/// Specialisations.
	/// </summary>
	[JsonPropertyName("specializations")]
	public VacancySpecialization[] Specializations { get; set; }
	
	/// <summary>
	/// Contact info.
	/// </summary>
	[JsonPropertyName("contacts")]
	public VacancyContacts? Contacts { get; set; }
	
	/// <summary>
	/// Vacancy billing type.
	/// </summary>
	[JsonPropertyName("billing_type")]
	public VacancyBillingType BillingType { get; set; }
	
	/// <summary>
	/// Whether the option is enabled for the candidate to send messages to the employer after invitation/application for the job.
	/// </summary>
	[JsonPropertyName("allow_messages")]
	public bool AllowMessages { get; set; }
	
	/// <summary>
	/// Whether it is a premium vacancy.
	/// </summary>
	[JsonPropertyName("premium")]
	public bool Premium { get; set; }
	
	/// <summary>
	/// List of required driver license categories. This list may be empty.
	/// </summary>
	[JsonPropertyName("driver_license_types")]
	public VacancyDriverLicenseType[] DriverLicenseTypes { get; set; }
	
	/// <summary>
	/// Whether it is possible to apply with an incomplete resume.
	/// </summary>
	[JsonPropertyName("accept_incomplete_resumes")]
	public bool AcceptIncompleteResumes { get; set; }
	
	/// <summary>
	/// Working days.
	/// </summary>
	[JsonPropertyName("working_days")]
	public VacancyWorkingDays[]? WorkingDays { get; set; }
	
	/// <summary>
	/// Working time intervals.
	/// </summary>
	[JsonPropertyName("working_time_intervals")]
	public VacancyWorkingTimeIntervals[]? WorkingTimeIntervals { get; set; }
	
	/// <summary>
	/// Working time modes.
	/// </summary>
	[JsonPropertyName("working_time_modes")]
	public VacancyWorkingTimeModes[]? WorkingTimeModes { get; set; }
	
	/// <summary>
	/// Indication that the job is available for applicants with accept temporary employment.
	/// </summary>
	[JsonPropertyName("accept_temporary")]
	public bool AcceptTemporary { get; set; }
	
	/// <summary>
	/// Array of professional role objects. This list can be empty.
	/// </summary>
	[JsonPropertyName("professional_roles")]
	public VacancyProfessionalRole[] ProfessionalRoles { get; set; }
}
