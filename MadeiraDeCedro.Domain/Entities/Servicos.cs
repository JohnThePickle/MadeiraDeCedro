namespace MadeiraDeCedro.Domain.Entities
{
    public class Servicos
    {
        public int Id { get; set; }
        public required string Nome { get; set; } //Nome do serviço
        public string? Descrição{ get; set;} //Descrição do serviço
        public string? Madeira { get; set; } //Tipo de Madeira
        public string? Movel { get; set; } //Tipo de Movel
        public string? Imagem { get; set; } //ImageUrl

    }
}
