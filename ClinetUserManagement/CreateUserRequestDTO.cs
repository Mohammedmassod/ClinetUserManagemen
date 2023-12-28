namespace ClinetContact
{
    internal class CreateUserRequestDTO
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string UserName { get; set; }
        public bool IsActive { get; set; }
        public string PhoneNumber { get; set; }
        public int UserGroupId { get; set; }
    }
}