using System.Text.Json.Serialization;

namespace webapi_aspnet.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DepartamentoEnum
    {
        RH,
        Financeiro,
        Compras,
        Atendimento,
        Zeladoria
    }
}