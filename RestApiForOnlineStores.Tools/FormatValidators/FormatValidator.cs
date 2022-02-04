using System.Text.RegularExpressions;
using Jane;

namespace RestApiForOnlineStores.Tools.FormatValidators
{
    public static class FormatValidator
    {
        private static readonly Regex FormatPhoneNumberRus = new (@"\+[7][0-9]{3}-[0-9]{3}-[0-9]{2}-[0-9]{2}", RegexOptions.Compiled);
        private static readonly Regex FormatPostamatId = new (@"\[0-9]{3}-[0-9]{3}", RegexOptions.Compiled);

        public static IResult IsCorrectPhoneNumber(string phoneNumber)
        {
            return FormatPhoneNumberRus.IsMatch(phoneNumber)
                ? Result.Success()
                : Result.Failure("Неверный формат номера телефона");
        }

        public static IResult IsCorrectPostamatId(string postamatId)
        {
            return FormatPostamatId.IsMatch(postamatId)
                ? Result.Success()
                : Result.Failure("Неверный формат номера постамата");
        }
    }
}