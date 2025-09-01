using System.Text.RegularExpressions;

namespace Arrays.Models.Conta;

public class Cliente
{
    public Cliente()
    {
        _contador++;
    }

    private static int _contador = 0;
    private string _cpf = "000.000.000-00";
    private string _nome = "Desconhecido";

    public string Cpf
    {
        get => _cpf;
        set
        {
            var regex = @"^\d{3}\.\d{3}\.\d{3}-\d{2}$";
            if (!Regex.IsMatch(value, regex))
                throw new ArgumentException("CPF deve estar no formato XXX.XXX.XXX-XX.");
            _cpf = value;
        }
    }

    public string Nome
    {
        get => $"Cliente: {_nome}";
        set
        {
            if (value.Length < 3)
                throw new ArgumentException("Nome deve ter pelo menos 3 caracteres.");
            _nome = value;
        }
    }

    public static int Contador()
    {
        return _contador;
    }
}