using MediatR;
using Aplicacao.DatasCalendario.ObterDataEmNumero.Query;
namespace  Aplicacao.DatasCalendario.ObterDataEmNumero.QueryHandler;

public class ObterDataEmNumeroQueryHandler : IRequestHandler<ObterDataEmNumeroQuery , int>
{
    
    public async Task<int> Handle(ObterDataEmNumeroQuery request, CancellationToken cancellationToken)
    {
        return await PegarDataNumero();
    }
    public async static Task<int> PegarDataNumero()
    {
        var Data = DateTime.Now.Day;
        return Data;
    }
}
    