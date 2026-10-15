namespace Request.TaskRequest;
using Models.Task;

public record TaskRequest (String Hora, String Classe, String Titulo, String Corpo, bool Concluido);