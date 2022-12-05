namespace BeautyHouseAM.Data.Constants
{
    public class GlobalConstants
    {
        public class ApplicationUser
        {
            public const int UserNameMaxLength = 20;
            public const int UserNameMinLength = 5;

            public const int EmailMaxLength = 60;
            public const int EmailMinLength = 10;

            public const int PasswordMaxLength = 20;
            public const int PasswordMinLength = 5;
        }

        public class NailTechnicon
        {
            public const int FirstNameMaxLength = 50;
            public const int FirstNameMinLength = 10;
             
            public const int LastNameMaxLength = 50;
            public const int LastNameMinLength = 10;

            public const int DescriptionMaxLength = 5000;
            public const int DescriptionMinLength = 5;

            public const string RatingMaxLength = "10";
            public const string RatingMinLength = "0";
        }

        public class Category
        {
            public const int NameMaxLength = 50;
            public const int NameMinLength = 5;
        }
    }
}
