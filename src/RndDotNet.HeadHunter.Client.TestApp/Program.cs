using RndDotNet.HeadHunter.Client;
using RndDotNet.HeadHunter.Client.Vacancies;

// Retrieve settings for client. Add ClientId and ClientSecret for authentication or use AccessToken instead
var settings = new HeadHunterApiClientSettings
{
	ClientId = "Your client id",
	ClientSecret = "Your client secret",
	AccessToken = "Your access token",
	UserAgentHeaderValue = "Your application name and contacts"
};

// Create factory with setting to build client
var factory = new HeadHunterApiClientFactory(() => settings);

// Build client
var client = await factory.Build();

// Retrieve all countries
var countries = await client.Areas.GetAllCountries();

// Retrieve all areas with children
var areas = await client.Areas.GetAllAreas();

// Retrieve all industries grouped into categories
var industries = await client.Industries.GetAllIndustries();

// Retrieve all professional roles grouped into categories
var professionalRoles = await client.ProfessionalRoles.GetAllProfessionalRoles();

// Retrieve vacancy details
var vacancy = await client.Vacancies.GetVacancy("67485637");

// Search vacancies by parameters
var getVacanciesParams = new GetVacanciesQueryParams
{
	SearchField = "name", // vacancy name
	Text = "C#",
	Areas = new[] { "3", "76" }, // Rostov on Don and Ekaterinburg
	Page = 0, // Page number
	PerPage = 100 // Results per page
};
var vacancies = await client.Vacancies.GetVacancies(getVacanciesParams);

var employer = await client.Employers.GetEmployer("41862");

Console.WriteLine();