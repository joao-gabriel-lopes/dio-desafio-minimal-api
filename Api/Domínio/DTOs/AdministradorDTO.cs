using MinimalApi.Dominio.Enums;

namespace MinimalApi.DTOs;

public class AdministradorDTO
{
    public string? Email { get; set; }

    public string? Senha { get; set; }

    public Perfil? Perfil { get; set; }
}
