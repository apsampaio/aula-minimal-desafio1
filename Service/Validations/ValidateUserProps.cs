using Flunt.Notifications;
using Flunt.Validations;

namespace Service.Validations;

public class ValidateUserProps : Notifiable<Notification>
{

    public string username { get; init; } = default!;
    public string password { get; init; } = default!;
    public string name { get; init; } = default!;

    public void MapTo()
    {
        var contract = new Contract<Notification>()
        .Requires()
        .IsNotNullOrEmpty(username, "Informe um login válido.")
        .IsGreaterThan(username, 4, "Login deve ter no mínimo 5 digitos.");

        // [ ] - REALIZAR VALIDACAO DE PASSWORD E NAME

        AddNotifications(contract);
    }

}
