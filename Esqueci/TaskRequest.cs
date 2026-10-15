namespace Esqueci.TaskRequest;
using Modules.Task;

public record TaskRequest (String Hora, String Classe, String Titulo, String Corpo, bool Concluido);