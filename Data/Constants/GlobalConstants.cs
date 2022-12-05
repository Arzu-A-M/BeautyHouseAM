namespace BeautyHouseAM.Data.Constants
{
    public class GlobalConstants
    {
        public class ApplicationUser
        {
            public const int FirstNameMaxLength = 20;
            public const int LastNameMaxLength = 20;
            
        }

        public class NailTechnicon
        {
            public const int FirstNameMaxLength = 50;
            public const int FirstNameMinLength = 10;
             
            public const int LastNameMaxLength = 50;
            public const int LastNameMinLength = 10;

            public const int DescriptionMaxLength = 5000;
            public const int DescriptionMinLength = 5;

        }

        public class Rgister
        {
            public const int UserNameMaxLength = 50;
            public const int UserNameMinLength = 5;
            public const int EmailMaxLength = 50;
            public const int EmailMinLength = 10;
            public const int PasswordMinLength = 8;
            public const int PasswordMaxLength = 20;
        }
    }
}
