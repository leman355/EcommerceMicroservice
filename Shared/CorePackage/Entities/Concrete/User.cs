namespace CorePackage.Entities.Concrete
{
    public class User : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string ProfilePicture { get; set; }
        public DateTime BirthDay { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsBlocked { get; set; }
        public int FailedLogin { get; set; }
        public bool EmailConfirmed { get; set; }
        public List<UserRole> UserRoles { get; set; }
    }
}