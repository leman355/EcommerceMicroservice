namespace IdentityService.Entities.DTOs
{
    public class UserDTO
    {
        public record LoginDTO(string Email, string Password);
        public record RegisterDTO(string Email, string Name, string Surname, string UserName, string Password, DateTime BirthDay);
        public record UserByEmailDTO(string Email, string UserName, string Name, string Surname, DateTime BirthDay);
    }
}