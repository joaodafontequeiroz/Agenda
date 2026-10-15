using System.Globalization;

namespace Models.Task;

public class Task
{
    public Guid Id {get; set;} = new Guid();
    private String _hora;    
    private String _classe;
    private static readonly string [] ClassesValidas = {"pessoal", "trabalho", "casa"};
    public String Titulo { get; set; }
    public String Corpo { get; set; }
    public bool Concluido {get; set;}

    public String Hora
    {
        get => _hora;

        set
        {
            if(!TimeSpan.TryParseExact(value, @"hh\:mm", CultureInfo.InvariantCulture, out _)) throw new ArgumentException("A hora esta no formato incorreto, HH:MM. Ex: 13:30 ");
            _hora = value;
        }   
    }

    public String Classe
    {
        get => _classe;

        set
        {
            var v = value?.Trim().ToLower();
            
            if (v == null) _classe = "pessoal";

            if(!ClassesValidas.Contains(v)) throw new ArgumentException("valor de classe invalido !");
            
            _classe = v;
        }
    }

    public Task() {
        
    }
    public Task (String hora, String classe, String titulo, String corpo, bool concluido) {
        Hora = hora;
        Classe = classe;
        Titulo = titulo;
        Corpo = corpo;
        Concluido = concluido;
    }

}