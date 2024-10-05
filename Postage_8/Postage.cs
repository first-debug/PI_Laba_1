using System.Text;

namespace Postage_8;

class Postage(int index = 0,
    string city = "",
    string street = "",
    int house = 0,
    int building = 0,
    int flat = 0,
    string message = "")
{
    public int Index { get; set; } = index;
    public string City { get; set; } = city;
    public string Street { get; set; } = street;
    public int House { get; set; } = house;
    public int Building { get; set; } = building;
    public int Flat { get; set; } = flat;
    public string Message { get; set; } = message;
    public string Address 
    {
        get => $"{Index}, c. {City}, st. {Street}, {House}/{Building}, f. {Flat}";
    }
    public string Valid()
    {
        StringBuilder stringBuilder = new();
        if (Index < 100_000 || Index > 999_999)
            stringBuilder.Append("Неверный индекс.").AppendLine();
        if (City.Equals(""))
            stringBuilder.Append("Город не указаню").AppendLine();
        if (Street.Equals(""))
            stringBuilder.Append("Улица не указана.").AppendLine();
        if (House == 0)
            stringBuilder.Append("Номер дома не указан.").AppendLine();
        if (Building == 0)
            stringBuilder.Append("Номер корпуса не указан.").AppendLine();
        if (Flat == 0)
            stringBuilder.Append("Номер квартры не указан.").AppendLine();
        if (Message.Equals(""))
            stringBuilder.Append("Сообщение пустое!").AppendLine();
        return stringBuilder.ToString();
    }
}
// 8. Объект «Почтовое отправление», содержащий автоматические 
// свойства адреса получателя: индекс, город, улица, дом, корпус, квартира, а 
// также, тело письма (сообщение). Объект должен содержать метод Valid() 
// выполняющий проверки заполнения всех полей, а также свойство Адрес, 
// выводящее адрес в виде строки. 