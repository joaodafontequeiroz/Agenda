namespace Aplicacao.Tarefas.AdicionarTarefa.QueryHandler;
using Dominio.Interfaces.Interface;
using MediatR;
using Aplicacao.Tarefas.AdicionarTarefa.Query;


public class AdicionarTarefaCommandHandler : IRequestHandler<AdicionarTarefaCommand, bool> 
    {   
        private readonly ITarefasRepositorio c;
        public AdicionarTarefaCommandHandler(ITarefasRepositorio _c)
    {
        c = _c;
    }
        public async Task<bool> Handle(AdicionarTarefaCommand request, CancellationToken cancellationToken)
    {
        var resultado =  await c.AdicionarAsync( request.Hora, request.Classe, request.Titulo, request.Corpo, request.Concluido);   
        return resultado;
        
    }
        
    
   }


        