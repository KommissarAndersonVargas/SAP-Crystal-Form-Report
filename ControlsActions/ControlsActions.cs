using SAPCrystalReports.Classes;

namespace SAPCrystalReports.ControlsActions
{
    public static class ControlsActions
    {
        public static void AddsUserEvent()
        {

            var newUser = new UserBuilder()
                             .Id("123")
                             .FirstName("Anderson")
                             .LastName("Vargas")
                             .DateOfBirth("10/15/2002")
                             .Income("test")
                             .CellPhoneNumber("123456789")
                             .Email("andersonvargas123@gmail.com")
                             .CreateUserData();

        }

    }
}
