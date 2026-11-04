using MediatR;
using Aplicacao.DatasCalendario.Ehoje.Query;
namespace Aplicacao.DatasCalendario.Ehojee.QueryHandler;
 
 public class EhojeQueryHandler : IRequestHandler <EhojeQuery , bool>
 {
    
     public async Task<bool> Handle(EhojeQuery request, CancellationToken cancellationToken)
    {
        return await Ehoje();
    }
    public async Task<bool> Ehoje()
        {
            bool Everdadeiro = true;
            return Everdadeiro;
        }

   
}
 