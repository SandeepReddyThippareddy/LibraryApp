namespace LibraryApp.API.DTOs
{
    public class UserDto
    {
        /// <summary>
        /// Display name of user
        /// </summary>
        public string DisplayName { get; set; }
        /// <summary>
        /// Security Token
        /// </summary>
        public string Token { get; set; }
        /// <summary>
        /// Username
        /// </summary>
        public string Username { get; set; }
        /// <summary>
        /// Bool flag to check IsLibrarian
        /// </summary>
        public bool IsLibrarian { get; set; }

    }
}
