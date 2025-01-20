using HR.LeaveManagement.Api.Common.ConfigurationSections.Attributes;

namespace HR.LeaveManagement.Api.Common.ConfigurationSections
{
    [SectionName(SectionNames.Jwt)]
    public sealed record JwtOptions
    {
        public string Issuer { get; set; } = default!;

        public string Audience { get; set; } = default!;

        public string Key { get; set; } = default!;

        public int TokenExpiresInMinutes { get; set; }

        public int RefreshTokenExpiresInDays { get; set; }
    }
}
